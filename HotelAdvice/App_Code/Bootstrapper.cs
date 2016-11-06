﻿using HotelAdvice.Areas.Account.Controllers;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelAdvice.App_Code
{
    public class Bootstrapper
    {
         public static IUnityContainer Initialise()  
        {  
            var container = BuildUnityContainer();  
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));  
            return container;  
        }  
        private static IUnityContainer BuildUnityContainer()  
        {  
            var container = new UnityContainer();  
  
            // register all your components with the container here  
            //This is the important line to edit  
            container.RegisterType<IDataRepository, DAL>();   
  
            RegisterTypes(container);  
            return container;  
        }  
        public static void RegisterTypes(IUnityContainer container)  
        {
            container.RegisterType<AccountController>(new InjectionConstructor());
        }  
    }  
    
}