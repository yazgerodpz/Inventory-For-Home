using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace InventoryForHome.Models
{
    public class Querys
    {
        public static async Task<List<StoredProcedure1>> ObtenerTablaItemAsync()
        {
            using (var db = new InventoryForHomeContext())
            {
                var StoredProcedure1 = await db.StoredProcedure1s.FromSql($"EXEC OptionMenu 2").ToListAsync();
                return StoredProcedure1;
            }
        }
    }
}
