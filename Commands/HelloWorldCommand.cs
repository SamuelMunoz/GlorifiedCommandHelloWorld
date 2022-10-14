using Cocona;
using GlorifiedCommandHelloWorld.Services;
using Spectre.Console;

namespace GlorifiedCommandHelloWorld.Commands;

public class HelloWorldCommand
{
    private readonly IFakeService _fakeService;

    public HelloWorldCommand(IFakeService fakeService)
    {
        _fakeService = fakeService;
    }

    [Command("say-hello")]
    public void Execute()
    {
        AnsiConsole.Markup($"[underline red]{_fakeService.SayHello()}[/]");
    }
}