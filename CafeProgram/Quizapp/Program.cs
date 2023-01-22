using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
  
    public static void StartMenu(ArrayList list)
    {
      
       
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {list[i]}");
        }
    }
  
    public static void ShowList(int sum = 0)
    {
       

        ArrayList anayemekler = new ArrayList()
        {
            "Sahplov-10" , "Dolma-6" , "Dovğa-3" , "Kotlet-5"
        };
        ArrayList ickiler = new ArrayList()
        {
            "Su-1" ,"Kompot-3" ,"Fanta-2"
        };
        ArrayList sirniyyatlar = new ArrayList()
        {
            "Paxlava-2"  ,"Badambura-1" ,"Tort-2"
        };
        ArrayList salatlar = new ArrayList()
        {
            "salat-5" , "dondurma-3"
        };
        string user = "\nSecim edin: ";
        Console.Write(user);
        string choosen = Console.ReadLine();
     
        switch (choosen)
        {
            case "1":
                StartMenu(anayemekler);
                break;
                case "2":
                StartMenu(ickiler);
                break;
                case "3":
                StartMenu(sirniyyatlar);
                break;
                case "4":
                StartMenu(salatlar);
                break;
            default:
                Console.WriteLine("Bele bir secim yoxdur");
                break;
        }
        Console.Write("Alacaginiz yemeyi ve ya ickini secin: " );
        string user2 = Console.ReadLine();
        if (choosen == "1")
        
            sum += int.Parse(anayemekler[int.Parse(user2) - 1].ToString().Split('-')[1]);
        
        else if(choosen == "2")
        
            sum += int.Parse(ickiler[int.Parse(user2) - 1].ToString().Split('-')[1]);
        
        else if (choosen == "3")
        
            sum += int.Parse(sirniyyatlar[int.Parse(user2) - 1].ToString().Split('-')[1]);
        
        else if(choosen=="4")
        
            sum += int.Parse(salatlar[int.Parse(user2) - 1].ToString().Split('-')[1]);
        else      
            Console.WriteLine("duzgun deyer daxil edin");
        Console.WriteLine("Umumi meblleg: " + sum  + " manat");
        Console.WriteLine("Basqa nese almaq isteyirsinizmi? ");
        bool davam = Console.ReadLine().ToLower()=="y" ? true:false;
        if (davam == true)
            ShowList(sum);
        else
        {
            Console.WriteLine("Tesekkurler");
            Console.WriteLine("Umumi meblleg: " + sum + " manat");
            return;
        }
    }

    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("------------------------                            XOŞ GELMİSİNİZ!                             ------------------------");
        Console.WriteLine("                                                      Menyu secin                                                            ");
        ArrayList menyular = new ArrayList()
        {
            "anayemekler", "ickiler", "sirniyyatlar", "salatlar"
        };
        foreach (object i in menyular)
        {
            Console.WriteLine(i);
        }
        ShowList();
    }
}