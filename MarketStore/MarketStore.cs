using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
	class MarketStore: IStore, IProcessRequest
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
}
