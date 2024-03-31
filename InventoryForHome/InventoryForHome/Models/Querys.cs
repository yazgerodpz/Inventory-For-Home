using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InventoryForHome.Models
{
    public class Querys
    {
        public static async Task<List<Item>> ObtenerTablaItemAsync()
        {
            using (var db = new InventoryForHomeContext())
            {
                var Item = await db.Items.FromSql($"EXEC OptionMenu 2").ToListAsync();
                return Item;
            }
        }
    }
}
