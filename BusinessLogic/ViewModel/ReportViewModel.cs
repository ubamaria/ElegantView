using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BusinessLogic.ViewModel
{
    public class ReportViewModel
    {
        [DisplayName("Дата")]
        public DateTime Date { get; set; }
        [DisplayName("Продукция")]

        public string ProductionName { get; set; }
        [DisplayName("Количество")]

        public int Count { get; set; }
        [DisplayName("Заказчик")]

        public string Customer { get; set; }
        [DisplayName("Исполнитель")]

        public string Executor { get; set; }
    }
}
