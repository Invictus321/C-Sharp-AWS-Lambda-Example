The current AWS docs for .NET Lambda functions is wrong. They use the package.json method, which is now deprecated.
This example shows how to get it working with the latest .NET Core tools.

## Creating the zip file for AWS Lambda

### Using Docker:
```
docker run -v $PWD:/app -w /app microsoft/dotnet:latest /bin/sh -c 'dotnet restore && dotnet lambda package -c Debug -f netcoreapp1.1'
```

### Using .NET Core CLI
Install .NET Core CLI using this guide https://www.microsoft.com/net/core#macos

```
dotnet restore
dotnet lambda package -c Debug -f netcoreapp1.1
```

Using either method, you should end up with a .zip file at ./bin/Debug/netcoreapp1.1/

Upload this zip file to AWS Lambda

The handler function should be "lambda::lambda.Hello::MyHandler"

Sample lambda test data:

```
{
    "InputNum": 3
}
```