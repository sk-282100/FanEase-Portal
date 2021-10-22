using FanEase.Model.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FanEase.API.Helper
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ExceptionHandlerMiddleware(RequestDelegate next, ILogger<ExceptionHandlerMiddleware> logger)
        {
            _next = next; _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "", null);
                await ConvertException(context, ex);
            }
        }

        private Task ConvertException(HttpContext context, Exception exception)
        {
            HttpStatusCode httpStatusCode = HttpStatusCode.InternalServerError;

            context.Response.ContentType = "application/json";

            var result = string.Empty;
            
            switch (exception)
            {
                //case System.ComponentModel.DataAnnotations.ValidationException validationException:
                //    httpStatusCode = HttpStatusCode.BadRequest;
                //    result = GetErrorMessages(validationException.Message);
                //    break;
                //case BadRequestException badRequestException:
                //    httpStatusCode = HttpStatusCode.BadRequest;
                //    result = GetErrorMessage(badRequestException.Message);
                //    break;
                //case NotFoundException notFoundException:
                //    httpStatusCode = HttpStatusCode.NotFound;
                //    result = GetErrorMessage(notFoundException.Message);
                //    break;
                case ApplicationException appexception:
                    httpStatusCode = HttpStatusCode.BadRequest;
                    result = GetErrorMessage(appexception.Message);
                    break;
                case Exception ex:
                    httpStatusCode = HttpStatusCode.BadRequest;
                    result = GetErrorMessage(ex.Message);
                    break;
            }

            context.Response.StatusCode = (int)httpStatusCode;

            return context.Response.WriteAsync(result);
        }

        private string GetErrorMessages(Exception innerException)
        {
            throw new NotImplementedException();
        }

        private string GetErrorMessage(string message)
        {
            var response = new Response<string>();
            response.Succeeded = false;
            response.Errors = new List<string>();
            response.Errors.Add(message);
            return JsonConvert.SerializeObject(response);

        }

        private string GetErrorMessages(List<string> messages)
        {
            var response = new Response<string>();
            response.Succeeded = false;
            response.Errors = new List<string>();
            response.Errors = messages;
            return JsonConvert.SerializeObject(response);

        }
    }
}
