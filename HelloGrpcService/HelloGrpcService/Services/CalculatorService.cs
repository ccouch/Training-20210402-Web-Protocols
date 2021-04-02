using Grpc.Core;
using HelloGrpcService.Protos;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloGrpcService.Services
{
    public class CalculatorService : 
        calculator.calculatorBase
    {
        private readonly ILogger<CalculatorService> _logger;
        public CalculatorService(ILogger<CalculatorService> logger)
        {
            _logger = logger;
        }

        public override Task<AddReply> Add(AddRequest request, ServerCallContext context)
        {

            _logger.LogDebug("This is a test...");

            return Task.FromResult(new AddReply
            {
                Result = request.Value01 + request.Value02
            });

        }

    }
}
