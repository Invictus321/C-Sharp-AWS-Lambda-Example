The current AWS docs for .NET Lambda functions are wrong. 

They use the package.json method, which is now deprecated.

This example shows how to get it working with the latest .NET Core tools.

## Creating the zip file for AWS Lambda

Clone this repository

cd to the project folder

### Method 1: Docker

```
docker build -t lambdaexample .
docker run -v $(PWD):/app lambdaexample
```

### Method 2: .NET Core CLI
Install .NET Core CLI using this guide https://www.microsoft.com/net/core

```
dotnet restore
dotnet lambda package -c Debug -f netcoreapp1.1
```

## Uploading the zip file

Using either method, you should end up with a .zip file at ./bin/Debug/netcoreapp1.1/

Upload this zip file to your AWS Lambda function

The handler function should be "LambdaExample::lambda.Hello::MyHandler"

Sample lambda test data:

```
{
    "InputNum": 3
}
```