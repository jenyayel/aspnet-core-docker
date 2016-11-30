FROM microsoft/dotnet:1.0.0-preview2-sdk

ADD WebAPI /WebAPI/
WORKDIR /WebAPI

RUN dotnet restore \
    && dotnet build

EXPOSE 5555
CMD dotnet run --server.urls http://+:5555