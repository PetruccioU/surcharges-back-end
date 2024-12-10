
var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        context.Configuration.Bind("AppHost", services);
        context.Configuration.Bind("Application", services);
        context.Configuration.Bind("Domain", services);
        context.Configuration.Bind("Infrastructure", services);
        context.Configuration.Bind("Web", services);
        // Register dependencies from Application, Infrastructure, etc.
    });

var app = builder.Build();

app.Run();