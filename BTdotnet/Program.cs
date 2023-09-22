using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTdotnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int dem = 0;
            Console.Write("Nhap so luong phan tu :");
            int n= Convert.ToInt32(Console.ReadLine()); 
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu " + (i + 1)+ ": ");
                A[i] = Convert.ToInt32(Console.ReadLine());
                if (max <= A[i])
                {
                    max = A[i];
                    dem = i+1;
                }

            }
            Console.WriteLine("Cac phan tu Mang :");
            for (int i = 0;i < n; i++)
            {
                Console.WriteLine("Phan Tu "+(i+1) +" la :" + A[i] );
            }
            Console.WriteLine("So lon nhat :" + max);
            Console.WriteLine("Vi tri :" + dem);





            Console.ReadKey();  
        }
    }
}
