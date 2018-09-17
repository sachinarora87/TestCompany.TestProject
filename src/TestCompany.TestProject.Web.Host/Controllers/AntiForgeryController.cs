using Microsoft.AspNetCore.Antiforgery;
using TestCompany.TestProject.Controllers;

namespace TestCompany.TestProject.Web.Host.Controllers
{
    public class AntiForgeryController : TestProjectControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
