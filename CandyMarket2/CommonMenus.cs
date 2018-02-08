using System;
using cki = System.ConsoleKeyInfo;

namespace CandyMarket2
{
    class CommonMenus
    {
        public static cki UserLandingMenu(DatabaseContext db)
        {
            View userLandingMenu = new View()
                    .AddMenuOption("Did you just get some new candy? Add it here.")
                    .AddMenuOption("Do you want to eat some candy? Take it here.")
                    .AddMenuOption("Do you want to throw away the bad candy? Dump it here.")
                    .AddMenuOption("Feeling generous? Give away some candy here.")
                    .AddMenuOption("Looking to make a trade? Make an offer here.")
                    .AddMenuText("Press 0 to exit.")
                    .AddMenuText(db.ShowTaffyCount())
                    .AddMenuText(db.ShowCandyCoatedCount())
                    .AddMenuText(db.ShowChocolateCount())
                    .AddMenuText(db.ShowCompressedCount());


            Console.Write(userLandingMenu.GetFullMenu());

            cki userOption = Console.ReadKey();
            return userOption;
        }

        public static CandyType GetTheCandyType(DatabaseContext db)
        {
            var candyTypes = db.GetCandyTypes();

            var newCandyMenu = new View()
                .AddMenuText("What type of candy did you get?")
                .AddMenuOptions(candyTypes);

            Console.Write(newCandyMenu.GetFullMenu());

            CandyType selectedCandyType = db.ConvertOptionToType(Console.ReadKey().KeyChar);
            return selectedCandyType;
        }

        public static int GetTheAmount(string action)
        {
            var amountMenu = new View()
                .AddMenuText($"How many are you {action}?");

            Console.Write(amountMenu.GetFullMenu());

            int selectedCandyAmount = int.Parse(Console.ReadLine());
            return selectedCandyAmount;
        }

        public static string GetTheBrand()
        {
            var brandMenu = new View()
                .AddMenuText("What company makes this candy?")
                .AddMenuText("Press [Enter] to continue.");

            Console.Write(brandMenu.GetFullMenu());
            string brand = Console.ReadLine();
            return brand;
        }

        public static string GetTheSize()
        {
            var sizeMenu = new View()
                .AddMenuText("What size candy is it?")
                .AddMenuText("For example: King sized, bite sized, regular.")
                .AddMenuText("Press [Enter] to continue.");

            Console.Write(sizeMenu.GetFullMenu());
            string size = Console.ReadLine();
            return size;
        }

        public static string GetTheCandyName()
        {
            var sizeMenu = new View()
                .AddMenuText("What's the name of the candy?")
                .AddMenuText("Press [Enter] to continue.");

            Console.Write(sizeMenu.GetFullMenu());
            string candyName = Console.ReadLine();
            return candyName;
        }
    }
}
