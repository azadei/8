using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
       List<string> cities = new List<string>{ "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

        Console.WriteLine("write start char");
        char StartChart = Console.ReadLine().ToUpper()[0];

        Console.WriteLine("write end char");
        char EndChart = Console.ReadLine().ToUpper()[0];

        string foundCity = cities.Find(city => city.StartsWith(StartChart.ToString()) && city.EndsWith(EndChart.ToString()));

        if (foundCity != null)
        {

            Console.WriteLine("city startind with" + StartChart + "and ending with" +  EndChart + "is" + foundCity);
        }
        else
        {
            Console.WriteLine("no city starting with" + StartChart + "and ending with" + EndChart);
        }




    }
}