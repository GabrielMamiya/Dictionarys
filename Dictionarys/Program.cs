using System;
using System.Collections.Generic;

namespace Dictionarys
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> dicionario = new Dictionary<string, string>();

            dicionario.Add("Mylena", "Gabriel");

            foreach(var item in dicionario){
                Console.WriteLine(item);
            }
        }
    }
}
