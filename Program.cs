using System;
using System.IO;

namespace Kitaplik_Projesi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int totalPrice = 0;
            string selection;
            Console.WriteLine("************************************************************************");
            Console.WriteLine();
            Console.WriteLine("**  Turkish Books Categories       **  English Books Categories    **");
            Console.WriteLine();
            Console.WriteLine("**  1-Calikusu: Resat Nuri         **  7-Tuna Kilavuzu: Jules Verne   **");
            Console.WriteLine();
            Console.WriteLine("**  2-Yaban: Yakup Kadri           **  8-Kuzey Macerasi: Jack London  **");
            Console.WriteLine();
            Console.WriteLine("**  3-Sinekli Bakkal: Halide Edip  **  9-Altinci Kogus: Anton Cehov   **");
            Console.WriteLine();
            Console.WriteLine("**  4-Tehlikeli Oyunlar: O.Atay    **  10-Kumarbaz: Dostoyevski       **");
            Console.WriteLine();
            Console.WriteLine("**  5-Gectigim Gunlerden: H.Yucel  **  11-Sehir Hikayesi: C.Dickens   **");
            Console.WriteLine();
            Console.WriteLine("**  6-Kuyucakli Yusuf: S.Ali       **  12-Visne Bahcesi: Anton Cehov  **");
            Console.WriteLine();
            Console.WriteLine("************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***** Opeations Menu *****");
            Console.WriteLine();
            Console.WriteLine("1-Price Inquiry");
            Console.WriteLine("2-New Reader Registration");
            Console.WriteLine("3-Book of the day");
            Console.WriteLine("4-Book Archive");
            Console.WriteLine("5-Buy New Book");
            Console.WriteLine("6-Game");
            Console.WriteLine();
            Console.WriteLine("Please Enter The Process Number: ");
            Console.WriteLine();
            char operation;
            operation = Convert.ToChar(Console.ReadLine());
            if (operation == '1')
            {
                Console.WriteLine();
                Console.Write("Please Enter The Number Of The Book You Want To Know The Price: ");
                string number;
                number = Console.ReadLine();
                switch (number)
                {
                    case "1":Console.Write("Calikusu: 15 TL"); break;
                    case "2":Console.Write("Yaban: 12 TL"); break;
                    case "3": Console.Write("Sinekli Bakkal: 8 TL"); break;
                    case "4": Console.Write("Tehlikeli Oyunlar: 22 TL"); break;
                    case "5": Console.Write("Gectigim Gunlerden: 10 TL"); break;
                    case "6": Console.Write("Kuyucakli Yusuf: 16 TL"); break;
                    case "7": Console.Write("Tuna Kilavuzu: 18 TL"); break;
                    case "8": Console.Write("Kuzey Macerasi: 5 TL"); break;
                    case "9": Console.Write("Altinci Kogus: 7 TL"); break;
                    case "10": Console.Write("Kumarbaz: 26 TL"); break;
                    case "11": Console.Write("Sehir Hikayesi: 25 TL"); break;
                    case "12": Console.Write("Visne Bahcesi: 11 TL"); break;
                }
            }
            if (operation == '2')
            {
                Console.WriteLine();
                Console.WriteLine("***** New Reader Registration *****");
                string name, surname, university;
                Console.Write("Please Enter Your Name: ");
                name = Console.ReadLine();
                Console.Write("Please Enter Your Surname: ");
                surname = Console.ReadLine();
                Console.Write("Please Enter Your University Name: ");
                university = Console.ReadLine();

                string dosya = @"/Users/boss/Desktop/kullanici";
                StreamWriter sw = new StreamWriter(dosya); // Kutuphane kismina using System.IO ekliyoruz
                sw.WriteLine("Your Name: " + name);
                sw.WriteLine("Your Surname: " + surname);
                sw.WriteLine("Your University: " + university);
                sw.Close();
                
            }
            if (operation == '3')
            {
                Console.WriteLine();
                Console.WriteLine("***** Book of the day *****");
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
                Console.WriteLine("************* CALIKUSU *************");
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
            }
            if (operation == '4')
            {
                Console.WriteLine();
                Console.WriteLine("***** Book Archive *****");
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
                
                FileStream fs = new FileStream(@"/Users/boss/Desktop/Kitaplar.rtf", FileMode.Open,FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string text = sr.ReadLine();
                while (text != null)
                {
                    Console.WriteLine(text);
                    text = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                // book archive section
                Console.WriteLine("************************************");
                Console.WriteLine();
            }
            if (operation == '5')
            {
                for (int i = 0; i <= 50; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter the Number of the Book You Want to Buy: ");
                    selection = Console.ReadLine();
                    if (selection == "1")
                    {
                        totalPrice = totalPrice + 15;
                    }
                    else if (selection == "2")
                    {
                        totalPrice = totalPrice + 12;
                    }
                    else if (selection == "3")
                    {
                        totalPrice = totalPrice + 8;
                    }
                    else if (selection == "4")
                    {
                        totalPrice = totalPrice + 22;
                    }
                    else if (selection == "5")
                    {
                        totalPrice = totalPrice + 10;
                    }
                    else if (selection == "6")
                    {
                        totalPrice = totalPrice + 16;
                    }
                    else if (selection == "7")
                    {
                        totalPrice = totalPrice + 18;
                    }
                    else if (selection == "8")
                    {
                        totalPrice = totalPrice + 5;
                    }
                    else if (selection == "9")
                    {
                        totalPrice = totalPrice + 7;
                    }
                    else if (selection == "10")
                    {
                        totalPrice = totalPrice + 26;
                    }
                    else if (selection == "11")
                    {
                        totalPrice = totalPrice + 25;
                    }
                    else if (selection == "12")
                    {
                        totalPrice = totalPrice + 11;
                    }
                    else

                    Console.WriteLine("The Book Number You Have Entered Is Not Available.");
                    Console.WriteLine();
                    Console.Write("Would you like to buy another book? ");
                    string cevap = Console.ReadLine();

                    if (cevap == "n" || cevap == "N" || cevap == "no" || cevap == "No" || cevap == "hayır" || cevap == "HAYIR")
                        break;

                }
                Console.WriteLine("Total Price: " + totalPrice);

            }
            if (operation == '6')
            {
                Console.WriteLine();
                int guess = 0;
                Random rnd = new Random();
                int sayi = rnd.Next(1, 100);
                while (sayi != guess)
                {
                    Console.Write("Please Enter a Number: ");
                    guess = Convert.ToInt16(Console.ReadLine());
                    if (guess > sayi)
                    {
                        Console.Write("Enter a Smaller Number: ");
                    }
                    if (guess < sayi)
                    {
                        Console.Write("Enter a Bigger Number: ");
                    }
                    if (guess == sayi)
                    {
                        Console.Write("*****  Congratulations  *****");
                    }
                }

            }

        }
    }
}
