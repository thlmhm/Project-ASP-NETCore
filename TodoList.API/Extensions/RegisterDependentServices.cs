using Application.Extensions;
using Persistence.Extensions;

namespace TodoList.API.Extensions
{
    public static class RegisterDependentServices
    {
        public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddMemoryCache();
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            builder.Services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            builder.Services.AddAuthentication();
            builder.Services.AddAuthorization();    
            
            builder.AddPersistenceInfrastructure();
            builder.AddApplicationLayer();
            
            return builder;
        }
    }
}
