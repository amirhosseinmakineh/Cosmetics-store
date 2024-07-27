using Cosmetics_store.ApplicationService.Command.CategoryCommand;
using Cosmetics_store.ApplicationService.Command.Product;
using Cosmetics_store.ApplicationService.Command.SliderCommand;
using Cosmetics_store.ApplicationService.CommandHandler.Ctaegory;
using Cosmetics_store.ApplicationService.CommandHandler.Product;
using Cosmetics_store.ApplicationService.CommandHandler.Slider;
using Cosmetics_store.ApplicationService.Contract.Cdn;
using Cosmetics_store.Domain.IRepositories;
using Cosmetics_store.Infrastracture.CosmeticsContext;
using Cosmetics_store.Infrastracture.Repositories;
using CosmeticStore.Framwork.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x=>
{
});
builder.Services.AddControllers();
builder.Configuration.GetSection("CdnConfiguration").Bind(new CdnConfiguration());
builder.Configuration.GetSection("CdnImageConfiguration").Bind(new CdnImageConfiguration());
#region Register Context
builder.Services.AddDbContext<CosmeticsStoreContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Cosmetics-store"));
});
#endregion
#region Register CommandHandlers
builder.Services.AddTransient<ICommandHandler<GetCategoryCommand>, GetCategoryCommandHandler>();
builder.Services.AddTransient<ICommandHandler<GetSliderCommand>, SliderCommandHandler>();
builder.Services.AddTransient<ICommandHandler<GetMainProductCommand>, GetMainProductCommandHandler>();
#endregion
#region Register Repisitory
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductGalleryRepository, ProductGalleryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IColorRepository, ColorRepository>();
builder.Services.AddScoped<ISliderRepository, SliderRepository>();
#endregion
#region RegisterCommand
builder.Services.AddTransient<ICommandBus, CommandBus>();
#endregion
builder.Services.AddCors(c => c.AddPolicy("CorsPolicy", builder =>
builder.WithOrigins("http://localhost:8001/")
.AllowAnyMethod()
.AllowAnyHeader()
.AllowCredentials()
));
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");
app.MapControllers();
app.Run();
