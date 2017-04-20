FROM microsoft/dotnet:latest
RUN apt-get update
RUN apt-get --assume-yes install zip
RUN mkdir app
WORKDIR /app
CMD dotnet restore && dotnet lambda package -c Debug -f netcoreapp1.1