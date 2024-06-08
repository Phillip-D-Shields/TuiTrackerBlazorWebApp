var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.TuiTrackerWebApp>("tuitrackerwebapp");

builder.Build().Run();
