@echo off
set mypath=%cd%
title experiencekitdashboard

cd %mypath%\Dashboard\Player\
start oscar.exe -m

timeout /t 1 /nobreak > NUL

rem Check to see if JAVAW exists, if not use java
set JAVA_EXE=java
javaw -version

if "%ERRORLEVEL%" == "0" set JAVA_EXE=javaw

cd %mypath%\Dashboard\
start %JAVA_EXE% -Xms3G -jar BIFF.Marvin.jar -vvvv -i "Data/App.Dashboard.xml" -log %computername%.html -altsplash Data/Images/splash-1280.png

del /f %computername%.*
