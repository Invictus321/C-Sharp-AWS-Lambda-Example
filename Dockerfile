FROM microsoft/dotnet:latest

# The AWS lambda package command assumes the machine has this particular zip command
# If it is a different one, it may not work on Lambda, due to the file permissions not being carried over
RUN apt-get update
RUN apt-get --assume-yes install zip
RUN mkdir app
WORKDIR /app
CMD dotnet restore && dotnet lambda package -c Debug -f netcoreapp1.1