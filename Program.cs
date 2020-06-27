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
	
	public struct Item 
	{
		public int ItemId;
		public int ItemPrice;
		public int ItemAmmount;
		public string ItemName;
	}
	
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
			
			Console.WriteLine("Type ammount of goods in vending machine");
			int AmmountTypesOfGoods = int.Parse(Console.ReadLine());
			
			List<Item> Menu = new List<Item>();
			Item placeholder;
			placeholder.ItemId = 0;
			placeholder.ItemPrice = 0;
			placeholder.ItemAmmount = 0;
			placeholder.ItemName = " ";
			Menu.Add(placeholder);
			
			for(int i = 1; i <= AmmountTypesOfGoods; i++)
			{
				VendingMachine.Item item;
				item.ItemId = i + 1;
				Console.WriteLine("		Type price of item");
				item.ItemPrice = int.Parse(Console.ReadLine());
				Console.WriteLine("		Type ammount of item");
				item.ItemAmmount = int.Parse(Console.ReadLine());
				Console.WriteLine("		Type name of item");
				item.ItemName = Console.ReadLine();
				Menu.Add(item);
			}
			
			
			/*
			
			//Vending machine "initialization"
			
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
				
				for(int i = 1; i <= AmmountTypesOfGoods; i++)
				{
					if(Menu[i].ItemAmmount > 0)
					{
						Console.WriteLine("Type {0} to buy {1}. Price is {2}. {3} of this good remain in storage", i, Menu[i].ItemName, Menu[i].ItemPrice, Menu[i].ItemAmmount);	
				    }
				}
						
				Console.WriteLine("Type 0 to stop using machine");
				Console.WriteLine("Invalid commands are ignored.");
				Console.WriteLine("\n");
				
				while(int.TryParse(Console.ReadLine(), out UserCommand) == false)
				{
					Console.WriteLine("This command is not a number");
				}
				
				if((UserCommand > 0) && (UserCommand <= AmmountTypesOfGoods)) //FIXME item with ammount 0 can be bought
				{
					Console.WriteLine("You bought {0}. Thank you for your purchase.", Menu[UserCommand].ItemName);
				}
				else if(UserCommand == 0)
				{
					Console.WriteLine("Thank you for using our vending machine");
					UseMachine = false;
				}		
			}
			Console.WriteLine("\n");
			Console.Write("Press any key to exit application");
			Console.ReadKey(true);
		}
	}
}