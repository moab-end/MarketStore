using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
	class MarketStore : IStore, IProcessRequest
	{
		private double purchaseValue;
		private ICard clientCard;
		public MarketStore()
		{

		}
		public void processRequest(double purchaseValue, ICard clientCard)
		{
			this.purchaseValue = purchaseValue;
			this.clientCard = clientCard;
		}

		public double calculatePurchase()
		{
			return this.purchaseValue - this.discount();
		}

		public double discount()
		{
			return purchaseValue * clientCard.InitialDiscountRate / 100;
		}

		public void showData()
		{
			Console.WriteLine(" * Purchase value: " + this.purchaseValue);
			Console.WriteLine(" * Discount rate: " + clientCard.InitialDiscountRate + "%");
			Console.WriteLine(" * Discount: $" + this.discount());
			Console.WriteLine(" * Total: $" + this.calculatePurchase());
		}
	}
	interface IStore
	{

		void showData();
		double calculatePurchase();
		double discount();
	}
	interface IProcessRequest
	{
		void processRequest(double purchaseValue, ICard clientCard);
	}

	interface ICard
	{
		double InitialDiscountRate { get; }
	}
	class Card : ICard
	{
		private string ownerName;
		private int previousMonthTurnover;
		private double initialDiscountRate;
		private string cardType;

		public Card(string ownerName, int previousMonthTurnover, string cardType)
		{
			this.ownerName = ownerName;
			this.previousMonthTurnover = previousMonthTurnover;
			this.cardType = cardType;
			this.assignDiscount();


		}
		private void assignDiscount()
		{
			if (this.cardType == "bronze")
			{
				if (this.previousMonthTurnover < 100) this.initialDiscountRate = 0.0;

				else if (this.previousMonthTurnover > 100 && this.previousMonthTurnover < 300) this.initialDiscountRate = 2.0;

				else if (this.previousMonthTurnover > 300) this.initialDiscountRate = 3.5;

			}
			else if (this.cardType == "silver")
			{
				this.initialDiscountRate = 2.0;

				if (this.previousMonthTurnover > 300) this.initialDiscountRate = 3.5;

			}
			else if (this.cardType == "gold")
			{
				this.initialDiscountRate = 2.0;

				if (this.previousMonthTurnover > 100)
				{
					double sum = (double)previousMonthTurnover / 100.00;


					if (sum > 8.0)
						this.initialDiscountRate = this.initialDiscountRate + 8.0;
					else this.initialDiscountRate = this.initialDiscountRate + sum;


				}
			}

		}


		public string OwnerName
		{
			get { return this.ownerName; }

		}
		public int PreviousMonthTurnover
		{
			get { return this.previousMonthTurnover; }
		}
		public string CardType
		{
			get { return this.cardType; }
		}
		public double InitialDiscountRate
		{
			get { return this.initialDiscountRate; }
		}

	}

	class Program
	{

		static void Main(string[] args)
		{
			Console.WriteLine("Bronze:");

			Card myCard = new Card("Nemanja Petrovic", 0, "bronze");
			MarketStore myStore = new MarketStore();
			myStore.processRequest(150, myCard);
			myStore.showData();

			Console.WriteLine("Silver:");

			myCard = new Card("Petar Petrovic", 600, "silver");
			myStore.processRequest(850, myCard);
			myStore.showData();

			Console.WriteLine("Gold:");

			myCard = new Card("Milan Petrovic", 1500, "gold");
			myStore.processRequest(1300, myCard);
			myStore.showData();

			//Console.WriteLine("Owner Name:" + myCard.OwnerName);
			//Console.WriteLine("Previous Month Turnover:" + myCard.PreviousMonthTurnover);
			//Console.WriteLine("Initial Discount Rate:" + myCard.InitialDiscountRate+"%");
			//Console.WriteLine("Card Type:" + myCard.CardType);
		}
	}
}
