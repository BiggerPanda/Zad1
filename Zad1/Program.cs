using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Plecak plecak = new Plecak(10,50,50);
            plecak.GenerateItems();
            plecak.WriteList();
            
        }
    }
}
