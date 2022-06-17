using System.Text.Json;
using WorkerApp;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .ConfigureLogging(builder =>
        builder.AddJsonConsole(options =>
        {
            options.IncludeScopes = false;
            options.TimestampFormat = "hh:mm:ss ";
            options.JsonWriterOptions = new JsonWriterOptions
            {
                Indented = true
            };
        }))
    .Build();

await host.RunAsync();
