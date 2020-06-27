/*
 * Created by SharpDevelop.
 * User: Zoltran32
 * Date: 27.06.2020
 * Time: 19:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
using System;
using System.Collections.Generic; 

namespace VendingMachine
{
	class Program
	{
		public static void Main(string[] args)
		{
			//TODO
			//Good + Price + Ammount + Id = array(?) of goods (structures are restricted?) [storage] [can be different]
			//Ammount of money + Order(one or several goods) = Customer
			//Mechanism of order result checking [can be different] 
			//Break of machine output (3% chance)
			//Break of card reader
			
			/*
			
			//Vending machine "initialization"
			//Storage
			string ItemName;
			int ItemPrice;
			int ItemAmmount;
			int ItemId;
			
			int MachineBallance; //Machine bank(?) account money + coins.
			int Ammount1;
			int Ammount2;
			int Ammount5;
			int Ammount10;
			Dictionary<int,int> CoinsInStorage = new Dictionary<int,int>();
			CoinsInStorage.Add(1, Ammount1);
			CoinsInStorage.Add(2, Ammount2);
			CoinsInStorage.Add(5, Ammount5);
			CoinsInStorage.Add(10, Ammount10);
			
			
			//Customer
			int Money;
			list<int> Order;
			*/
			
			Console.WriteLine("Good day, customer");
			Console.WriteLine("\n");
			bool UseMachine = true;
			int UserCommand = -1;
			while(UseMachine)
			{
				Console.WriteLine("There are several goods to buy");
				
				//foreach Item in ItemDatabase print
				//Console.WriteLine("Type {0} to buy {1}. Price is {2}. {3} of this good remain in storage", ItemId, ItemName, ItemPrice, Item Ammount);
				//So that user can choose command for the buyed good  
				//If there is no good of this type remain command for it should not be shown?
				
				Console.WriteLine("Type 0 to stop using machine");
				Console.WriteLine("Invalid commands are ignored.");
				Console.WriteLine("\n");
				
				while(int.TryParse(Console.ReadLine(), out UserCommand) == false)
				{
					Console.WriteLine("This command is not a number");
				}
				
				switch(UserCommand)
				{
					case 1:
						//User orders item with ID 1;
						//Proceed the buying logic
						break;
					case 0:
						UseMachine = false;
						Console.WriteLine("\n");
						Console.WriteLine("Thank you for using our vending machine");
						break;
					default:
						break;

				}
			}
			Console.WriteLine("\n");
			Console.Write("Press any key to exit application");
			Console.ReadKey(true);
		}
	}
}