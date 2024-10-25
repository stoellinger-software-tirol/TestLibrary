namespace TestLibrary;

public class TestLibraryClass
{
    public string DoSomething()
    {
        var greetings = $"Hello User, it is {DateTime.Now}";
        return greetings;
    }
}