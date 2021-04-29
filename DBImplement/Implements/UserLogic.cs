using BusinessLogic.BindingModel;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBImplement.Implements
{
    public class UserLogic : IUserLogic
    {
        public List<UserViewModel> Read(UserBindingModel model)
        {
            using (var context = new Database())
            {
                return context.Users
                 .Where(rec => model == null
                   || (rec.Id == model.Id) || (model.FIO == rec.FIO) || (rec.Login == model.Login)
                        && (model.Password == null || rec.Password == model.Password))
               .Select(rec => new UserViewModel
               {
                   Id = rec.Id,
                   FIO = rec.FIO,
                   Login = rec.Login,
                   Password = rec.Password,
               })
                .ToList();
            }
        }
    }
}
