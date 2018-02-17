@echo the evergreen helloworld app
@echo off
msbuild greetings.csproj /t:Build %1 %2 %3 %4 %5
@Echo.
@echo and we are done
@echo on