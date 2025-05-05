using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OnlineEdu.Business.Abstract;
using OnlineEdu.Business.Concrete;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.DataAccess.Context;
using OnlineEdu.DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly()); //AutoMapper'ý dahil ettik.
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>)); //DataAccess 
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>)); //Business

builder.Services.AddDbContext<AppDbContext>(options => { 
options.UseNpgsql(builder.Configuration.GetConnectionString("SqlConnection")); //AppDbContext'den Db Baðlantýsý saðlandý
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
