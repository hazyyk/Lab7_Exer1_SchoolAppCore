using SchoolAppCore; // 👈 Make sure this matches your namespace

var builder = WebApplication.CreateBuilder(args);

// Call Startup.cs
var startup = new Startup(builder.Configuration);

// Call ConfigureServices from Startup
startup.ConfigureServices(builder.Services);

// Build the app
var app = builder.Build();

// Call Configure from Startup
startup.Configure(app, app.Environment);

app.Run();
