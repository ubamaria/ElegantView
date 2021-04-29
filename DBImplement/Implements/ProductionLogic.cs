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
    public class ProductionLogic : IProductionLogic
    {
        public void CreateOrUpdate(ProductionBindingModel model)
        {
            using (var context = new Database())
            {
                Production element = context.Productions.FirstOrDefault(rec => rec.Name == model.Name && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть продукция с таким названием");
                }
                if (model.Id.HasValue)
                {
                    element = context.Productions.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Production();
                    context.Productions.Add(element);
                }
                element.Name = model.Name;
                element.Kind = model.Kind;
                element.Gender = model.Gender;
                element.Size = model.Size;
                element.Color = model.Color;
                context.SaveChanges();
            }
        }
        public void Delete(ProductionBindingModel model)
        {
            using (var context = new Database())
            {
                Production element = context.Productions.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Productions.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        public List<ProductionViewModel> Read(ProductionBindingModel model)
        {
            using (var context = new Database())
            {
                return context.Productions
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new ProductionViewModel
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Kind = rec.Kind,
                    Gender = rec.Gender,
                    Color = rec.Color,
                    Size = rec.Size
                })
                .ToList();
            }
        }


    }
}
