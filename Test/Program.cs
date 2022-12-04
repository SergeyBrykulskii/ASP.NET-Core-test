var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.UseWelcomePage();

//app.Run(async (context) => await context.Response.WriteAsync("Hello ASP"));

// ƒанный пример показывает что каждый элемент middleware создаетс€ единожды
/*
int x = 2;
app.Run(async (context) =>
{
    x *= 2;
    await context.Response.WriteAsync($"Result: {x}");
});
*/

//app.Run(async (context) => context.Response.Redirect("https://vk.com/"));

/*
app.Run(async (context) =>
{
    var response = context.Response;
    response.Headers.ContentLanguage = "ru-RU";
    response.Headers.ContentType = "text/plain; charset=utf-8";
    response.Headers.Append("secret-id", "256");    // добавление кастомного заголовка
    await response.WriteAsync("ѕривет METANIT.COM");
});
*/

/*
app.Run(async (context) =>
{
    context.Response.StatusCode = 404;
    await context.Response.WriteAsync("Response not found");
});
*/
/*
app.Run(async (context) =>
{
    var response = context.Response;
    response.ContentType = "text/html; charset=utf-8";
    await response.WriteAsync("<h1>Somebody</h1>");
});
*/

app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    var stringBuilder = new System.Text.StringBuilder("<table>");

    foreach(var header in context.Request.Headers)
    {
        stringBuilder.Append($"<tr><td>{header.Key}</td><td>{header.Value}</td><tr>");
    }

    stringBuilder.Append("</table>");
    await context.Response.WriteAsync(stringBuilder.ToString());
});
app.Run();
