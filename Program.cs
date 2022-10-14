using Cocona;
using GlorifiedCommandHelloWorld.Commands;
using GlorifiedCommandHelloWorld.Services;
using Microsoft.Extensions.DependencyInjection;

var builder = CoconaApp.CreateBuilder();

builder.Services.AddSingleton<IFakeService, FakeService>();

var app = builder.Build();

app.AddCommands<HelloWorldCommand>();

app.Run();