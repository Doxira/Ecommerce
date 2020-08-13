using System.Collections.Generic;

namespace Eccomerce.Models
{
    public class NewOrder
    {
        public NewOrder()
        {
            ProductsIds = new List<int>();
        }
        public Orders Order { get; set; }

        public List<int> ProductsIds { get; set; }
    }
}
