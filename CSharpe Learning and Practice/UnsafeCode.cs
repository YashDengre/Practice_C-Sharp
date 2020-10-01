using System;

namespace CSharpe_Learning_and_Practice
{
    class UnsafeCode
    {
        public static unsafe void Main4(string[] commands)
        {
            int value = 20;
            int* pointer = &value;
            Console.WriteLine("Address : " + (int)pointer + " and Value is " + *pointer);

            //Pointers as parameter;
            int FValue = 20, SValue = 24;
            Console.WriteLine($"Before swap : First Value:{FValue} and Second Value:{SValue}");
            Swap(&FValue, &SValue);
            Console.WriteLine($"Before swap : First Value:{FValue} and Second Value:{SValue}");

            //Accessing Array Elements Using a Pointer
            ArrayExample();

            Console.ReadKey();
        }

        public static unsafe void Swap(int* first, int* second)
        {
            int temp = *first;
            *first = *second;
            *second = temp;
        }

        public static unsafe void ArrayExample()
        {
            int[] list = { 10, 100, 200 };
            fixed (int* ptr = list)

                /* let us have array address in pointer */
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Address of list[{0}]={1}", i, (int)(ptr + i));
                    Console.WriteLine("Value of list[{0}]={1}", i, *(ptr + i));
                }

        }
    }
}
