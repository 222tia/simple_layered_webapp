using factorialService;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/" ()=> "Here is Factorial(5)=" + factorialService.Factorial(5));
app.Run();
