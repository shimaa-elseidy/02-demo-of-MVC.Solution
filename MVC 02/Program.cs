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
            //app.MapControllerRoute(
            //    name: "Default" ,
            //   pattern:"{controller}/{action}/{id?}"

            //   // pattern: "{controller=movie}/{action=GetMovie}/{id=5}" // ==> Setting default values
            //   // pattern: "{controller=movie}/{action=GetMovie}/{id:alpha=5}" // ==> Setting default values
            //   // pattern: "{controller=movie}/{action=GetMovie}/{id:alpha:length(4)=5}" // ==> Setting default values
            //   // pattern: "{controller=movie}/{action=GetMovie}/{id:alpha:length(3,6)=5}" // ==> Setting default values
            //   // pattern: "{controller=movie}/{action=GetMovie}/{id:int=5}" // ==> Setting default values
            //   // Regex ==> Regular Expression
            //   // pattern: "{controller=movie}/{action=GetMovie}/{id:regex()=5}" // ==> Setting default values
            //   //pattern: "{controller=movie}/{action=GetMovie}/{id?}" // ==> Setting default values ==> id --> optional not requaried
            //    );
            app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
            
        }
        public static string SignIn()
        {
            return $"U UR Signed!";
        }

    }
  
}
