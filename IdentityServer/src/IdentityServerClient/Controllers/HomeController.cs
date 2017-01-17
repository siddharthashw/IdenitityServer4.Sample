using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using IdentityModel.Client;

namespace IdentityServerClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Authorize]
        public async Task<IActionResult> Contact()
        {
            var doc = await DiscoveryClient.GetAsync("http://localhost:58857/");
            var accessToken = await HttpContext.Authentication.GetTokenAsync("access_token");
            var oauthServerDetails = await HttpContext.Authentication.GetAuthenticateInfoAsync("oidc");
            var introspectionClient = new IntrospectionClient(doc.IntrospectionEndpoint, "mvc", "superSecretPassword");
            var respons = await introspectionClient.SendAsync(new IntrospectionRequest { Token = accessToken });
            var isActice = respons.IsActive;
            var claims = respons.Claims;
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
