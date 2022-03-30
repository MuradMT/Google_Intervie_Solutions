using System;

namespace Eolimp_Solutions
{
   
    class Program
    {
        static void Show(int[] arr)
        {
            Console.WriteLine("Arrayin elementleri:");
            for (int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
        static int [] Check(int [] arr)
        {
            int [] result= new int[arr.Length]; 
            int deyer = 1;
            for(int i = 0;i<arr.Length;i++)
            {
                for(int j = 0;j<arr.Length;j++)
                {
                    if (i != j)
                    {
                        deyer *= arr[j];

                    }
                }
                result[i] = deyer;
                deyer = 1;
            }
            return result;  
        }
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Show(Check(numbers));
            Console.ReadLine();
        }
    }
}
