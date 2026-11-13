using VeracodeDemo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddScoped<APIHelper>();
builder.Services.AddScoped<EncryptionHelper>();
builder.Services.AddScoped<HTMLHelper>();
builder.Services.AddScoped<LogHelper>();
builder.Services.AddScoped<NavigationHelper>();
builder.Services.AddScoped<OrderHelper>();
builder.Services.AddScoped<ProcessAutoTask>();
builder.Services.AddScoped<QuoteDataAccess>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
