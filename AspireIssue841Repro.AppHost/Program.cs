var builder = DistributedApplication.CreateBuilder(args);

var api1 = builder.AddProject<Projects.AspireIssue841Repro_Api1>("api1");

builder.AddProject<Projects.AspireIssue841Repro_Web>("frontend.blazor")
    .WithReference(api1);

builder.AddProject<Projects.AspireIssue814Repro_RazorPages>("frontend.razorpages")
    .WithReference(api1);

builder.Build().Run();
