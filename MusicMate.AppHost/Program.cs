var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder
    .AddProject<Projects.MusicMate_ApiService>("apiservice");

// builder.AddProject<Projects.MusicMate_Web>("webfrontend")
//     .WithExternalHttpEndpoints()
//     .WithReference(apiService)
//     .WaitFor(apiService);

builder.Build().Run();
