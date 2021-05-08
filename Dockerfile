FROM mcr.microsoft.com/dotnet/sdk:5.0
WORKDIR /source

RUN apt-get update

RUN apt-get -y install make

CMD bash
