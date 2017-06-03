using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crafters.Web.Model
{
    public class MenuItemModel
    {
        public int Id { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public string MenuItemText { get; set; }
        public string Title { get; set; }
        public int ParentId { get; set; }
    }
}
