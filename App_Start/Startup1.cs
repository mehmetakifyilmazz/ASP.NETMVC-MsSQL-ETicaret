using System;
using System.Security.RightsManagement;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(Mwear.MvcWebUI.Startup1))]

namespace Mwear.MvcWebUI
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            // Uygulamanızı nasıl yapılandıracağınız hakkında daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=316888 adresini ziyaret edin
           
            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {

                AuthenticationType="ApplicationCookie",
                LoginPath= new PathString("/Account/Login")
            });
        }
    }
}
