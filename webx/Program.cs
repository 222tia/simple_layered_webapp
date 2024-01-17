using factorialService;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", ()=> "Here is Factorial(5)=" + Factorial.getFactorial(5));
app.Run();
