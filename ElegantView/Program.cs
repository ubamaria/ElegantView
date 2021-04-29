using BusinessLogic.Interfaces;
using DBImplement.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace ElegantView
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<AuthorizationForm>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IUserLogic, UserLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IProductionLogic, ProductionLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IRequestLogic, RequestLogic>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
