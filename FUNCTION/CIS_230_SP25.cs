using System;
using Azure.Storage.Queues.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FUNCTION
{
    public class CIS_230_SP25
    {
        private readonly ILogger<CIS_230_SP25> _logger;

        public CIS_230_SP25(ILogger<CIS_230_SP25> logger)
        {
            _logger = logger;
        }

        [Function(nameof(CIS_230_SP25))]
        public void Run([QueueTrigger("myqueue-items", Connection = "")] QueueMessage message)
        {
            _logger.LogInformation($"C# Queue trigger function processed: {message.MessageText}");
        }
    }
}
