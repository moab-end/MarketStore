using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
	class CardSilver : Card
	{
		public CardSilver(string ownerName, int previousMonthTurnover) : base(ownerName, previousMonthTurnover)
		{
			cardType = "silver";
			this.assignDiscount();
		}
	}
}
