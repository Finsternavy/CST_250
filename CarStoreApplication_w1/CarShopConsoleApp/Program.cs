using CarClassLibrary;
using System;

namespace CarShopConsoleApp
{
    class Program
    {
        static Store CarStore = new Store();
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Welcome to the car store.  First you must create some cars and put them into the store inventory.  Then you may add cars to the cart.  Finally, you may checkout, which will calculate your total bill.");
            int action = chooseAction();

            while (action != 0)
            {
                switch (action)
                {
                    case 1:
                        Console.Out.WriteLine("You chose to add a new car to the store:");
                        string carMake = "";
                        string carModel = "";
                        int carYear = 0;
                        decimal carPrice = 0;
                        string carColor = "";
                        

                        Console.Out.Write("What is the car make?  Ford, GM, Toyota etc ");
                        carMake = Console.ReadLine();

                        Console.Out.Write("What is the car model? Corvette, Focus, Ranger etc ");
                        carModel = Console.ReadLine();

                        Console.Out.Write("What year was this car manufactured? ");
                        // If the user entered data is parsable to an int assign the parsed value to carYear
                        if(int.TryParse(Console.ReadLine(), out carYear))
                        {

                        }
                        else
                        {
                            // If user data not parsable to int, let the user know and exit the switch statement
                            Console.Out.WriteLine("Invalid entry! Add a car has been cancelled.");
                            break;
                        }

                        Console.Out.Write("What is the car price? Only numbers please ");
                        // If user provided data is parsable to decimal assign value to carPrice
                        if (decimal.TryParse(Console.ReadLine(), out carPrice))
                        {

                        }
                        else
                        {
                            // If user provided data is not parsable, let the user know and exit the switch statement. 
                            Console.Out.WriteLine("Invalid entry! Add a car has been cancelled.");
                            break;
                        }

                        Console.Out.Write("What color is this car? ");
                        carColor = Console.ReadLine();

                        Car newCar = new Car(carMake, carModel, carYear, carPrice, carColor);
                        CarStore.CarList.Add(newCar);
                        printStoreInventory(CarStore);
                        break;

                    case 2:
                        // if there are cars available, otherwise, don't waste the users time. 
                        if (CarStore.CarList.Count > 0)
                        {
                            printStoreInventory(CarStore);

                            int choice = 0;

                            Console.Out.Write("Which car would you like to add to the cart? (number) ");

                            // If user provided data is parsable to int, assign value to choice and ensure it is not out of range for available options
                            if (int.TryParse(Console.ReadLine(), out choice) && choice < CarStore.CarList.Count)
                            {
                                CarStore.ShoppingList.Add(CarStore.CarList[choice]);

                                printShoppingCart(CarStore);

                                break;
                            }
                            // If user data is not parsable to int, let the user know and exit switch statement.
                            Console.Out.WriteLine("Invalid entry! You have been returned to the previous menu.");

                            break;
                        }

                        // If there are no cars available, let the user know.
                        Console.Out.WriteLine("There are no cars available. Try adding cars and try again.");
                        break;

                    case 3:
                        printShoppingCart(CarStore);
                        Console.Out.WriteLine("Your total cost is ${0}", CarStore.checkout());

                        break;

                    default:
                        break;
                }
                action = chooseAction();
            }
        }

        static public void printStoreInventory(Store carStore)
        {
            Console.Out.WriteLine("These are the cars in the store inventory: ");
            int i = 0;

            foreach(Car c in carStore.CarList)
            {
                Console.Out.WriteLine(String.Format("Car # = {0} {1}", i, c.Display));
                i++;
            }
        }

        static public void printShoppingCart(Store carStore)
        {
            Console.Out.WriteLine("These are the cars in your shopping cart: ");
            int i = 0;

            foreach (Car c in carStore.ShoppingList)
            {
                Console.Out.WriteLine(String.Format("Car # = {0} {1}", i, c.Display));
                i++;
            }
        }
        static public int chooseAction()
        {
            var choice = 0;
            Console.Out.Write("Choose an action (0) quit  (1) add a car  (2) add item to cart  (3) checkout");

            // If the user provided data is parsable to int, assign the choice and ensure it is in scope of available options
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 0 && choice < 4)
            {
                return choice;
            }

            // If user provided data is not parsable or is out of scope, start again. 
            return chooseAction();
        }
    }
}
