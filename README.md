# Creating the zip file for AWS Lambda

## Using Docker:
`docker run -v $PWD:/app -w /app microsoft/dotnet:latest /bin/sh -c 'dotnet restore && dotnet lambda package -c Debug -f netcoreapp1.1'`

## Using .NET Core CLI
Install .NET Core CLI
`docker restore
docker lambda package -c Debug -f netcoreapp1.1`