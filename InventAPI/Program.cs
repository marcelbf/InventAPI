using InventOnHand.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsAllowAll",
        builder =>
        {
            builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});

var app = builder.Build();

app.UseCors("CorsAllowAll");

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/Warehouse", () =>
{
    return InventoryDB.GetWarehouses();

})
.WithName("GetWarehouses")
.WithOpenApi();

app.MapGet("/Items", () =>
{
    return InventoryDB.GetItems();

})
.WithName("GetItems")
.WithOpenApi();

app.MapGet("/InventOnHand/{ItemId}", (string itemId) =>
{
    return InventoryDB.GetInventOnHand(itemId);

})
.WithName("GetInventOnHand")
.WithOpenApi();

app.Run();
