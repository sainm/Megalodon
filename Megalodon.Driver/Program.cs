using System;
using System.Collections.Generic;
using CommandLine;

namespace Megalodon.Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(RunOptions)
                .WithNotParsed(HandleParseError);
        }

        private static void HandleParseError(IEnumerable<Error> obj)
        {
            // var listener = new Listener(port);
        }

        private static void RunOptions(Options options)
        {
            var port = 9999;
            if (options.Port.HasValue)

                port = options.Port.Value;

            try
            {
                var lister = new Listener(port);
                Console.WriteLine("Starting Windows Desktop Driver on port {0}\n", port);
            }
            catch (Exception e)
            {
                Logger.Fatal("Failed to start driver: {0}", e);
                throw;
            }

            throw new NotImplementedException();
        }
    }
}