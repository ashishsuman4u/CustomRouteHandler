using System.Web;
using System.Web.Routing;

namespace CustomRouteHandler.RouteHandler
{
    public class CustomRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new CustomHandler(requestContext);
        }
    }
}