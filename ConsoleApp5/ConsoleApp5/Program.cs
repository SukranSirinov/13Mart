using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lenghtStr;
            int lenght;
            do
            {
                Console.WriteLine("kitablarin sayini daxil edin");
                lenghtStr = Console.ReadLine();
                lenght = int.Parse(lenghtStr);

            } while (lenght < 0);
            Book[] books = new Book[lenght];

            for (int i = 0; i < lenght; i++)
            {

                int count = GetinputInt($"{i + 1}. kitabin sayi:", 0, 1000);

                double price = Getinputdouble($"{i + 1}.kitabin qiymetini :", 0, double.MaxValue);

                string genre = GetInputStr($"{i + 1}.kitabin janrini ", 0, 100);

                int no = GetinputInt($"{i + 1}. kitabin nomresi:", 0, 100);

                string name = GetInputStr($"{i + 1}.kitabin adi ", 0, 15);

                books[i] = new Book(no, name, price, genre)
                {
                    Count = count,

                };
            }
            Console.WriteLine("\n======================\n");
            //Console.WriteLine("books:");
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine("-----------");
            //    Console.WriteLine($"{i + 1}.ci book: ");
            //    Console.WriteLine(books[i].Getinfo());
            //}
            Book[] filtrlenmisdepo = Filtrle(books, 70, 150);
            foreach (Book book in filtrlenmisdepo)
            {
                Console.WriteLine(book.Getinfo());
            }
        }

        static string GetInputStr(string name, int min, int max)
        {
            string input;
            do
            {
                Console.WriteLine(name);
                input = Console.ReadLine();

            } while (input.Length < min || input.Length > max);
            return input;

        }
        static int GetinputInt(string name, int min, int max)
        {
            int input;
            string inputStr;
            do
            {
                Console.WriteLine(name);
                inputStr = Console.ReadLine();
                input = Convert.ToInt32(inputStr);

            } while (input < min || input > max);
            return (input);
        }
        static double Getinputdouble(string name, double min, double max)
        {
            double input;
            string inputStr;
            do
            {
                Console.WriteLine(name);
                inputStr = Console.ReadLine();
                input = Convert.ToDouble(inputStr);

            } while (input < min || input > max);
            return (input);
        }
        static Book[] Filtrle(Book[] Depo, double minPrice, double maxPrice)
        {
            int count = 0;
            foreach (Book item in Depo)
            {
                if (item.Price > minPrice && item.Price < maxPrice)
                {
                    count++;
                }
            }
            Book[] newDepo = new Book[count];
            int index = 0;
            for (int i = 0; i < Depo.Length; i++)
            {
                newDepo[index] = Depo[i];
                index++;
            }
            return newDepo;
        }


    }


}
