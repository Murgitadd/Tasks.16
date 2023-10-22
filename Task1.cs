using System;
using System.Collections.Generic;

class PrLang
{
    public string Name { get; set; }
    public DateTime CreationDate { get; set; }
}

class Program
{
    static void Main()
    {
    	
        List<PrLang> prlangs = new List<PrLang>
        {
            new PrLang { Name = "C", CreationDate = new DateTime(1972, 1, 1) },
            new PrLang { Name = "Python", CreationDate = new DateTime(1991, 2, 20) },
            new PrLang { Name = "Java", CreationDate = new DateTime(1995, 5, 23) },
            new PrLang { Name = "C#", CreationDate = new DateTime(2000, 12, 31) }
           
            
        };

        prlangs.Sort((lang1, lang2) => lang1.CreationDate.CompareTo(lang2.CreationDate));

        foreach (var language in prlangs)
        {
            Console.WriteLine(language.Name + " - " + language.CreationDate.ToShortDateString());
        }
        Console.ReadLine();
    }
}
