﻿using System;
using System.IO;
using CommandLine;
using DiscordExplorer.CacheParser;

namespace DiscordExplorer.CLI
{
    public class Options
    {
        [
            Option(
                'd', "cache_dir",
                Required = false,
                HelpText = "Specify the directory of the cache files"
            )
        ]
        public string CacheDir { get; set; }

        [
            Option(
                'o', "output_dir",
                Required = false,
                HelpText = "Specify the directory of the output files"
            )
        ]
        public string OutDir { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(o => 
                {
                    // handle the cache directory 
                    // try to use the local discord one if one isn't provided
                    string cacheDir = o.CacheDir;
                    if (string.IsNullOrEmpty(cacheDir))
                    {
                        // This should be the path to the main discord cache
                        cacheDir = Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                            "discord", "Cache"
                        );
                    }
                    else if (!Path.IsPathRooted(cacheDir))
                    {
                        // Treat the path as a relative path
                        cacheDir = Path.Combine(
                            Directory.GetCurrentDirectory(),
                            cacheDir
                        );
                    }

					string outDir = o.OutDir;
					if (!string.IsNullOrEmpty(o.OutDir) && !Directory.Exists(outDir)) {
						Console.WriteLine($"{0} is not a valid directory\n", outDir);
						return;
					}


                    // Basic logging while developing
                    Console.WriteLine($"Current Arguments -> CacheDir: {cacheDir}");
                    CacheParse.parse(cacheDir);
                }
            );
        }
    }
}
