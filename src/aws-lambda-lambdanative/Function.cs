using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization.Json;

//[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace LambdaNative.Example
{
    public class Handler : IHandler<Request, Response>
    {
        public ILambdaSerializer Serializer => new JsonSerializer();
        
        public Response Handle(Request inputName, ILambdaContext context)
        {
            // respondModel respond = new respondModel {
            //     http_code = "200",
            //     http_message = "Success",
            //     body = new HelloModel {
            //         message = Hello(inputName)
            //     }
            // };
            Response respond = new Response("Hi, " + inputName, inputName);

            return respond;
        }

        public string Hello(string name)
        {
            return "Hello, " + name;
        }

    }
}
