// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
