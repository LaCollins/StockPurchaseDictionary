using System;
using System.Collections.Generic;
using System.Linq;

namespace StockPurchaseDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> purchaseInfo = new Dictionary<string, double>();

            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("NFLX", "Netflix");
            stocks.Add("CYBR", "CyberArk Software");
            stocks.Add("ATVI", "Activision Blizzard");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "CYBR", shares: 100, price: 20.20));
            purchases.Add((ticker: "CYBR", shares: 30, price: 17.17));
            purchases.Add((ticker: "CYBR", shares: 50, price: 19.19));
            purchases.Add((ticker: "NFLX", shares: 60, price: 22.22));
            purchases.Add((ticker: "ATVI", shares: 50, price: 100.50));
            purchases.Add((ticker: "ATVI", shares: 32, price: 80.19));

            foreach (var stock in stocks)
            {
                var stockTicker = stock.Key;
                var priceSum = purchases.Where(purchase => purchase.ticker == stockTicker).Select(purchase => purchase.price).Sum();
                var shareSum = purchases.Where(purchase => purchase.ticker == stockTicker).Select(purchase => purchase.shares).Sum();
                purchaseInfo.Add(stock.Value, Math.Round(priceSum * shareSum));
            }

            foreach (var purchasedStock in purchaseInfo)
            {
                Console.WriteLine($"{purchasedStock.Key}: {purchasedStock.Value}");
            }

            Console.ReadKey();

            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                // Does the company name key already exist in the report dictionary?
                // If it does, update the total valuation
                // If not, add the new key and set its value
            }
        }
    }
}
