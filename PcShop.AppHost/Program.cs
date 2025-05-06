var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PcShop_Api>("pcshop");

builder.Build().Run();
