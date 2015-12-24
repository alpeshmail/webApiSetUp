using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace DashboardTestApi.App_Start
{
    //public class GlobalExceptionHandler : ExceptionHandler
    //{
    //    private static bool AllErrorInd
    //    {
    //        get
    //        {
    //            if (ConfigurationManager.AppSettings["allErrorsInd"] == null)
    //                return false;
    //            return Convert.ToBoolean(ConfigurationManager.AppSettings["allErrorsInd"]);
    //        }
    //    }

    //    public override void Handle(ExceptionHandlerContext context)
    //    {
    //        context.Result = new ErrorResponse(context.Exception,context.Request);
    //    }

    //    public override bool ShouldHandle(ExceptionHandlerContext context)
    //    {
    //        return true;
    //    }

    //    public class ErrorResponse : IHttpActionResult
    //    {
    //        public ErrorResponse(Exception exception, HttpRequestMessage request)
    //        {
    //            if (request == null)
    //            {
    //                throw new ArgumentNullException("request");
    //            }
    //            Request = request;
    //            Exception = exception;
    //        }
    //        public HttpRequestMessage Request { get; private set; }
    //        public Exception Exception { get; private set; }
    //        public object HttpStatusCode { get; private set; }

    //        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
    //        {
    //            return Task.FromResult(Execute());
    //        }
    //        private HttpResponseMessage Execute()
    //        {
    //            HttpStatusCode errorCode = HttpStatusCode.InternalServerError;
    //            var payload = new TESTError
    //            {
    //                ErrorMessage = "Unexpected error occurred, please notify your Tech Support Team",
    //                ErrorDateTime = DateTime.UtcNow
    //            };

    //            if (Exception is DbEntityValidationException)
    //            {
    //                var dbEntityValidationException = Exception as DbEntityValidationException;
    //                payload.ErrorMessage = string.IsNullOrEmpty(dbEntityValidationException.Message) ?
    //                            payload.ErrorMessage : dbEntityValidationException.Message;

    //            };
    //            if (Exception is TESTException)
    //            {
    //                var TESTException = Exception as TESTException;
    //                if (TESTException.ErrorId == ErrorId.ValidationError || AllErrorInd)
    //                {
    //                    payload.ErrorMessage = string.IsNullOrEmpty(TESTException.ErrorMessage) ?
    //                        payload.ErrorMessage : TESTException.ErrorMessage;
    //                }
    //            }

    //            return Request.CreateResponse(errorCode, payload, new MediaTypeHeaderValue("application/json"));
    //        }
    //    }
    //}
}