using KayakMeetUpService.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using KayakMeetUpService.Data;
using KayakMeetUpService.Abstractions.Interfaces.IQuery;
using KayakMeetUpService.Abstractions.Interfaces.IRepo;
using KayakMeetUpService.Data.Query;
using KayakMeetUpService.Data.Repository;

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
    o.UseSqlServer(builder.Configuration.GetConnectionString("User"),
        b => b.MigrationsAssembly("KayakMeetUpService.Data")));


builder.Services.AddControllers().AddJsonOptions(o =>
{
    o.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<CasualMeetUpUseCases>();
builder.Services.AddScoped<FishingTournamentEventUseCases>();
builder.Services.AddScoped<RaceEventUseCases>();
builder.Services.AddScoped<UserUseCases>();

builder.Services.AddScoped<ICasualMeetUpEventQuery, CasualMeetUpQueries>();
builder.Services.AddScoped<ICasualMeetUpEventRepository, CasualMeetupRepository>();

builder.Services.AddScoped<IFishingTournamentQueries, FishingTournamentQueries>();
builder.Services.AddScoped<IFishingTournamentRepository, FishingTournamentRepository>();

builder.Services.AddScoped<IRaceEventQuery, RaceEventQueries>();
builder.Services.AddScoped<IRaceEventRepository, RaceEventRepository>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserQuery, UserQueries>();




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
