using Grpc.Net.Client;
using HelloGrpcService;
using System;
using System.Threading.Tasks;
using static HelloGrpcService.Greeter;

namespace HelloGrpcClientApp
{
    class Program
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("Begin");
            Console.WriteLine(string.Empty);

            // Create the 
            var endPointAddress = "https://localhost:5001";
            Console.WriteLine($"gRPC Endpoint: {endPointAddress}");

            Console.WriteLine("Creating gRPC Channel");
            using var channel = GrpcChannel.ForAddress(address: endPointAddress);

            Console.WriteLine("Creating gRPC Client");
            var client = new GreeterClient(channel: channel);

            Console.WriteLine($"Create {nameof(HelloRequest)}");
            var request = new HelloRequest() 
            { 
                 Name = "John Smith"
            };

            Console.WriteLine($"{nameof(HelloRequest)} created with {nameof(HelloRequest.Name)} {request.Name}");

            Console.WriteLine($"Invoke the {nameof(client.SayHello)} method via the client");
            var response = await client.SayHelloAsync(request: request);

            Console.WriteLine("Response Recieved:");
            Console.WriteLine($"Message: {response.Message}");

            Console.WriteLine(string.Empty);
            Console.WriteLine("End");
            
            Console.ReadLine();


        }
    }
}
