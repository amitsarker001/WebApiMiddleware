using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMiddleware.Data.Model
{
    public class Products
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string UnitPrice { get; set; }
        public string StockQty { get; set; }
    }
}
