using System;
using Xunit;
using lambda;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.TestUtilities;
 
namespace LambdaExample.Tests
{
    public class TestLambdaExample
    {
        [Fact] 
        public void LambdaExampleReturnsStatusOK()
        {
            APIGatewayProxyRequest request = new APIGatewayProxyRequest();
            request.Body = "Test Body";
            TestLambdaContext context = new TestLambdaContext();
            Hello hello = new Hello();
            APIGatewayProxyResponse response = hello.MyHandler(request, context);
            Assert.Equal(200, response.StatusCode);
        }
    }

}
