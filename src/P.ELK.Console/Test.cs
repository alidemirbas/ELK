using Microsoft.Extensions.Logging;

namespace P.ELK.Console;

public class Test
{
    private readonly ILogger<Test> _logger;

    public Test(ILogger<Test> logger)
    {
        _logger = logger;
    }

    public void TestMethod()
    {
        for (int i = 0; i < int.MaxValue; i++)
        {
            _logger.Log(LogLevel.Error, "test log");
            Thread.Sleep(3000);
        }
    }
}
