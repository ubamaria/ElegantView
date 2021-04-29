using BusinessLogic.BindingModel;
using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface IRequestLogic
    {
        List<RequestViewModel> Read(RequestBindingModel model);
        void CreateOrUpdate(RequestBindingModel model);
        void Delete(RequestBindingModel model);
    }
}
