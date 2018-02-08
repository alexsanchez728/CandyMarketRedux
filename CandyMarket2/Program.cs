using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cki = System.ConsoleKeyInfo;

namespace CandyMarket2
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = SetupNewApp();
            var me = new User("Alex", db);
            var otherMe = new User("Flex Sanchez", db);

            var run = true;
            while (run)
            {
                cki userInput = CommonMenus.UserLandingMenu(db);

                switch (userInput.KeyChar)
                {
                    case '0':
                        run = false;
                        break;
                    case '1':
                        //todo: get the user input for:
                        /** CandyType CandyType
                         * HowMany int
                         * CandyName string
                         * CandyBrand string
                         * CandySize bool
                         */


                        //todo: User input saved to a new Candy
                        /** Add that candy to the user's candy bag
                         * display user's candy count
                         **/
                        break;
                    case '2':
                        /** Eat Candy
                         * 
                         * user chooses what type of candy
                         * show the user the candies that match that type
                         * get the users choice from that list
                         * 
                         * remove a HowMany based on what candy they choose and how many they entered
                         * Give the user feedback that they ate the candy?
                         **/
                        break;
                    case '3':
                        /** Throw away Candy
                         * 
                         * user chooses what type of candy
                         * show the user the candies that match that type
                         * get the user's choice from that list
                         * 
                         * remove a HowMany based on what candy they choose and how many they entered
                         * Give the user feedback that they just wasted a number of candies?
                         **/
                        break;
                    case '4':
                        /** Give away Candy
                         * 
                         * user chooses what type of candy
                         * show the user the candies that match that type
                         * get the user's choice from that list
                         * 
                         * Show the user the other users in the DB
                         * remove a HowMany based on what candy they choose and how many they entered
                         * add a HowMany to the user this user selected
                         * Give the user feedback that they gave __ a number of candies?
                         **/
                        break;
                    case '5':
                        /** Put candy up for trade
                         * 
                         * See the 'common' table,
                         * show all candies on the table and what people want in return as options
                         * 
                         * Make a trade:
                         * get user's selected trade,
                         * remove a HowMany of candy based on what the trader wants
                         * add new Candy, a copy of what the trader offered to user
                         * remove candy from trader
                         * 
                         * Add to table:
                         * 
                         * user chooses what type of candy
                         * show the user the candies that match that type
                         * get the user's choice from that list
                         * 
                         * get what the user wants to trade for
                         * remove a HowMany based on what candy they choose and how many they entered
                         * add a HowMany to the 'common' user, the table where trading happens essentially
                         * Give the user feedback that they gave __ a number of candies?
                         **/
                        break;
                }
            }
        }

        static DatabaseContext SetupNewApp()
        {
            Console.Title = "Cross Confectioneries Incorporated";

            var db = new DatabaseContext();

            Console.SetWindowSize(60, 40);
            Console.SetBufferSize(60, 40);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            return db;
        }
    }
}
