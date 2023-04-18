using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaED_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isValid = CheckSyntax(input);
            Console.WriteLine(isValid ? "Sintaxe válida!" : "Sintaxe inválida!");
            Console.ReadLine();
        }
        static bool CheckSyntax(string input)
        {
            Pilha pilha = new Pilha();
            foreach (char c in input)
            {
                switch (c)
                {
                    case '(':
                    case '{':
                    case '[':
                        pilha.push(c);
                        break;
                    case ')':
                        if (pilha.isEmpty() || pilha.Pop() != '(')
                        {
                            return false;
                        }
                        break;
                    case '}':
                        if (pilha.isEmpty() || pilha.Pop() != '{')
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if (pilha.isEmpty() || pilha.Pop() != '[')
                        {
                            return false;
                        }
                        break;
                }
            }
            return pilha.isEmpty();

        }
    }
}
