using System;
using System.Collections;

/* Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız. */

namespace Collections_Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            Console.WriteLine("Lütfen cümle yazınız.");
            string sentences = Console.ReadLine().ToLower();
            char[] letters = {'a','e','ı','i','o','ö','u','ü' };

            foreach (char sentence in sentences)
            {
                foreach (char letter in letters)
                {
                    if (sentence == letter)
                        
                        arrayList.Add(sentence);                    
                }
            }

            foreach (var item in arrayList)
            {
                Console.WriteLine("Dizinin elemanları: " + item);
            }
            
        }
    }
}
