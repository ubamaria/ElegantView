using BusinessLogic.BindingModel;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModel;
using DBImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBImplement.Implements
{
    public class RequestLogic : IRequestLogic
    {
        public void CreateOrUpdate(RequestBindingModel model)
        {
            using (var context = new Database())
            {
                Request element = context.Requests.FirstOrDefault(rec =>rec.ProductionId == model.ProductionId && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть такая заявка");
                }
                if (model.Id.HasValue)
                {
                    element = context.Requests.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Request();
                    context.Requests.Add(element);
                }
                element.ProductionId = model.ProductionId == 0 ? element.ProductionId : model.ProductionId;
                element.ProductionName = model.ProductionName;
                element.Date = model.Date;
                element.Customer = model.Customer;
                element.Executor = model.Executor;
                element.Count = model.Count;
                context.SaveChanges();

            }
        }
        public void Delete(RequestBindingModel model)
        {
            using (var context = new Database())
            {
                Request element = context.Requests.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (element != null)
                {
                    context.Requests.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            
        }
        }
        public List<RequestViewModel> Read(RequestBindingModel model)
        {
            using (var context = new Database())
            {
                return context.Requests
                .Where(rec => model == null || (rec.Id == model.Id && model.Id.HasValue) || (model.DateFrom.HasValue && model.DateTo.HasValue && rec.Date >= model.DateFrom && rec.Date <= model.DateTo))
                .Select(rec => new RequestViewModel
                {
                    Id = rec.Id,
                    ProductionId = rec.ProductionId,
                    ProductionName =rec.ProductionName,
                    Date = rec.Date,
                    Customer = rec.Customer,
                    Executor = rec.Executor,
                    Count = rec.Count
                })
                .ToList();
            }
        }
    }
}
