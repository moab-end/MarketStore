using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
	abstract class Card : ICard
	{
		protected string ownerName;
		protected int previousMonthTurnover;
		protected double initialDiscountRate;
		protected string cardType;

		public Card(string ownerName, int previousMonthTurnover)
		{
			this.ownerName = ownerName;
			this.previousMonthTurnover = previousMonthTurnover;




		}
		protected void assignDiscount()
		{
			if (this.cardType == "bronze")
			{
				if (this.previousMonthTurnover < 100) this.initialDiscountRate = 0.0;

				else if (this.previousMonthTurnover >= 100 && this.previousMonthTurnover <= 300) this.initialDiscountRate = 2.0;

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
}
