using ApiKanbanGestao.DataDbContext;
using ApiKanbanGestao.Interfaces.IRepository;
using ApiKanbanGestao.Interfaces.IService;
using ApiKanbanGestao.Repository;
using ApiKanbanGestao.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços ao contêiner.
builder.Services.AddControllers();

// Configura o Swagger/OpenAPI.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "KanbanGestaoController.API",
        Version = "v1",
        Description = "API para gerenciamento eficiente de tarefas no estilo Kanban," +
        " facilitando a criação, atualização," +
        " e monitoramento de atividades em diferentes fases do fluxo de trabalho.",
        Contact = new OpenApiContact
        {
            Name = "Fernando",
            Email = "fernandopsilvadossantos@gmail.com",
            Url = new Uri("https://www.linkedin.com/in/fernandopsds/")
        },
        License = new OpenApiLicense
        {
            Name = "MIT",
            Url = new Uri("https://opensource.org/licenses/MIT")
        }
    });
});

// Conexão banco PostgreSQL
builder.Services.AddDbContext<KanbanGestaoDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresPcEmpresa")));

// Adiciona dependências para injeção de dependência.
builder.Services.AddScoped<IApplicationService, ApplicationService>();
builder.Services.AddScoped<IAtividadeRepository, AtividadeRepository>();
builder.Services.AddScoped<IColunaRepository, ColunaRepository>();
builder.Services.AddScoped<IColunaXAtividadeRepository, ColunaXAtividadeRepository>();

var app = builder.Build();

// Configuração da solicitação HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "KanbanGestaoController.API v1");
        c.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
