using Cape_Senior_Center_Inventory_System.Interfaces;
using Castle.Windsor;
using Castle.Windsor.Installer;
using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cape_Senior_Center_Inventory_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainAsync().Wait();
            IWindsorContainer container = new WindsorContainer();
            //register concrete implementations for container
            container.Install(FromAssembly.This());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(container.Resolve<IController>()));
           }

        static async Task MainAsync()
        {
            var client = new MongoClient();
            var db = client.GetDatabase("VizOnWheels");
            string[] collectionNames = { "Category", "Inventory", "Item", "ItemCategory", "Price", "UnitOfMeasure" };

            foreach(string collectionName in collectionNames) {
                if (!db.ListCollectionNames().ToList<string>().Contains(collectionName))
                {
                    db.CreateCollection(collectionName);
                }
            }
        }
    }

}
