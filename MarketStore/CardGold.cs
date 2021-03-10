using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
	class CardGold : Card
	{
		public CardGold(string ownerName, int previousMonthTurnover) : base(ownerName, previousMonthTurnover)
		{
			cardType = "gold";
			this.assignDiscount();
		}
	}
}
