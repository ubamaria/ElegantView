using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModel
{
    public class RequestBindingModel
    {
        public int? Id { get; set; }
        public int ProductionId { get; set; }
        public string ProductionName { get; set; }
        public DateTime Date { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Customer { get; set; }
        public string Executor { get; set; }
        public int Count { get; set; }
        public virtual List<ProductionBindingModel> Productions { get; set; }
    }
}
