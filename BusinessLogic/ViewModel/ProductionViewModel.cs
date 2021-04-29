using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BusinessLogic.ViewModel
{
    public class ProductionViewModel
    {
        public int? Id { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Вид")]
        public string Kind { get; set; }
        [DisplayName("Пол")]
        public string Gender { get; set; }
        [DisplayName("Размер")]
        public int Size { get; set; }
        [DisplayName("Цвет")]
        public string Color { get; set; }
        public virtual List<RequestViewModel> Requests { get; set; }
    }
}
