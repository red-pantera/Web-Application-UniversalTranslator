using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace UniversalTranslator
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Код, выполняемый при запуске приложения
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Session_Start(Object sender, EventArgs e)
        {
            //Створити новий объект класу TranslatorClass.
            TranslatorClass TransClass = new TranslatorClass();
            //Зберегти об’єкт в змінній стану Session.
            Session["TransClass"] = TransClass;
        }
    }
}