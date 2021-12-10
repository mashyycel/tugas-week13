
using System;
using System.Collections.Generic;

namespace week13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. My scroll list \n2. Add scroll \n3. Search scroll \n4. Remove scroll \nChoose what to do:");
            int pilihan = Convert.ToInt32(Console.ReadLine());
            List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };
            string namabuku = "";
            List<string> newScrolls = new List<string>();
            while (pilihan == 1 || pilihan == 2 || pilihan == 3 || pilihan == 4)
            {
                if (pilihan == 1)
                {
                    Console.Write("Scroll to learn list: ");
                    foreach (string scroll in scrolls)
                    {
                        int index = scrolls.IndexOf(scroll);

                        Console.Write("\nScroll " + (index + 1) + ": " + scroll);


                    }


                }
                else if (pilihan == 2)
                {
                    Console.Clear();
                    Console.WriteLine("How many scroll to add: ");
                    int tambahan = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("In what number of queue? ");
                    int urutan = Convert.ToInt32(Console.ReadLine());
                    int terakhir = scrolls.IndexOf(namabuku);

                    for (int i = 0; i < tambahan; i++)
                    {
                        Console.Write("Scroll " + (i + 1) + " name: ");
                        newScrolls.Add(Console.ReadLine());
                    }
                    int counter = -1;
                    foreach (string scroll in newScrolls)
                    {
                        scrolls.Insert(urutan + counter, scroll);
                        counter++;

                    }
                    newScrolls.Clear();

                }
                else if (pilihan == 3)
                {

                    Console.WriteLine("Insert scroll name: ");

                    string bukuYangDicari = Console.ReadLine();
                    scrolls = scrolls.ConvertAll(d => d.ToLower());
                    bukuYangDicari = bukuYangDicari.ToLower();
                    if (scrolls.Contains(bukuYangDicari) == true)
                    {

                        int index = scrolls.IndexOf(bukuYangDicari);
                        Console.WriteLine("Book Found. Queue number: " + (index + 1));
                    }
                    else
                    {
                        Console.WriteLine("Book not found");
                    }

                }
                else if (pilihan == 4)
                {

                    Console.WriteLine("Remove from list by scroll name? Y/N: ");
                    string pilihanHapusScroll = Console.ReadLine();
                    while (pilihanHapusScroll != "y" && pilihanHapusScroll != "n")
                    {
                        Console.WriteLine("Wrong selection. Choose again: ");
                        pilihanHapusScroll = Console.ReadLine();
                    }
                    if (pilihanHapusScroll == "y")
                    {

                        Console.WriteLine("Input scroll name:");
                        string namaBukuYangDihapus = Console.ReadLine();
                        scrolls = scrolls.ConvertAll(d => d.ToLower());
                        namaBukuYangDihapus = namaBukuYangDihapus.ToLower();
                        if (scrolls.Contains(namaBukuYangDihapus) == true)
                        {
                            scrolls.Remove(namaBukuYangDihapus);
                            Console.WriteLine("Book Removed!");
                        }
                        else
                        {
                            Console.WriteLine("Book not found!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input scroll queue:");
                        int posisiBukuYangDihapus = Convert.ToInt32(Console.ReadLine());

                        while (posisiBukuYangDihapus < 1 || posisiBukuYangDihapus > scrolls.Count)
                        {
                            Console.WriteLine("Queue not found. Insert scroll queue: ");
                            posisiBukuYangDihapus = Convert.ToInt32(Console.ReadLine());
                        }
                        scrolls.RemoveAt(posisiBukuYangDihapus - 1);
                        Console.WriteLine("Book Removed!");
                    }
                }

                Console.WriteLine("\n1. My scroll list \n2. Add scroll \n3. Search scroll \n4. Remove scroll \nChoose what to do:");
                pilihan = Convert.ToInt32(Console.ReadLine());

            }








        }
    }
}
