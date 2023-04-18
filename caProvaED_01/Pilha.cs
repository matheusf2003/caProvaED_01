using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaED_01
{
    internal class Pilha
    {
        // atributos 
        private NoPilha topo;
        // metodos
        public Pilha()
        {
            topo = null; // não foi inserido elemento
        }
        public bool isEmpty()
        {
            if (topo == null)
                return true;
            else
                return false;
        }

        public void push(char insertItem)
        {
            if (isEmpty()) // true
                topo = new NoPilha(insertItem);
            else
            {
                NoPilha novoNoh = new NoPilha(insertItem);
                novoNoh.setNext(topo); // faz  o encadeamento
                topo = novoNoh; // o topo agora aponta para mim -- this
            }
        } // fim do método push
        public char Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Pilha Vazia");
                return ' ';
            }
            else
            {
                char temp = topo.getData();
                topo = topo.getNext();
                return (temp);
            }

        }

        public void print()
        {
            if (isEmpty())
                Console.WriteLine("Pilha Vazia");
            else
            {
                Console.WriteLine("Status atual da Pilha:");
                NoPilha temp = topo;

                while (temp != null)
                {
                    Console.WriteLine("\n" + temp.getData());
                    temp = temp.getNext();
                } // fim do while
            } // fim do else 
        } // fim do método print
    }
}
