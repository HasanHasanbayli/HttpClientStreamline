using System.Net;

namespace HttpClientStreamline;

public class HttpResponseException(HttpStatusCode httpStatusCode, string message) : Exception(message)
{
    public readonly HttpStatusCode HttpStatusCode = httpStatusCode;
}