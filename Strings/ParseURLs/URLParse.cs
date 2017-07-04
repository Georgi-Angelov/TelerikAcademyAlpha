using System;
using System.Text;
using System.Text.RegularExpressions;

class ParseURL
{
    static void Main()
    {
        string URL = Console.ReadLine();
        
        var fragments = Regex.Match(URL, "(.*)://(.*?)(/.*)").Groups;

        //Console.WriteLine("URL Address: {0}", URL);
        Console.WriteLine("[protocol] = {0}", fragments[1]);
        Console.WriteLine("[server] = {0}", fragments[2]);
        Console.WriteLine("[resource] = {0}", fragments[3]);
    }
}