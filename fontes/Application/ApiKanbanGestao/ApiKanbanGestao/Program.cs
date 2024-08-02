using ApiKanbanGestao.DataDbContext;
using ApiKanbanGestao.Interfaces.IRepository;
using ApiKanbanGestao.Interfaces.IService;
using ApiKanbanGestao.Repository;
using ApiKanbanGestao.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "KanbanGestaoController.API", Version = "v1", Description = "Gerenciamento de tarefas" });
});
builder.Services.AddDbContext<KanbanGestaoDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Postgres")));

builder.Services.AddScoped<IApplicationService, ApplicationService>();
builder.Services.AddScoped<IAtividadeRepository,AtividadeRepository>();
builder.Services.AddScoped<IColunaRepository,ColunaRepository>();
builder.Services.AddScoped<IColunaXAtividadeRepository, ColunaXAtividadeRepository>();

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
