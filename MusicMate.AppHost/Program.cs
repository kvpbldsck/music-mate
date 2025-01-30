var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder
    .AddProject<Projects.MusicMate_ApiService>("apiservice");

builder.Build().Run();
