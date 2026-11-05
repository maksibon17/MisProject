var builder = DistributedApplication.CreateBuilder(args);
var postgres = builder.AddPostgres("postgres").WithPgAdmin();
var misDb = postgres.AddDatabase("misdb");

builder.AddProject<Projects.MisProject_ApiService>("misproject-apiservice")
    .WithReference(misDb)
    .WaitFor(misDb);

builder.Build().Run();
