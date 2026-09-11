using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventures_Guild;
using Adventures_Guild.Characters;
using Adventures_Guild.Commissions;
using Adventures_Guild.Exceptions;
using Adventures_Guild.Helpers;
using Adventures_Guild.Strategies;

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