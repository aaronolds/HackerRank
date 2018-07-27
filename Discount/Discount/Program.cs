using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] prices = { 5, 1, 3, 4, 6, 2 };
            int[] prices = { 5,0};
            //int[] prices = { 1, 3, 3, 2, 5 };

            finalPrice(prices);
            Console.ReadKey();
        }

        static void finalPrice(int[] prices)
        {

            var totalPrice = 0;
            var nonDiscountedItems = new List<int>();

            for (var index = 0; index < prices.Length; index++)
            {
                var price = prices[index];
                var lessThanOrEqual = prices.Skip(index + 1).FirstOrDefault(x => x <= price);
                if (lessThanOrEqual == 0)
                {
                    nonDiscountedItems.Add(index);
                }
                totalPrice += price - lessThanOrEqual;
            }

            Console.WriteLine(totalPrice);
            Console.WriteLine(string.Join(" ", nonDiscountedItems));
        }
    }
}
