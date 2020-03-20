using System;
using System.IO;
using Cw2.constants;
using Cw2.logger;
using Cw2.services;

namespace Cw2
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Begin converter: ");
            var serializationChooser = new SerializationChooserService();
            serializationChooser.ChoseSerializationType(args[0], args[1], args[2]);
        }
    }
}