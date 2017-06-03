using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Crafters.Web.Model
{
    public class CraftItems
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        [UIHint("Currency")]
        public decimal Price { get; set; }
        public int Rating { get; set; }
    }
}
