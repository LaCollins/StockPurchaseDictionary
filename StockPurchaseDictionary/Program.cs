using System;
using System.Collections.Generic;

namespace StockPurchaseDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
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

            //Create a total ownership report that computes the total value of each stock that you have purchased.
            //This is the basic relational database join algorithm between two tables.

            /*
             * Define a new Dictionary to hold the aggregated purchase information. - The key should be a string that is the full company name.
             * The value will be the valuation of each stock (price*amount) { "General Electric": 35900, "AAPL": 8445, ... }
            */
            // Iterate over the purchases and update the valuation for each stock
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                // Does the company name key already exist in the report dictionary?
                // If it does, update the total valuation
                // If not, add the new key and set its value
            }
        }
    }
}
