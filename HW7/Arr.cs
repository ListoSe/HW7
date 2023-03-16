

using System.Diagnostics.Metrics;

namespace HW7
{
    class Arr : ICalc, IOutput2, ICalc2
    {
        private int[] arr;
        public Arr(int size)
        {
            arr = new int[size];
        }
        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set { arr[index] = value; }
        }

        public int CountDistinct()
        {
            int counter = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        counter--;
                        break;
                    }
                }
            }
            return counter;
        }

        public int EqualToValue(int valueToCompare)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == valueToCompare)
                {
                    counter++;
                }
            }
            return counter;
        }

        public int GetSize()
        {
            return arr.Length;
        }

        public int Greater(int valueToCompare)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]> valueToCompare)
                {
                    counter++;
                }
            }
            return counter;
        }

        public int Less(int valueToCompare)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < valueToCompare)
                {
                    counter++;
                }
            }
            return counter;
        }
        public void Show()
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        public void ShowEven()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
