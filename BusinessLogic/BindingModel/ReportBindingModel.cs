using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModel
{
    public class ReportBindingModel
    {
        public DateTime Date { get; set; }
        public string FileName { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
