using BusinessLogic.BindingModel;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModel;
using DBImplement.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBImplement.Implements
{
    public class ReportLogic
    {
        private readonly IProductionLogic logicP;
        private readonly IRequestLogic logicR;
        public ReportLogic(IProductionLogic logicP, IRequestLogic logicR)
        {
            this.logicP = logicP;
            this.logicR = logicR;
        }
        public List<ReportViewModel> GetReport(ReportBindingModel model)
        {
            var requests = logicR.Read(new RequestBindingModel
            {
                DateFrom = model.DateFrom,
                DateTo = model.DateTo
            })
            .ToList();
            var list = new List<ReportViewModel>();
            foreach (var r in requests)
            {
                var pr = logicP.Read(new ProductionBindingModel
                {
                    Id = r.ProductionId
                  
                }).FirstOrDefault();
                    var record = new ReportViewModel
                    {
                        Date = r.Date,
                        ProductionName = pr.Name,
                        Count = r.Count,
                        Customer = r.Customer,
                        Executor = r.Executor,
                    };
                    list.Add(record);
                }         
            return list;
        }
        public List<RequestViewModel> GetRequests(ReportBindingModel model)
        {
            var list = logicR.Read(new RequestBindingModel
            {
                DateFrom =model.DateFrom,
                DateTo = model.DateTo
            })
            .ToList();
            return list;
        }

        [Obsolete]
        public void SaveReportToPdfFile(ReportBindingModel model)
        {
            SaveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Отчет по отгрузке продукции",
                Reports = GetReport(model)
            });
        }
    }
}
