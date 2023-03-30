using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem
{
    public class Menu
    {
        // + Title : string
        public string Title;

        // MenuItem[] array called MenuItems that holds MenuTitles
        private MenuItem[] menuItems;

        // Counts the amount of items passed to the array
        private int itemCount = 0;

        // Constructor for assigning af title for a menu and menuItem
        public Menu(string title) {
            this.menuItems = new MenuItem[10];
            this.Title = title;
        }

        // + AddMenuItem(menuTitle, string)
        public void AddMenuItem(string menuTitle)
        {
            MenuItem mi = new MenuItem(menuTitle); // Sygt smart 
            this.menuItems[itemCount] = mi;
            this.itemCount++;

        }


        public void Show()
        {
            // Show s = new Show();
            Console.WriteLine(this.Title);

            // Looping through MenuItems[] array in the length of ItemCount
            for (int i = 0; i < this.itemCount; i++) {
                Console.WriteLine(menuItems[i].Title);
            }

            Console.WriteLine("\n(Tryk på menupunkt eller 0 for at afslutte...)");

        }

            public void SelectMenuItem()
            {
            // key sættes til true, så programmet udfører aktionen med det samme
            var key = Console.ReadKey(true);

            // Bruger variablen key med .Key metoden, som er en indbygget metode
            switch (key.Key) {
                case ConsoleKey.D1: // Read key 1 from the keyboard
                    Console.WriteLine("Du valgte menupunkt 1: Gør dit");
                    Console.ReadLine();
                    Console.Clear();
                    Show();
                    SelectMenuItem();
                    break;
                case ConsoleKey.D2: // Read key 2 from the keyboard
                    Console.WriteLine("Du valgte menupunkt 2: Gør dat");
                    Console.ReadLine();
                    Console.Clear();
                    Show();
                    SelectMenuItem();
                    break;
                case ConsoleKey.D3: // Read key 3 from the keyboard
                    Console.WriteLine("Du valgte menupunkt 3: Gør noget");
                    Console.ReadLine();
                    Console.Clear();
                    Show();
                    SelectMenuItem();
                    break;
                case ConsoleKey.D4: // Read key 4 from the keyboard
                    Console.WriteLine("Du valgte menupunkt 4: Svaret er 42");
                    Console.ReadLine();
                    Console.Clear();
                    Show();
                    SelectMenuItem();
                    break;
                case ConsoleKey.D0: // Read key 0 from the keyboard - closes the console.
                    Console.WriteLine("Du valgt at lukke menuen. Tryk på en task for at lukke...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Du valgte et ugyldigt menupunkt...\nVælg menupunkt 1, 2, 3, 4 eller tryk 0 for at afslutte:");
                    Console.ReadLine();
                    Console.Clear();
                    Show();
                    SelectMenuItem();
                    break;


            }

        }



    }
}
