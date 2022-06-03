public class Program 
{ 
    public static void Main(string[] args) 
    { 
        CreateHostBuilder(args).Build().Run();
    } 

    public static IHostBuilder CreateHostBuilder(string[] args) => 
        Host.CreateDefaultBuilder(args) // sets the default files and variables for the project and logger configuration
            .ConfigureWebHostDefaults(webBuilder =>
            { 
                webBuilder.UseStartup<Startup>(); // in the Startup class, we configure the embedded or custom services that our application needs
            });
}