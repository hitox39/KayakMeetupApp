using Microsoft.EntityFrameworkCore;
using KayakMeetupService.Data;
using KayakMeetupService.Abstractions.Interfaces.IQuery;
using KayakMeetupService.Abstractions.Interfaces.IRepo;
using KayakMeetupService.Application.UseCases;

var cors = "test";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(cors, policy =>
    {
        policy.AllowAnyMethod();
        policy.AllowAnyOrigin();
        policy.AllowAnyHeader();
    });
});

// Add services to the container.

builder.Services.AddDbContext<MainContext>(o =>
    o.UseSqlServer(builder.Configuration.GetConnectionString("KayakMeetupService"),
        b => b.MigrationsAssembly("KayakMeetupService.Data")));


builder.Services.AddControllers().AddJsonOptions(o =>
{
    o.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserQuery, UserQueries>();
builder.Services.AddScoped<GetUserUseCase>();
builder.Services.AddScoped<AddUserUseCase>();
builder.Services.AddScoped<DeleteUserUseCase>();
builder.Services.AddScoped<UpdateUserUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(cors);

app.UseAuthorization();

app.MapControllers();

app.Run();
