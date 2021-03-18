using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Zad1
{
    public class Program
    {
       
        public static void Main()
        {
            Plecak plecak = new Plecak(10, 50, 50);
            plecak.GenerateItems();
            plecak.WriteItems();
            plecak.GatherItems();
            plecak.WriteList();

        }
    }
}
