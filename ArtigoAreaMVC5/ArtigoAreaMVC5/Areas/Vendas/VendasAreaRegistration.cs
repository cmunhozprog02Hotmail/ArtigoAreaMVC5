﻿using System.Web.Mvc;

namespace ArtigoAreaMVC5.Areas.Vendas
{
    public class VendasAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Vendas";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Vendas_default",
                "Vendas/{controller}/{action}/{id}",
                //new { action = "Index", id = UrlParameter.Optional }
                new {Controller = "Home", action = "Index", id = UrlParameter.Optional}
            );
        }
    }
}