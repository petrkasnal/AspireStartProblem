var builder = DistributedApplication.CreateBuilder(args);

var postgre = builder
    .AddPostgres("Test");

builder.Build().Run();
