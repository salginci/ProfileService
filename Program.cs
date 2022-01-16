

var builder = WebApplication.CreateBuilder(args);



// This line defines which port will be used for deployment. 
// builder.WebHost.ConfigureKestrel(options => options.ListenLocalhost(9980));

//builder.WebHost.UseUrls("http://localhost:9980");

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
