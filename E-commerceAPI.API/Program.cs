using E_commerceAPI.DAL;
using E_commerceAPI.BL;
using E_commerceAPI.DAL.Data.Context;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
const string AllowAllCorsPolicy = "AllowAll";

// Add services to the container.

#region Default

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#endregion
#region data base

builder.Services.AddDbContext<E_commerceContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("E_CommerceSystem"));

});
#endregion
#region ServiceOfLayers

builder.Services.AddDALServices();
builder.Services.AddBLServices();

#endregion

#region Identity

builder.Services.AddIdentityCore<User>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 3;

    options.User.RequireUniqueEmail = true;
    options.Lockout.MaxFailedAccessAttempts = 3;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
})
    .AddEntityFrameworkStores<E_commerceContext>();

#endregion

#region Authentication

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = "MyDefault";
    options.DefaultChallengeScheme = "MyDefault"; 
})
    .AddJwtBearer("MyDefault", options =>
    {
        var keyFromConfig = builder.Configuration.GetValue<string>("SecretKey")!;
        var keyInBytes = Encoding.ASCII.GetBytes(keyFromConfig);
        var key = new SymmetricSecurityKey(keyInBytes);

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            IssuerSigningKey = key
        };
    });

#endregion

#region Authorization

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policy =>
        policy
        .RequireClaim(ClaimTypes.Role,"admin"));
});

#endregion

#region cors
builder.Services.AddCors(
    options =>
    {
        options.AddPolicy(AllowAllCorsPolicy, b =>
        {
            b.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
    });
#endregion


var app = builder.Build();



if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(AllowAllCorsPolicy);



var folderPath = Path.Combine(builder.Environment.ContentRootPath, "Assets");
Directory.CreateDirectory(folderPath);

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(folderPath),
    RequestPath = "/Assets"
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();


