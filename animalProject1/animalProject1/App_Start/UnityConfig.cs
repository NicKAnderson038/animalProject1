//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;


//using System.Web.Mvc;
//using Microsoft.Practices.Unity;
//using Unity.Mvc5;
//using System.Web.Http;
//using animalProject1.Services.Interfaces;
//using animalProject1.Services;
//using animalProject1.Models;
//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
//using Microsoft.Owin.Security;
//using animalProject1;

//namespace animalProject1.App_Start
//{
//    public class UnityConfig
//    {

//        private static IUnityContainer container;


//        static UnityConfig()
//        {
//            container = new UnityContainer();
//        }

//        public static IUnityContainer GetConfiguredContainer()
//        {
//            return container;
//        }

//        public static void RegisterComponents(HttpConfiguration config)
//        {

//            // register all your components with the container here
//            // it is NOT necessary to register your controllers

//            // e.g. container.RegisterType<ITestService, TestService>();
//            container.RegisterType<IRegistriesService, RegisterService>();
            
//            // Do not touch the code below here:
//            container.RegisterType<ApplicationDbContext>();
//            container.RegisterType<ApplicationSignInManager>();
//            container.RegisterType<ApplicationUserManager>();
//            container.RegisterType<IdentityDbContext<ApplicationUser>, ApplicationDbContext>(
//                new ContainerControlledLifetimeManager());
//            container.RegisterType<IMaintenanceCallsService, MaintenanceCallsService>();  /// Drop in this each time you start
//            container.RegisterType<IdentityDbContext<ApplicationUser>, ApplicationDbContext>(new ContainerControlledLifetimeManager());
//            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(
//                new InjectionConstructor(typeof(ApplicationDbContext)));
//            container.RegisterType<IAuthenticationManager>(
//                new InjectionFactory(c => HttpContext.Current.GetOwinContext().Authentication));

//            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

//            //  this line is needed so that the resolver can be used by api controllers 
//            config.DependencyResolver = new Sabio.Web.Core.Injection.UnityResolver(container);

//        }

//    }
//}