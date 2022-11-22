using HtmlAgilityPack;
using System;

namespace WebScraping
{
    class Program
    {
        static void Main(string[] args)
        {
            getInfo();
        }

        static string url = "https://www.czc.cz/amd-ryzen-5-1600-s-chladicem-wraith-stealth-12nm/278460/produkt";

        static void getInfo()
        {
            HtmlWeb web = new HtmlWeb();

            var HtmlLink = web.Load(url);

            var price = HtmlLink.DocumentNode.SelectSingleNode("//span[@class='price-vatin']").InnerText;

            var productName = HtmlLink.DocumentNode.SelectSingleNode("//div[@class='pd-wrap']//h1").InnerText;

            Console.WriteLine("Jmeno Produktu:" + productName);

            Console.WriteLine("Cena Produktu:" + price);

            Console.ReadLine();
        }
    }
}
