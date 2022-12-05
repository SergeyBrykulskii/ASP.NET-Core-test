var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.UseWelcomePage();

//app.Run(async (context) => await context.Response.WriteAsync("Hello ASP"));


// Данный пример показывает что каждый элемент middleware создается единожды
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
await response.WriteAsync("Привет METANIT.COM");
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




/*
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
*/



/*
app.Run(async (context) =>
{
var acceptHeaderValue = context.Request.Headers.Accept;
await context.Response.WriteAsync($"Accept: {acceptHeaderValue}");
});
*/


//app.Run(async (context) => await context.Response.WriteAsync($"Path: {context.Request.Path}"));



/*
app.Run(async (context) =>
{
var path = context.Request.Path;
var now = DateTime.Now;
var response = context.Response;

if (path == "/date")
    await response.WriteAsync($"Date: {now.ToShortDateString()}");
else if (path == "/time")
    await response.WriteAsync($"Time: {now.ToShortTimeString()}");
else
    await response.WriteAsync("Hello world");
});
*/



/*
app.Run(async (context) =>
{
context.Response.ContentType = "text/html; charset=utf-8";
await context.Response.WriteAsync($"<p>Path: {context.Request.Path}</p>" +
    $"<p>QueryString: {context.Request.QueryString}</p>");
});
*/



/*
app.Run(async (context) =>
{
context.Response.ContentType = "text/html; charset=utf-8";
var stringBuilder = new System.Text.StringBuilder("<h3>Параметры строки запроса</h3><table>");
stringBuilder.Append("<tr><td>Параметр</td><td>Значение</td></tr>");
foreach (var param in context.Request.Query)
{
    stringBuilder.Append($"<tr><td>{param.Key}</td><td>{param.Value}</td></tr>");
}
stringBuilder.Append("</table>");
await context.Response.WriteAsync(stringBuilder.ToString());
});
*/




/*
app.Run(async (context) =>
{
string name = context.Request.Query["name"];
string age = context.Request.Query["age"];
await context.Response.WriteAsync($"{name} - {age}");
});
*/



//app.Run(async (context) => await context.Response.SendFileAsync("C:\\Users\\Serxio\\Desktop\\img\\5.jpg"));


/*app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("html\\htmlpage.html");
});*/



/*
app.Run(async (context) =>
{
    var path = context.Request.Path;
    var response = context.Response;

    response.ContentType = "text/html; charset=utf-8";
    if (path == "")
    {
        await context.Response.WriteAsync("Hello from home page");
    }
    else if (path == "/page1")
        await response.SendFileAsync("html\\page1.html");
    else if (path == "/page2")
        await response.SendFileAsync("html\\page2.html");
    else
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsync("Response not found! Error 404");
    }
});
*/



/*
app.Run(async (context) =>
{
    var path = context.Request.Path;
    var fullPath = $"html/{path}.html";
    var response = context.Response;

    response.ContentType = "text/html; charset=utf-8";
    if (File.Exists(fullPath))
    {
        await response.SendFileAsync(fullPath);
    }
    else
    {
        response.StatusCode = 404;
        await response.WriteAsync("<h2>Not Found</h2>");
    }
});
*/

app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";

    
    if (context.Request.Path == "/postuser")
    {
        var form = context.Request.Form;
        string name = form["name"];
        string age = form["age"];
        await context.Response.WriteAsync($"<div><p>Name: {name}</p><p>Age: {age}</p></div>");
    }
    else
    {
        await context.Response.SendFileAsync("html/index.html");
    }
});
app.Run();
