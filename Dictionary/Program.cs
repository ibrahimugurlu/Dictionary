using System;
using System.Collections.Generic;
namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Colleciton.Generic;

            Dictionary<int, string> Users = new Dictionary<int, string> { };

            Users.Add(1, "Kıvanç Tatlıtuğ");                         // ilk yazdığımız int değer 'key' index gibi düşün
            Users.Add(2, "Beren Saat");
            Users.Add(3, "Matmazel ");
            Users.Add(4, "Baykuş Beşir");

            // dizinin elemanlarına erişim
            Console.WriteLine(" ************ elemanlara erişim ***********");
            Console.WriteLine(Users[1]);
            foreach (var item in Users)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine(" ************ Count ***********");
            Console.WriteLine(Users.Count);

            //Contains
            Console.WriteLine(" ************ Contains ***********");
            Console.WriteLine(Users.ContainsKey(2));
            Console.WriteLine(Users.ContainsValue("Beren "));

            //Remove
            Console.WriteLine(" ************ Remove ***********");
            Users.Remove(2);

            foreach (var item in Users)
            {
                Console.WriteLine(item.Value);   // sadece value lere erişiliebilir

            }
           
            //Keys
            Console.WriteLine(" ************ Keys  ***********");

            foreach (var item in Users.Keys)
            {
                Console.WriteLine(item);
            }

            //Value
            Console.WriteLine(" ************ Values  ***********");

            

            foreach (var item in Users.Values)
            {
                Console.WriteLine(item);
            }




            Console.ReadKey();
        }
    }
}
