using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao15_generics_set_dictionary.Service
{
    internal class PrintService<T>
    {
        /*Aula 213 - generics parte 1 - Problema motivador 1 (reuso) */
        //private int[] _values = new int[10];
        //private int _count = 0;
        //public void AddValue(int value)
        //{
        //    if (_count == 10)
        //    {
        //        throw new InvalidOperationException("PrintService is full");
        //    }
        //    _values[_count] = value;
        //    _count++;
        //}
        //public int First()
        //{
        //    if (_count == 0)
        //    {
        //        throw new InvalidOperationException("PrintService is empty");
        //    }
        //    return _values[0];
        //}
        //public void Print()
        //{
        //    Console.Write("[");
        //    for (int i = 0; i < _count - 1; i++)
        //    {

        //        Console.Write(_values[i] + ", ");
        //    }
        //    if (_count > 0)
        //    {
        //        Console.Write(_values[_count - 1] + "]");
        //    }
        //}

        /*Aula 214 - generics parte 2 - Problema motivador  (type safety & performance)*/
        //não é legal usar o object, pois pode ser qualquer tipo de valor ou seja não é type safety
        /*private object[] _values = new object[10];
        private int _count = 0;
        public void AddValue(object value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }
        public object First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }
        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {

                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1] + "]");
            }
        }*/

        /*Solução com generics*/
        private T[] _values = new T[10];
        private int _count = 0;
        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }
        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }
        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {

                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1] + "]");
            }
        }

    }
}
