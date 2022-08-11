using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Services.EventHandlers.Exceptions
{
    internal class ProductInStockUpdateStockCommandException:Exception
    {
        public ProductInStockUpdateStockCommandException(string message): base(message){ }
    }
}
