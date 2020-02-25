using BrainWare.Data.Library;
using BrainWare.Data.Library.Interfaces;
using BrainWare.Data.Library.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using System.Web.Mvc;

namespace Web.App_Start
{
    //UniyConfig
    public static class IocConfig
    {
        public static void RegisterComponents()
        {
            // register all components with the container here            
            var container = new UnityContainer();
            container.RegisterType<IOrderService, OrderService>();
            
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL10.MSSQLSERVER2008\MSSQL\DATA\BRAINWARE.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
           
            var contextOptions = new DbContextOptionsBuilder()
                .UseSqlServer(connectionString).Options;

            container.RegisterType<DBContext>(new InjectionConstructor(contextOptions));
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

        }
    }
}