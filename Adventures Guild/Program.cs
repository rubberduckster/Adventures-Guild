using Adventures_Guild.Characters;
using Adventures_Guild.Commissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures_Guild
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void ShowCommissionCompleted(Commission commission)
        {
            Console.WriteLine($"Commission completed: {commission.Name}");
        }
    }
}