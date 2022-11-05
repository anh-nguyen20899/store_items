// using Catalog.Repositories;
// using Catalog.Settings;
// using MongoDB.Bson;
// using MongoDB.Bson.Serialization;
// using MongoDB.Bson.Serialization.Serializers;
// using MongoDB.Driver;
// public static class Startup
// {
//     public static IConfiguration Configuration{ get;}

//     public static WebApplication InitializeApp( string[] args)
//     {
//         var builder = WebApplication.CreateBuilder(args);
//         ConfigureServices(builder);
//         var app = builder.Build();
//         Configure(app);
//         return app;
//     }
    
//     private static void ConfigureServices(WebApplicationBuilder builder)
//     {
//         // Add services to the container.
        
//         builder.Services.AddControllers(option =>
//         {
//             option.SuppressAsyncSuffixInActionNames = false;
//         });
//         // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//         builder.Services.AddEndpointsApiExplorer();
//         builder.Services.AddSwaggerGen();

//         BsonSerializer.RegisterSerializer(new GuidSerializer(BsonType.String));
//         BsonSerializer.RegisterSerializer(new DateTimeOffsetSerializer(BsonType.String));

//         builder.Services.AddSingleton<IMongoClient>(serviceProvider =>
//         {
//             var settings = Configuration.GetSection(nameof(MongoDbSettings)).Get<MongoDbSettings>();
//             return new MongoClient(settings.ConnectionString);
//         });

//         builder.Services.AddSingleton<IItemRepository, MongoDbItemsRepository>();
//     }
//     private static void Configure(WebApplication app)
//     {
//         // Configure the HTTP request pipeline.
//         if (app.Environment.IsDevelopment())
//         {
//             app.UseSwagger();
//             app.UseSwaggerUI();
//         }

//         app.UseHttpsRedirection();

//         app.UseAuthorization();

//         app.MapControllers();

//         app.Run();
//     }
// }