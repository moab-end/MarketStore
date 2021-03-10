using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
	
	class Program
	{

		static void Main(string[] args)
		{
			Console.WriteLine("Bronze:");

			Card myCard = new CardBronze("Nemanja Petrovic", 0);
			MarketStore myStore = new MarketStore();
			myStore.processRequest(150, myCard);
			myStore.showData();

			Console.WriteLine("Silver:");

			myCard = new CardSilver("Petar Petrovic", 600);
			myStore.processRequest(850, myCard);
			myStore.showData();

			Console.WriteLine("Gold:");

			myCard = new CardGold("Milan Petrovic", 1500);
			myStore.processRequest(1300, myCard);
			myStore.showData();

			//Console.WriteLine("Owner Name:" + myCard.OwnerName);
			//Console.WriteLine("Previous Month Turnover:" + myCard.PreviousMonthTurnover);
			//Console.WriteLine("Initial Discount Rate:" + myCard.InitialDiscountRate+"%");
			//Console.WriteLine("Card Type:" + myCard.CardType);
		}
	}
}
