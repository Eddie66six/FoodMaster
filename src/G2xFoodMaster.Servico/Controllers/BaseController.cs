using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

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
    }
}
