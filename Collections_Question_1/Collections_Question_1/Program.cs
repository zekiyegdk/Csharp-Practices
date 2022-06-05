using System;
using System.Collections;

/* Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)
   -Negatif ve numeric olan girişleri engelleyin.
   -Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
   -Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın. 
*/

namespace Collections_Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primeNumber = new ArrayList();
            ArrayList  nonPrime = new ArrayList();

            int number;
            int totalPrime = 0;
            int totalNonPrime = 0;

            Console.WriteLine("Gireceğiniz 20 tane sayı asal olanlar ve olmayanlar olarak işlem görecektir.");

            int i = 1;
            while(i <= 20)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz" , i);
                bool control = int.TryParse(Console.ReadLine(), out number);

                if (control && number > 0)
                {
                    if (number == 2)
                        primeNumber.Add(number);
                   
                    else if (number == 0 || number == 1 || number % 2 == 0)
                        nonPrime.Add(number);

                    else                
                        primeNumber.Add(number);

                    i++;
                }

                else           
                    Console.WriteLine("Lütfen pozitif bir sayı giriniz.");            
            }

             //Asal Sayılar İle İşlemler
             primeNumber.Sort();
             primeNumber.Reverse();
             Console.WriteLine("Büyükten küçüğe asal sayılar: ");

             foreach (int item in primeNumber)
             {
                 Console.WriteLine(item + " ");
                 totalPrime += item;
             }

             Console.WriteLine("Asal sayıların eleman sayısı: {0}, Elemanların ortalaması: {1}", primeNumber.Count, totalPrime / primeNumber.Count);

             //Asal Olmayan Sayılar
             nonPrime.Sort();
             nonPrime.Reverse();
             Console.WriteLine("Büyükten küçüğe asal olmayan sayılar: ");

             foreach (int item in nonPrime)
             {
                 Console.WriteLine(item + " ");
                 totalNonPrime += item;
             }

             Console.WriteLine("Asal olmayanların eleman sayısı: {0}, Elemanların toplamı: {1}", nonPrime.Count, totalNonPrime / nonPrime.Count);

        }
        
    }
}
