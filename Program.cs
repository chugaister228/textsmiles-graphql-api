using Microsoft.EntityFrameworkCore;
using TextSmiles.API;
using TextSmiles.API.Data;
using TextSmiles.API.DataLoader;
using TextSmiles.API.Emotions;
using TextSmiles.API.Smiles;
using TextSmiles.API.Users;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite("Data Source=textsmiles.db")
);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddDataLoader<SmileByEmotionIdDataloader>()
    .AddMutationType(d => d.Name("Mutation"))
        .AddTypeExtension<EmotionMutations>()
        .AddTypeExtension<SmileMutations>()
        .AddTypeExtension<UserMutations>()
    .AddInMemorySubscriptions()
    .AddSubscriptionType<Subscription>()
    .AddFiltering()
    .AddSorting()
    .AddProjections()
    ;

var app = builder.Build();

app.MapGraphQL("/api");

app.Run();