using System;
using System.Linq.Expressions;

namespace Lahiye
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            Phone phn1 = new Phone() { Name = "Iphone 8", Price = 1100, CameraCount = 1 };
            Phone phn2 = new Phone() { Name = "Iphone 11", Price = 2400, CameraCount = 2 };
            Phone phn3 = new Phone() { Name = "Iphone 12", Price = 2800, CameraCount = 3 };
            Phone phn4 = new Phone() { Name = "Iphone", Price = 3600, CameraCount = 4 };
            Notebook nte1 = new Notebook() { Name = "Asus", Price = 2400, Model = "ROQ 500" };
            Notebook nte2 = new Notebook() { Name = "MacBok", Price = 5500, Model = "m2" };
            Notebook nte3 = new Notebook() { Name = "Lenovo", Price = 4500, Model = "XT-50" };
            PS ps1 = new PS() { Name = "PS3", Price = 400, Version = "X500" };
            PS ps2 = new PS() { Name = "PS4", Price = 800, Version = "X600" };
            PS ps3 = new PS() { Name = "PS3", Price = 1400, Version = "X700" };
            Product[] pr1 = { phn1, phn2, phn3, phn4, nte1, nte2, nte3, ps1, ps2, ps3 };
            string str1;
            do
            {
                Console.WriteLine("\n=============================  Menyu  =============================\n");
                Console.WriteLine("1.Butun mehasullara bax");
                Console.WriteLine("2.Notebooklara bax");
                Console.WriteLine("3.PS-lere bax");
                Console.WriteLine("4.Telefonlara bax");
                Console.WriteLine("5.Notebooklarin sayina bax");
                Console.WriteLine("6.Telefonlarin sayina baax");
                Console.WriteLine("7.PS-lerin sayina bax");
                Console.WriteLine("8.Notebooklarin ortalaa qoymeti");
                Console.WriteLine("9.Telefonlarin ortalama qiymeti");
                Console.WriteLine("10.PS-lerin ortalama qiymeti");
                Console.WriteLine("0.Menyudan cix");
                
                str1 = Console.ReadLine();
                switch (str1)
                {
                    case "1":
                        Console.WriteLine("\n========================  Butun Mehsullar  ==========================\n");
                        for (int i = 0; i < pr1.Length; i++)
                        {
                            Console.WriteLine(pr1[i].Name + "-" + pr1[i].Price);
                        }
                        break;
                    case "2":
                        Console.WriteLine("\n========================  Notebooklar  ==========================\n");
                        for (int i = 0; i < pr1.Length; i++)
                        {
                            if (pr1[i] is Notebook)
                                Console.WriteLine(pr1[i].Name + "-" + pr1[i].Price);
                        }
                        break;
                    case "3":
                        Console.WriteLine("\n========================  Telefonlar  ==========================\n");
                        for (int i = 0; i < pr1.Length; i++)
                        {
                            if (pr1[i] is PS)
                                Console.WriteLine(pr1[i].Name + "-" + pr1[i].Price);
                        }
                        break;
                    case "4":
                        Console.WriteLine("\n========================  PS-ler  ==========================\n");
                        for (int i = 0; i < pr1.Length; i++)
                        {
                            if (pr1[i] is Phone)
                                Console.WriteLine(pr1[i].Name + "-" + pr1[i].Price);
                        }

                        break;
                    case "5":
                        Console.WriteLine("\n========================  NotebookCount  ==========================\n");
                        int Notecount = 0;
                        for (int i = 0; i < pr1.Length; i++)
                        {
                            if (pr1[i] is Notebook)
                                Notecount++;
                        }
                        Console.WriteLine(Notecount);
                        break;
                    case "6":
                        Console.WriteLine("\n========================  PhoneCount  ==========================\n");
                        int PhoneCount = 0;
                        for (int i = 0; i < pr1.Length; i++)
                        {
                            if (pr1[i] is Notebook)
                                PhoneCount++;
                        }
                        Console.WriteLine(PhoneCount);
                        break;
                    case "7":
                        Console.WriteLine("\n========================  PSCount  ==========================\n");
                        int PSCount = 0;
                        for (int i = 0; i < pr1.Length; i++)
                        {
                            if (pr1[i] is Notebook)
                                PSCount++;
                        }
                        Console.WriteLine(PSCount);

                        break;
                    case "8":
                        Console.WriteLine("\n========================  Notebooklarin ortalamasi  ==========================\n");
                        double sum = 0;
                        int count = 0;
                        for (int i = 0; i < pr1.Length; i++)
                        {
                             if(pr1[i] is Notebook)
                            {
                                sum += pr1[i].Price;
                                count++;
                            }
                        }
                        Console.WriteLine(sum/count);
                        break;
                    case "9":
                        Console.WriteLine("\n========================  Telefonlarin ortalamsi  ==========================\n");
                        double sum1 = 0;
                        int count2 = 0;
                        for (int i = 0; i < pr1.Length; i++)
                        {
                            if (pr1[i] is Phone)
                            {
                                sum1 += pr1[i].Price;
                                count2++;
                            }
                        }
                        Console.WriteLine(sum1 / count2);
                        break;
                        case"10":
                        Console.WriteLine("\n========================  PS-lerin ortalamasi  ==========================\n");
                        double sum3 = 0;
                        int count3 = 0;
                        for (int i = 0; i < pr1.Length; i++)
                        {
                            if (pr1[i] is PS)
                            {
                                sum3 += pr1[i].Price;
                                count3++;
                            }
                        }
                        Console.WriteLine(sum3 / count3);
                        break;
                    case "0":
                        Console.WriteLine("Prosess bitdi");
                        return;
                        break;

                    default:
                        break;
                }




            } while (true);

        }
    }
}
