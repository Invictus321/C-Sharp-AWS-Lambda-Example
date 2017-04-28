using System;
using Xunit;
using lambda;
using Amazon.Lambda.TestUtilities;

namespace LambdaExample.Tests
{
    public class TestLambdaExample
    {
        [Fact] 
        public void LambdaExampleReturnsStatusOK()
        {
            Request request = new Request();
            request.Body = "Test Body";
            TestLambdaContext context = new TestLambdaContext();
            Hello hello = new Hello();
            Response result = hello.MyHandler(request, context);
            Assert.Equal(200, result.StatusCode);
        }
    }

}
