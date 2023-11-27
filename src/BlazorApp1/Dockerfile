FROM mcr.microsoft.com/dotnet/sdk:8.0 AS publish
WORKDIR /src
COPY . .
RUN dotnet publish "BlazorApp1/BlazorApp1.csproj" -c Release -o /app/publish
FROM nginx:alpine
RUN apk add bash icu-libs krb5-libs libgcc libintl libssl1.1 libstdc++ zlib
WORKDIR /var/www/web
COPY --from=publish /app/publish/wwwroot .
COPY BlazorApp1/nginx.conf /etc/nginx/nginx.conf
#SHELL ["/bin/bash", "-c"]
#CMD /usr/sbin/nginx -g "daemon off;"
EXPOSE 80
