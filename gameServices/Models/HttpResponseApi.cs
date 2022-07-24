using System.Net;

namespace gameServices.Models
{
    public class HttpResponseApi
    {
        public HttpStatusCode Status { get; set; }
        public string Message { get; set; }
        public List<MyGame> resultList { get; set; }
        public List<MyGameById> resultId { get; set; }
        public int resultCount { get; set; }

    }
}
