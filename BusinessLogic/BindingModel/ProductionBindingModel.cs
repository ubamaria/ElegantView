using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModel
{
    public class ProductionBindingModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Kind { get; set; }
        public string Gender { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }
        public virtual List<RequestBindingModel> Requests { get; set; }

    }
}
