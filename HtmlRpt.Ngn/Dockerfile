#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HtmlRpt.Ngn/HtmlRpt.Ngn.csproj", "HtmlRpt.Ngn/"]
RUN dotnet restore "HtmlRpt.Ngn/HtmlRpt.Ngn.csproj"
COPY . .
WORKDIR "/src/HtmlRpt.Ngn"
RUN dotnet build "HtmlRpt.Ngn.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HtmlRpt.Ngn.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HtmlRpt.Ngn.dll"]