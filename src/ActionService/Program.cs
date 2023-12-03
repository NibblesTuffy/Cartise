using ActionService.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//specify which db my application want to connect
//never put connection string inside your program file
//DbContext: brain between your connection between your application and database
builder.Services.AddDbContext<AuctionDbContext>(opt => {
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

//Configure the HTTP request pipeline
app.UseAuthorization();

app.MapControllers();
//seed data
try{
    DbInitializer.InitDb(app);
}catch(Exception e){
    Console.WriteLine(e);
}

app.Run();
