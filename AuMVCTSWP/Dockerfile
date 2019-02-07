FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Site/Site.csproj", "Site/"]
RUN dotnet restore "Site/Site.csproj"
COPY . .
WORKDIR "/src/Site"
RUN dotnet build "Site.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Site.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Site.dll"]