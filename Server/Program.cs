using Microsoft.EntityFrameworkCore;
using BL;
using Dal;


var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

DBActions db=new DBActions(builder.Configuration);
string connStr = db.GetConnectionString("EquipmentForSoldiersDB");
builder.Services.AddSingleton<BLManager>(x=>new BLManager(connStr));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
