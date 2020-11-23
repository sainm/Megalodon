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
            if (options.Port.HasValue)
            {
                var listener = new Listener(options.Port.Value);
                listener.Start();
            }
            throw new NotImplementedException();
        }
    }
}