using Microsoft.EntityFrameworkCore;
using Portfolio.Api.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var connectionString =
    builder.Configuration.GetConnectionString("Portfolio")
    ?? throw new InvalidOperationException("Connection string 'Portfolio' not found.");

builder.Services.AddDbContext<PortfolioDbContext>(options =>
    options
        .UseNpgsql(connectionString)
        .UseSeeding(
            (context, _) =>
            {
                var db = (PortfolioDbContext)context;
                if (db.Experience.Any())
                    return;
                SeedData.AddAll(db);
                db.SaveChanges();
            }
        )
        .UseAsyncSeeding(
            async (context, _, cancellationToken) =>
            {
                var db = (PortfolioDbContext)context;
                if (await db.Experience.AnyAsync(cancellationToken))
                    return;
                SeedData.AddAll(db);
                await db.SaveChangesAsync(cancellationToken);
            }
        )
);

builder.Services.AddOutputCache(options =>
    options.AddPolicy(
        "Content",
        policy =>
        {
            if (builder.Environment.IsDevelopment())
                policy.NoCache();
            else
                policy.Expire(TimeSpan.FromMinutes(10));
        }
    )
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseOutputCache();

app.MapStaticAssets();

app.MapControllers();

app.MapFallback("/api/{**path}", () => Results.NotFound());

app.MapFallbackToFile("index.html");

app.Run();
