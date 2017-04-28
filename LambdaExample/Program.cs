using System;
using System.IO;
using System.Collections.Generic;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;

namespace lambda {
    public class Hello {
        static void Main(string[] args) {} 
        
        [LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
        public APIGatewayProxyResponse MyHandler(APIGatewayProxyRequest input, ILambdaContext context) {
            context.Logger.LogLine("MyHandler called with input body " + input.Body);
            APIGatewayProxyResponse response = new APIGatewayProxyResponse();
            response.StatusCode = 200;
            response.Body = "Success";
            return response;    
        }
    }
}