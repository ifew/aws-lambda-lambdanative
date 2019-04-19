using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization.Json;
using LambdaNative;

namespace aws_lambda_lambdanative
{
    public class Function : IHandler<string, respondModel>
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
