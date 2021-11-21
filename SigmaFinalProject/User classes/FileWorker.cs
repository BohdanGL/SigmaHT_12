using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SigmaFinalProject
{
    class FileWorker
    {
        public delegate void PrintIncorrectDataInFile(string fileName, string wrongLine, string message);
        public delegate void ModifyInput(Storage storage, string wrongLine, string productClass);

        public event PrintIncorrectDataInFile Notify;
        public event ModifyInput CorrectData;
        public string Text { get; private set; }
        private string filePath;
        public FileWorker(string filePath)
        {
            this.filePath = filePath;

            using (StreamReader reader = new StreamReader(filePath))
            {
                Text = reader.ReadToEnd();
            }
        }
        public Storage GetProducts()
        {
            string[] products = Text.Replace("\r\n", "\n").Split('\n');

            Storage storage = new Storage();

            Product product;

            for (int i = 0; i < products.Length; i++)
            {
                string[] values = products[i].Split(' ');

                string name = values[1];

                if (!double.TryParse(values[2], out double price))
                {
                    Notify?.Invoke("LogStorage.txt", products[i], "Wrong price");
                    CorrectData?.Invoke(storage, products[i], values[0]);
                    continue;
                }

                if (!double.TryParse(values[3], out double weight))
                {
                    Notify?.Invoke("LogStorage.txt", products[i], "Wrong weight");
                    CorrectData?.Invoke(storage, products[i], values[0]);
                    continue;
                }

                if (!int.TryParse(values[4], out int expirationDate))
                {
                    Notify?.Invoke("LogStorage.txt", products[i], "Wrong expiration date");
                    CorrectData?.Invoke(storage, products[i], values[0]);
                    continue;
                }

                string[] dateTime = values[5].Split('.');

                if (!int.TryParse(dateTime[0], out int day))
                {
                    Notify?.Invoke("LogStorage.txt", products[i], "Wrong number of days");
                    CorrectData?.Invoke(storage, products[i], values[0]);
                    continue;
                }

                if (!int.TryParse(dateTime[1], out int month))
                {
                    Notify?.Invoke("LogStorage.txt", products[i], "Wrong number of months");
                    CorrectData?.Invoke(storage, products[i], values[0]);
                    continue;
                }

                if (!int.TryParse(dateTime[2], out int year))
                {
                    Notify?.Invoke("LogStorage.txt", products[i], "Wrong number of years");
                    CorrectData?.Invoke(storage, products[i], values[0]);
                    continue;
                }

                DateTime productionDate = new DateTime(year, month, day);

                MeatCategory meatCategory = MeatCategory.ExtraClass;
                KindOfMeat kindOfMeat = KindOfMeat.Chicken;

                if (products[i].Split(' ')[0] == "Meat:")
                {
                    switch (values[6])
                    {
                        case "ExtraClass": meatCategory = MeatCategory.ExtraClass; break;
                        case "FisrtCalss": meatCategory = MeatCategory.FisrtClass; break;
                        case "SecondClass": meatCategory = MeatCategory.SecondClass; break;
                        default:
                            Notify?.Invoke("LogStorage.txt", products[i], "Wrong meat category");
                            CorrectData?.Invoke(storage, products[i], values[0]);
                            continue;
                    }

                    switch (values[7])
                    {
                        case "Mutton": kindOfMeat = KindOfMeat.Mutton; break;
                        case "Veal": kindOfMeat = KindOfMeat.Veal; break;
                        case "Pork": kindOfMeat = KindOfMeat.Pork; break;
                        case "Chicken": kindOfMeat = KindOfMeat.Chicken; break;
                        default:
                            Notify?.Invoke("LogStorage.txt", products[i], "Wrong king of meat");
                            CorrectData?.Invoke(storage, products[i], values[0]);
                            continue;
                    }
                }

                switch (products[i].Split(' ')[0])
                {
                    case "Meat:":
                        product = new Meat(name, price, weight, expirationDate,
              productionDate, meatCategory, kindOfMeat);
                        break;
                    case "Dairy:":
                        product = new DairyProducts(name, price, weight, expirationDate,
             productionDate);
                        break;
                    default:
                        product = new Product(name, price, weight, expirationDate, productionDate);
                        break;
                }

                storage[i] = product;
            }

            return storage;
        }

        public void WriteProductsToFile(Storage storage)
        {
            StreamWriter streamWriter = new StreamWriter(filePath);

            for (int i = 0; i < storage.Products.Count; i++)
            {
                if(storage[i].GetType() == typeof(Product))
                {
                    streamWriter.Write("Ordinary: ");
                }
                if (storage[i].GetType() == typeof(Meat))
                {
                    streamWriter.Write("Meat: ");
                }
                if (storage[i].GetType() == typeof(DairyProducts))
                {
                    streamWriter.Write("Dairy: ");
                }

                streamWriter.Write($"{storage[i].Name} {storage[i].Price} {storage[i].Weight} ");
                streamWriter.Write($"{storage[i].ExpirationDate} {storage[i].ProductionDate.ToShortDateString()}");

                if (storage[i].GetType() == typeof(Meat))
                {
                    Meat meat = storage[i] as Meat;
                    streamWriter.Write($" {meat.MeatCategory} {meat.KindOfMeat}");
                }

                if (i < storage.Products.Count - 1)
                    streamWriter.WriteLine();
            }

            streamWriter.Close();
        }

        public static void WriteOrdersToFile(List<Order> orders, string filePath)
        {
            StreamWriter streamWriter = new StreamWriter(filePath);

            for (int i = 0; i < orders.Count; i++)
            {
                streamWriter.Write($"{orders[i].Username} {orders[i].TotalPrice} {orders[i].TotalWeight}");
                streamWriter.Write($" {orders[i].Address} {orders[i].OrderCreationTime.ToShortDateString()}\n");
            }

            streamWriter.Close();
        }
    }
}
