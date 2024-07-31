using ApiKanbanGestao.DataDbContext;
using ApiKanbanGestao.Interfaces.IRepository;
using ApiKanbanGestao.Interfaces.IService;
using ApiKanbanGestao.Repository;
using ApiKanbanGestao.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<KanbanGestaoDbContext>(options =>
        options.UseNpgsql("Host=127.0.0.1;Database=postgres;Username=postgres;Password=TesteKanban@2345;Port=5432;Pooling=true;"));

builder.Services.AddScoped<IAtividadeRepository,AtividadeRepository>();
builder.Services.AddScoped<IColunaRepository,ColunaRepository>();
builder.Services.AddScoped<IColunaXAtividadeRepository, ColunaXAtividadeRepository>();
builder.Services.AddScoped<IApplicationService, ApplicationService>();

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
