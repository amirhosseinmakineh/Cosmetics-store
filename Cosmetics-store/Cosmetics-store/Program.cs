using Cosmetics_store.ApplicationService.Command.CategoryCommand;
using Cosmetics_store.ApplicationService.CommandHandler.Ctaegory;
using Cosmetics_store.Domain.IRepositories;
using Cosmetics_store.Infrastracture.CosmeticsContext;
using Cosmetics_store.Infrastracture.Repositories;
using CosmeticStore.Framwork.Abstractions;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x=>
{
    x.GeneratePolymorphicSchemas();
});
builder.Services.AddControllers();
#region Register Context
builder.Services.AddDbContext<CosmeticsStoreContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Cosmetics-store"));
});
#endregion
#region Register CommandHandlers
builder.Services.AddTransient<ICommandHandler<GetCategoryCommand>, GetCategoryCommandHandler>();
#endregion
#region Register Repisitory
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
#endregion
#region RegisterCommand
    builder.Services.AddTransient<ICommandBus, CommandBus>();
    #endregion
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers();
app.Run();
