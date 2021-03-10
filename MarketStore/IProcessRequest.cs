using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
	interface IProcessRequest
	{
		void processRequest(double purchaseValue, ICard clientCard);
	}
}
