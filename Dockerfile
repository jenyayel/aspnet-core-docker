FROM microsoft/dotnet:1.0.0-preview2-sdk

ADD WebAPI /WebAPI/
WORKDIR /WebAPI

RUN dotnet restore \
    && dotnet build

EXPOSE $PORT
CMD dotnet run --server.urls http://+:$PORT