using System;
using System.IO;
using Amazon.Lambda.Core;

namespace lambda {
    class Hello {
        static void Main(string[] args) {}
        
        [LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
        public OutputObject MyHandler(InputObject input, ILambdaContext context) {
            context.Logger.LogLine("MyHandler called with input num " + input.InputNum);
            return new OutputObject("Success");
        }
    }

    public class InputObject {
        public int InputNum = 0;
    }

    public class OutputObject {
        public String Response = "";
        public OutputObject(string response) {
            Response = response;
        }
    }
}
