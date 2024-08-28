namespace MVC_Assignments;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Services.AddControllersWithViews();
        
        
        
        var app = builder.Build();
        
        app.UseRouting();

        app.UseStaticFiles();
        
        // app.Use(async (context, next) =>
        // {
        //     Endpoint endpoint = context.GetEndpoint();
        //     if (endpoint != null)
        //     {
        //         await context.Response.WriteAsync("Your Requested Page Not Found");
        //     }
        //     await next();
        // });
        
        // app.UseEndpoints(endpoint=>{
        //     endpoint.MapGet("/home", async context =>
        //     {
        //         await context.Response.WriteAsync("Hello World!");
        //     });
        //     endpoint.MapGet("/Category", async context =>
        //     {
        //         await context.Response.WriteAsync("Hello World!");
        //     });
        //     endpoint.MapGet("/Products/{id:int?}", async context =>
        //     {
        //         var IdData = context.Request.RouteValues["id"];
        //         if (IdData is not null)
        //         {
        //             int id = Convert.ToInt32(IdData);
        //             await context.Response.WriteAsync($"Your Request Product With Id => {id}");
        //         }
        //         else
        //         {
        //             await context.Response.WriteAsync("You are at Products Page");
        //         }
        //     });
        //     endpoint.MapGet("/Books/{id}/{author:alpha:minlength(4):maxlength(6)}", async context =>
        //     {
        //         int id = Convert.ToInt32(context.Request.RouteValues["id"]);
        //         string author = context.Request.RouteValues["author"].ToString();
        //         await context.Response.WriteAsync($"Your Request Book With Id => {id} and Author => {author}");
        //     });
        //     
        // });
        
        // app.MapControllerRoute(
        //     name : "default",
        //     pattern: "/{Controller = Home}/{Action = Index}" ,
        //     defaults: new {Controller = "Home", Action = "Index"}
        // );
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
        
        app.Run();
    }
}