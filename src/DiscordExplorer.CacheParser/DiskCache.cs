using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace DiscordExplorer.CacheParser
{
    /* Constants / Structures taken from:
	 * https://src.chromium.org/viewvc/chrome/trunk/src/net/disk_cache/blockfile/disk_format.h?view=markup
	 * https://src.chromium.org/viewvc/chrome/trunk/src/net/disk_cache/blockfile/disk_format_base.h?view=markup
	 */

    using CacheAddr = UInt32;

    internal class DiskCache
    {

		// Index constants
        internal const Int32 kIndexTablesize = 0x10000;
        internal const UInt32 kIndexMagic = 0xC103CAC3;
        internal const UInt32 kCurrentVersion = 0x20000;  // Version 2.0.

		// Block Constants
		internal const UInt32 kBlockVersion2 = 0x20000;  // Version 2.0.
		internal const UInt32 kBlockCurrentVersion = 0x30000;  // Version 3.0.

		internal const UInt32 kBlockMagic = 0xC104CAC3;
		internal const Int32 kBlockHeaderSize = 8192;  // Two Pages: almost 64k entries
		internal const Int32 kMaxBlocks = (kBlockHeaderSize - 80) * 8;
		internal const Int32 kNumExtraBlocks = 1024;  // How fast files grow.

		internal static CacheAddrStruct parseCacheAddress(CacheAddr addr, bool debug = false) 
		{
			if (debug)
				Console.WriteLine($"Address:\t0x{addr:x}");

			CacheAddrStruct addrStruct = new CacheAddrStruct();
			addrStruct.initialized = (addr >> 28 >> 3) == 1;
			addrStruct.fileType = (byte)((addr >> 28) & 1);
			addrStruct.reserved = (byte)(addr >> 24 >> 2);
			addrStruct.blockSize = (byte)((addr >> 24) & 3);
			addrStruct.fileNumber = (byte)((addr >> 16) & 0xff);
			addrStruct.blockNumber = (UInt16)(addr & 0xffff);

			if (debug)
			{
				Console.WriteLine($"Initialized:\t{addrStruct.initialized}");
				Console.WriteLine($"fileType:\t{addrStruct.fileType}");
				Console.WriteLine($"blockSize:\t{addrStruct.blockSize}");
				Console.WriteLine($"FileNumber:\t{addrStruct.fileNumber}");
				Console.WriteLine($"blockNumber:\t0x{addrStruct.blockNumber:x}");
			}
			return addrStruct;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct CacheAddrStruct 
		{
			internal bool			initialized;	// 1  Bit.  Initialized flag
			internal byte			fileType;		// 3  Bits.	File Type, 0 = f_xxxx else data_xxxx
			internal byte			reserved;		// 2  Bits. 
			internal byte			blockSize;		// 2  Bits. The number of contiguous blocks 0 = 1 block, 3 = 4 blocks
			internal byte			fileNumber;		// 8  Bits. The value of the xxxx in data_xxxx
			internal UInt16			blockNumber;	// 16 Bits. The number of the block in the file
		};

        [StructLayout(LayoutKind.Sequential)]
        internal struct LruData
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            internal Int32[]		pad1;
            internal Int32			filled;          // Flag to tell when we filled the cache.
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            internal Int32[]		sizes;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            internal CacheAddr[]	heads;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            internal CacheAddr[]	tails;
            internal CacheAddr  	transaction;     // In-flight operation target.
            internal Int32       	operation;       // Actual in-flight operation.
            internal Int32       	operation_list;  // In-flight operation list.
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            internal Int32[]     	pad2;
        };

        [StructLayout(LayoutKind.Sequential)]
        internal struct IndexHeader
        {
            internal UInt32		magic;        // Magic number
            internal UInt32		version;      // Version number
            internal Int32		num_entries;  // Number of entries currently stored.
            internal Int32		num_bytes;    // Total size of the stored data.
            internal Int32		last_file;    // Last external file created.
            internal Int32		this_id;      // Id for all entries being changed (dirty flag).
            internal CacheAddr	stats;        // Storage for usage data.
            internal Int32		table_len;    // Actual size of the table (0 == kIndexTablesize).
            internal Int32		crash;        // Signals a previous crash.
            internal Int32		experiment;   // Id of an ongoing test.
            internal UInt64		create_time;  // Creation time for this set of files
            
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 52)]
            internal Int32[]	pad;          // pad out to 256 bytes
            internal LruData	lru;          // Eviction control data.
		}; 

		internal struct Index
		{
			internal IndexHeader		header;
			internal List<CacheAddr>	table;			

			// <summary>
			// Struct constructor. 
			// </summary>
			internal Index(IndexHeader header, List<CacheAddr> table)
			{
				this.header = header;
				this.table = table;
			}
		};

		[StructLayout(LayoutKind.Sequential)]
		internal struct BlockFileHeader
		{
			internal UInt32			magic;
			internal UInt32			version;
			internal Int16			this_file;		// Index of this file.
			internal Int16			next_file;		// Next file when this one is full.
			internal Int32			entry_size;		// Size of the blocks of this file. 
			internal Int32			num_entries;	// Number of stored entries.
			internal Int32			max_entries;	// Current maximum number of entries.
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			internal Int32[]		empty;			// Counters of empty entries for each type.
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			internal Int32[]		hints;			// Last used position for each entry type.
			internal volatile Int32	updating;		// Keep track of updates to the header.
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
			internal Int32[] 		user;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = (kMaxBlocks / 32))]
			internal Int32[]		allocation_map;	// Bitmap to track used blocks on a block-file
		};

		[StructLayout(LayoutKind.Sequential)]
		internal struct RankingsNode
		{
			internal UInt64			last_used;		// LRU info.
			internal UInt64			last_modified;	// LRU info.
			internal CacheAddr		next;			// LRU list.
			internal CacheAddr		prev;			// LRU list.
			internal CacheAddr		contents;		// Address of the EntryStore.
			internal Int32			dirty;			// The entry is being modified.
			internal UInt32			self_hash;		// RankingsNode's hash.
		};

		[StructLayout(LayoutKind.Sequential)]
		internal struct EntryStore
		{
			internal UInt32			hash;			// Full hash of the key.
			internal CacheAddr		next;			// Next entry with the same hash or bucket.
			internal CacheAddr		rankings_node;	// Rankings node for this entry.
			internal Int32			reuse_count;	// How often is this entry used.
			internal Int32			refetch_count;	// How often is this fetched from the net.
			internal Int32			state;			// Current state.
			internal UInt64			creation_time;	
			internal Int32			key_len;
			internal CacheAddr		long_key;		// Optional address of a long key.
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			internal Int32[]		data_size;		// We can store up to 4 data streams for each
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			internal CacheAddr[]	data_addr;		// entry.
			internal UInt32			flags;			// Any combination of EntryFlags.
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			internal Int32[]		pad;			
			internal UInt32			self_hash;		// The hash of EntryStore up to this point.
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256 - (24*4))]
			internal byte[]			key;			// null terminated
		};
		
		[Flags]
		internal enum EntryState
		{
			ENTRY_NORMAL,
			ENTRY_EVICTED,
			ENTRY_DOOMED
		};

		[Flags]
		internal enum EntryFlags
		{
			PARENT_ENTRY,
			CHILD_ENTRY
		};
    }
}