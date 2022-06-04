
using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Questions.Ques1();
            Questions.Ques2();
            Questions.Ques3();
            Questions.Ques4();
        }
    }

    class Questions
    {
        /*1.Konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            Kullanıcının girmiş olduğu sayılardan çift olanları console'a yazdırın.*/
        public static void Ques1()
        {
            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];

            Console.WriteLine("{0} adet pozitif sayı giriniz: ", number);
            for (int i = 0; i < number; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}.sayı:{1}", i + 1, numbers[i]);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    Console.WriteLine("Girdiğiniz sayılardan {0} bir çift sayıdır.", numbers[i]);

            }

        }

        /*2.Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.*/
        public static void Ques2()
        {
            Console.WriteLine("---------------------- 2.Soru-------------------------");

            Console.WriteLine("Lütfen 2 adet pozitif sayı giriniz: ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen {0} adet pozitif sayı giriniz: ", number1);
            int[] numbers = new int[number1];
            for (int i = 0; i < number1; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}. sayınız: {1}", i + 1, numbers[i]);
            }
            foreach (var item in numbers)
            {
                if (item == number2 || item % number2 == 0)
                    Console.WriteLine("Girdiğiniz {0} sayısı {1} ile eşit ya da tam bölendir.", item, number2);

                else
                    Console.WriteLine("Girdiğiniz {0} sayısı {1} ile eşit ya da tam bölen değildir.", item, number2);
            }

        }

        /*3.Konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
           Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.*/
        public static void Ques3()
        {
            Console.WriteLine("---------------------- 3.Soru-------------------------");

            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            string[] words = new string[number];

            Console.WriteLine("{0} adet kelime giriniz: ", number);

            for (int i = 0; i < number; i++)
            {
                words[i] = Console.ReadLine();
                Console.WriteLine("{0}. kelime: {1} ", i + 1, words[i]);
            }

            Array.Reverse(words);
            int j = 1;
            foreach (var item in words)
            {
                Console.WriteLine("Kelimelerin yeni sırası -> {0}. kelime: {1}", j, item);
                j++;
            }
        }

        /*4.Bir konsol uygulamasında kullanıcıdan bir cümle yazmasını isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın. */
        public static void Ques4()
        {
            Console.WriteLine("---------------------- 4.Soru-------------------------");

            Console.WriteLine("Lütfen bir cümle yazınız.");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Console.WriteLine("Cümledeki toplam kelime sayısı: " + words.Length);
            Console.WriteLine("Cümledeki harf sayısı: {0}", sentence.Length);
        }

    }
}
