using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Newtonsoft.Json;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace aws_lambda_function
{
    public class Function
    {
        public string FunctionHandler(string inputName, ILambdaContext context)
        {
            respondModel respond = new respondModel {
                http_code = "200",
                http_message = "Success",
                body = new HelloModel {
                    message = Hello(inputName)
                }
            };

            return JsonConvert.SerializeObject(respond);
        }

        public string Hello(string name)
        {
            return "Hello, " + name;
        }

    }
}
