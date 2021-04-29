using BusinessLogic.BindingModel;
using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface IProductionLogic
    {
        List<ProductionViewModel> Read(ProductionBindingModel model);
        void CreateOrUpdate(ProductionBindingModel model);
        void Delete(ProductionBindingModel model);
    }
}
