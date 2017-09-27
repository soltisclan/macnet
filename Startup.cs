using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;

namespace macnet
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app){
            app.Run(context => {
                var httpConnectionFeature = context.Features.Get<IHttpConnectionFeature>();
                var localIpAddress = httpConnectionFeature?.LocalIpAddress;
                return context.Response.WriteAsync("Running on: " + localIpAddress.ToString());
            });
            
        }
    }
}