using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaED_01
{
    internal class NoPilha
    {
        // atributos
        private char data; // pilha de inteiros 
        private NoPilha nextNoh; // autoreferencia

        // metodos 
        public NoPilha()
        { // construtor default
            data = ' ';
            nextNoh = null;
        }
        public NoPilha(char valor)
        {
            data = valor;
            nextNoh = null;
        }
        public NoPilha(char valor, NoPilha noh)
        {
            data = valor;
            nextNoh = noh;
        }

        public char getData()
        {
            return data;
        }
        public void setData(char valor)
        {
            data = valor;
        }
        public NoPilha getNext()
        {
            return nextNoh;
        }
        public void setNext(NoPilha newNoh)
        {
            nextNoh = newNoh;
        }
    }
}
