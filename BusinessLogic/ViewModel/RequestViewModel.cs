using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BusinessLogic.ViewModel
{
    public class RequestViewModel
    {
        public int? Id { get; set; }
        [DisplayName("Продукция")]
        public int ProductionId { get; set; }
        [DisplayName("Продукция")]
        public string ProductionName { get; set; }
        [DisplayName("Дата")]
        public DateTime Date { get; set; }
        [DisplayName("Заказчик")]
        public string Customer { get; set; }
        [DisplayName("Исполнитель")]
        public string Executor { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }
       public virtual List<ProductionViewModel> Productions { get; set; }

    }
}
