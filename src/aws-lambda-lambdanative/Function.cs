using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization.Json;

namespace LambdaNative.Example
{
    public class Handler : IHandler<HelloModel, respondModel>
    {
        public ILambdaSerializer Serializer => new JsonSerializer();

        public respondModel Handle(HelloModel request, ILambdaContext context)
        {
            return new respondModel { body = "Hello iFew" };
        }
    }
}
