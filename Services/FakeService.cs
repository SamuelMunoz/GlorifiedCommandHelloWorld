namespace GlorifiedCommandHelloWorld.Services;

public class FakeService : IFakeService
{
    
}

public interface IFakeService
{
    string SayHello() => "Hello, World!";
}