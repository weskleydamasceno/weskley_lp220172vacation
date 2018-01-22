using System;
using System.Collections.Generic;
using bll;

namespace app
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Dictionary<string, int> pessoas = new Dictionary<string, int>();
            pessoas.Add("pessoa1", 23);
            pessoas.Add("pessoa2", 36);

            foreach (KeyValuePair<string, int> pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Key}");
                Console.WriteLine($"Idade: {pessoa.Value}");
            }


            List<string> newPessoa = new List<string>();
            newPessoa.Add("pessoa1");
            newPessoa.Add("pessoa2");

            Console.WriteLine($"Qtde de pessoas: {newPessoa.Count}");
        }
    }
}
