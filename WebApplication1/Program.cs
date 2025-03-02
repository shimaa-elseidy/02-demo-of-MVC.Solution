namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Register Any Services
            builder.Services.AddControllersWithViews();
            builder.Services.AddControllers();
            builder.Services.AddRazorPages();
            builder.Services.AddMvc();
            var app = builder.Build();
            // Configure Any Middleware
            app.UseRouting();
            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
