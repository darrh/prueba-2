var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Prueb>("prueb");

builder.Build().Run();
