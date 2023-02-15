FROM mcr.micosoft.com/dotnet/sdk as build-env

WORKDIR /app
EXPOSE 80
EXPOSE 443

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.micosoft.com/dotnet/sdk
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "AzureContainerHostingAPI.dll" ]