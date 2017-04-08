using System;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin.Security;

namespace G2xFoodMaster.Servico.Controllers
{
    public class BaseController : ApiController
    {
        private HttpResponseMessage _responseMessage;
        protected BaseController()
        {
            _responseMessage = new HttpResponseMessage();
        }

        protected Task<HttpResponseMessage> CreateResponse(HttpStatusCode code, object result)
        {
            //_responseMessage = _notifications.HasNotifications()
            //    ? Request.CreateResponse(HttpStatusCode.BadRequest, new { errors = _notifications.Notify() })
            //    : Request.CreateResponse(code, result);

            return Task.FromResult(Request.CreateResponse(code, result));
        }

        protected static AuthenticationTicket ConfigureAuthenticationTicket(ClaimsIdentity identity)
        {
            var ticket = new AuthenticationTicket(identity, new AuthenticationProperties());
            var currentUtc = DateTime.UtcNow;
            ticket.Properties.AllowRefresh = true;
            ticket.Properties.IssuedUtc = currentUtc;
            ticket.Properties.ExpiresUtc = currentUtc.AddDays(1);
            return ticket;
        }
    }
}
