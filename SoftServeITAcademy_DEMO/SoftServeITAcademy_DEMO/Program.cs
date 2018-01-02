using System;
using System.Collections.Generic;

namespace SoftServeITAcademy_DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            JewelryStore jewelryStore = new JewelryStore();
            jewelryStore.GetStores(10);
            jewelryStore.PrintStore();

            JewelryDecoration jewelryDecoration = new JewelryDecoration();
            jewelryDecoration.GetRandomJewelry(10);
            jewelryDecoration.PrintJewelry();

            //List<JewelryDecoration> jewelryDecoration = new List<JewelryDecoration>();

            Console.ReadKey();
        }
    }
}
