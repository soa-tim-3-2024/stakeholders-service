using Explorer.API.Controllers.Proto;
using Explorer.API.Startup;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
//builder.Services.AddHostedService<MailingListScheduler>();
builder.Services.ConfigureSwagger(builder.Configuration);
const string corsPolicy = "_corsPolicy";
builder.Services.ConfigureCors(corsPolicy);
builder.Services.ConfigureAuth();
builder.Services.AddHttpClient();
builder.Services.RegisterModules();
builder.Services.AddGrpc();

var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
//app.UseDeveloperExceptionPage();
app.UseSwagger();
app.UseSwaggerUI();
//}
//else
//{
//    app.UseExceptionHandler("/error");
//    app.UseHsts();
//}

app.UseRouting();
app.UseCors(corsPolicy);
app.UseHttpsRedirection();
app.UseAuthorization();
app.UseAuthorization();
app.UseStaticFiles();

app.MapControllers();
app.MapGrpcService<AuthenticationProtoController>();

app.Run();

// Required for automated tests
namespace Explorer.API
{
    public partial class Program { }
}