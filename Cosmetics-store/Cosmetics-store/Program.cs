using Cosmetics_store.Infrastracture.CosmeticsContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
#region Register Context
builder.Services.AddDbContext<CosmeticsStoreContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Cosmetics-store"));
});
#endregion
#region Register CommandHandlers
#endregion
#region Register Repisitory
#endregion
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers();
app.Run();
