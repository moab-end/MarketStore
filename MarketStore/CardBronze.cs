using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
	class CardBronze : Card
	{

		public CardBronze(string ownerName, int previousMonthTurnover) : base(ownerName, previousMonthTurnover)
		{
			cardType = "bronze";
			this.assignDiscount();
		}
	}
}
