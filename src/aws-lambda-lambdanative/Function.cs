using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization.Json;

namespace LambdaNative
{
    public class Handler : IHandler<string, respondModel>
    {
        public ILambdaSerializer Serializer => new JsonSerializer();

        public respondModel Handle(string name, ILambdaContext context)
        {
            return new respondModel { 
                    http_code = "200",
                    http_message = "Success",
                    body = new HelloModel { 
                            message = Hello(name) 
                        }
                };
        }

        public string Hello(string name)
        {
            return "Hello, " + name;
        }
    }
}
