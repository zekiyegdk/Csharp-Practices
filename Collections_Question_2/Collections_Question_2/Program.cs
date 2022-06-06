using System;
using System.Collections;

/* Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve 
   bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
*/

namespace Collections_Question_2
{
    class Program
    {
        static void Main(string[] args)
        {            
            ArrayList arrList = new ArrayList();
            int number;

            Console.WriteLine("20 tane sayı giriniz.");
            try
            {
                for (int i = 1; i <= 20; i++)
                {
                    Console.WriteLine("{0}.sayıyı giriniz.", i);
                    number = int.Parse(Console.ReadLine());
                    arrList.Add(number);
                }            
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lütfen pozitif sayı giriniz:" + ex.Message);
            }

            //Küçük sayılar üzerinde işlemler
            arrList.Sort();
            ArrayList smallNumber = arrList.GetRange(0,3);
            int totalSmall = 0;

            Console.WriteLine("En küçük 3 sayı: ");
            foreach (int item in smallNumber)
            {
                Console.WriteLine(item + " ");
                totalSmall += item;
            }
            int smallAverage = totalSmall / smallNumber.Count;
            Console.WriteLine("En küçük 3 sayının ortalaması:{0} ", smallAverage);

            //Büyük sayılar üzerinde işlemler
            arrList.Sort();
            arrList.Reverse();
            ArrayList bigNumber = arrList.GetRange(0, 3);
            int totalBig = 0;

            Console.WriteLine("En büyük 3 sayı: ");
            foreach (int item in bigNumber)
            {
                Console.WriteLine(item + " ");
                totalBig += item;
            }
            int bigAverage = totalBig / bigNumber.Count;
            Console.WriteLine("En büyük 3 sayının ortalaması:{0} ", bigAverage);

            //Büyük sayıların ve küçük sayıların ortalama toplamı
            Console.WriteLine("Ortalama toplamları:{0} ", bigAverage + smallAverage);









        }
    }
}
