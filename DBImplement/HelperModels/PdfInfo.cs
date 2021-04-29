using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBImplement.HelperModels
{
    class PdfInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ReportViewModel> Reports { get; set; }
    }
}
