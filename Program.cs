using System;
using System.IO;
using System.Collections.Generic;
using Amazon.Lambda.Core;

namespace lambda {
    class Hello {
        static void Main(string[] args) {}
        
        [LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
        public Response MyHandler(Request input, ILambdaContext context) {
            context.Logger.LogLine("MyHandler called with input body " + input.Body);
            return new Response("Success");
        }
    }

    public class Request {
        public String Resource;
        public String Path;
        public String HttpMethod;
        public Dictionary<String, String> Headers;
        public Dictionary<String, String> QueryStringParameters;
        public Dictionary<String, String> PathParameters;
        public Dictionary<String, String> StageVariables;
        public RequestContext RequestContext;
        public String Body;
        public Boolean IsBase64Encoded;
    }

    public class RequestContext {
        public String AccountId;
        public String ResourceId;
        public String Stage;
        public String RequestId;
        public Identity Identity;
        public String ResourcePath;
        public String HttpMethod;
        public String ApiId;
    }

    public class Identity {
        public String CognitoIdentityPoolId;
        public String AccountId;
        public String CognitoIdentityId;
        public String Caller;
        public String ApiKey;
        public String SourceIp;
        public String CognitoAuthenticationType;
        public String CognitoAuthenticationProvider;
        public String UserArn;
        public String UserAgent;
        public String User;
    }

    public class Response {
        public int StatusCode;
        public Dictionary<String, String> Headers;
        public String Body;
        public Response(string response) {
            StatusCode = 200;
            Body = response;
        }
    }
}
