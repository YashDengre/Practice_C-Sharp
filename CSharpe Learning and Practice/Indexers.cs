using System;

namespace CSharpe_Learning_and_Practice
{
    public class Indexers
    {
        private string[] DexJarProducts = new string[size];
        public static int size = 10;

        public Indexers()
        {
            for (int i = 0; i < size; i++)
            {
                DexJarProducts[i] = "N.A";
            }
        }

        //Indexer:

        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= size || index < 0)
                {
                    throw new IndexOutOfRangeException("Index out of bound");
                }
                else
                {
                    tmp = DexJarProducts[index];
                }
                return tmp;
            }
            set
            {
                if (index >= size || index < 0)
                {
                    throw new IndexOutOfRangeException("Index out of bound");
                }
                else
                {
                    DexJarProducts[index] = value;
                }
            }
        }

        //overloaded indexer for returning the index of matched data
        public int this[string productName]
        {
            get
            {
                int index = 0;
                while (index < size)
                {
                    if (DexJarProducts[index] == productName)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }

        }

        //Generic Indexer


        public static void Main3(string[] tmp)
        {
            Indexers indexers = new Indexers();
            indexers[0] = "Grabar";
            indexers[1] = "DXAI";
            indexers[2] = "DXSOLVER";
            indexers[3] = "DXComp";

            for (int i = 0; i < Indexers.size; i++)
            {
                Console.WriteLine($"Index [{i}] : {indexers[i]}");
            }

            //using the second indexer with the string parameter to get the index
            Console.WriteLine(indexers["DXAI"]);
            Console.ReadKey();

            //Generic Indexer
            GenericIndexers<int> GI = new GenericIndexers<int>();
            GI[0] = 1;
            GI[1] = 2;
            GI[2] = 3;
            for (int i = 0; i < GenericIndexers<int>.size; i++)
            {
                Console.WriteLine($"Index [{i}] : {GI[i]}");
            }

            GenericIndexers<string> GINew = new GenericIndexers<string>();
            GINew[0] = "DXJCompute";
            GINew[1] = "DJAI";
            GINew[2] = "Grabar";
            for (int i = 0; i < GenericIndexers<string>.size; i++)
            {
                Console.WriteLine($"Index [{i}] : {GINew[i]}");
            }
            Console.ReadKey();


        }
    }

    public class GenericIndexers<T>
    {
        private T[] DexJarProducts = new T[size];
        public static int size = 10;
        //public GenericIndexers()
        //{
        //    for (int i = 0; i < size; i++)
        //    {
        //        DexJarProducts[i] = null;
        //    }
        //}

        public T this[int index]
        {
            get
            {
                if (index < 0 && index >= DexJarProducts.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                return (T)DexJarProducts[index];
            }
            set
            {
                if (index < 0 || index >= DexJarProducts.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                DexJarProducts[index] = (T)value;
            }
        }
    }
}
