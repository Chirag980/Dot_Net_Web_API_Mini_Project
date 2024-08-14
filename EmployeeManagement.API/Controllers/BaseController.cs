using Employee_Management.BAL.UOW;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeManagement.API.Controllers
{
    
    public class BaseController : ApiController
    {
        //GET: Base
        protected static UnitOfWork UnitOfWork = new UnitOfWork();
        protected HttpResponseMessage SuccessResponse(object model)
        {
            var response = new SuccessResponse(model);
            return HttpResponse(HttpStatusCode.OK, response);
        }
        protected HttpResponseMessage HttpResponse(HttpStatusCode statusCode, IResponse response = null)
        {
            HttpResponseMessage responseMessage = Request.CreateResponse(statusCode, response);
            if (response == null && HttpStatusCode.InternalServerError == statusCode)
            {
                responseMessage = Request.CreateResponse();
            }
            return responseMessage;
        }
    }
    public interface IResponse { }
    public class APIError
    {
        public string code { get; set; }
        public string message { get; set; }
    }
    public class APIResponse
    {
        public APIResponse() { }
        public APIResponse(bool status, string code, string message)
        {
            this.status = status;
            this.error = new APIError() { code = code, message = message };
        }
        public bool status { get; set; }
        public APIError error { get; set; }
    }
    public class SuccessResponse : APIResponse, IResponse
    {
        public SuccessResponse(object result)
        {
            this.status = ResponseConstants.SUCCESS;
            this.data = result;
        }
        public object data { get; set; }
    }
    public class ResponseConstants
    {
        public static bool FAILURE = false;
        public static bool SUCCESS = true;
    }
}