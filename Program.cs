using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using TodoApi.Models;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("TodoList"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{


   
    app.UseSwagger();
    app.UseSwaggerUI( options => {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    }
       
    );
}else{
    app.UseSwagger();
    app.UseSwaggerUI( options => {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    }
       
    );
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
