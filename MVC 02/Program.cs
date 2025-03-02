namespace MVC_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();//Register Built-in MVC Services
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            ////app.MapGet("/login", () => "U UR Signed!");
            //app.MapGet("/login", SignIn);

            // MVC 
            app.MapControllerRoute(
                name: "Default Routing" ,
               // pattern:"{controller}/{action}/{id}"
                pattern: "{controller=movie}/{action=GetMovie}/{id=5}" // ==> Setting default values
                );
            app.Run();
        }
        public static string SignIn()
        {
            return $"U UR Signed!";
        }

    }
  
}
