using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELK.Console
{

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
}
