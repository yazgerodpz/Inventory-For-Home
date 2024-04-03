using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryForHome.Models
{
    public class StoredProcedure1
    {
        public int IdItem { get; set; }

        public string ItemName { get; set; } = null!;

        public int Stock { get; set; }

        public string Type_Prioritary { get; set; } = null!;

        public string Type_Stock { get; set; } = null!;

        public DateTime PurchesDate { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}
