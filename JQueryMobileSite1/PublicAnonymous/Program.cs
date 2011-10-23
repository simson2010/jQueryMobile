using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil;

namespace PublicAnonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            var asmFile = args[0];
            Console.WriteLine("Making anonymous types public for '{0}'", asmFile);

            var asmDef = AssemblyDefinition.ReadAssembly(asmFile, new ReaderParameters
            {
                ReadSymbols=true
            });

            var anonymousType = asmDef.Modules.SelectMany(m => m.Types)
                                                .Where(t => t.Name.Contains("<>f__AnonymousType"));
            foreach (var type in anonymousType)
            {
                type.IsPublic = true;
            }

            asmDef.Write(asmFile, new WriterParameters
            {
                WriteSymbols = true
            });


        }
    }
}
