using DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//Registered DbContext dependency
builder.Services.AddDbContext<SchlDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConn"));
});

//Registered DataAccessFactory dependency
// builder.Services.AddScoped<DataAccessFactory>();

//Registered repository dependencies
builder.Services.AddScoped<IUserRepo>();
builder.Services.AddScoped<ITeacherRepo>();
builder.Services.AddScoped<IStudentRepo>();
builder.Services.AddScoped<IRoleRepo>();
builder.Services.AddScoped<IDepartmentRepo>();
builder.Services.AddScoped<ICourseTeacherRepo>();
builder.Services.AddScoped<ICourseStudentRepo>();
builder.Services.AddScoped<ICourseDepartmentRepo>();
builder.Services.AddScoped<ICourseRepo>();

//Registered service dependencies

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

