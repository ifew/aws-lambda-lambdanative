using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

using LambdaNative;
using Newtonsoft.Json;

namespace aws_lambda_function.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestFunctionMethod()
        {
            string expected = "{\"http_code\":\"200\",\"http_message\":\"Success\",\"body\":{\"message\":\"Hello, iFew\"}}";

            var function = new Handler();
            var context = new TestLambdaContext();
            respondModel hello_result = function.Handle("iFew", context);

            string result = JsonConvert.SerializeObject(hello_result);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestHelloMethod()
        {
            string input = "iFew";
            string expected = "Hello, iFew";

            var function = new Handler();
            string hello_result = function.Hello(input);

            Assert.Equal(expected, hello_result);
        }
    }
}
