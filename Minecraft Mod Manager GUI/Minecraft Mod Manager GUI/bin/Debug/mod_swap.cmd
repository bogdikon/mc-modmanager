@echo off
echo %1
del /Q %1\..\*.*
copy /Y %1\*.* %1\..\
start ok.vbs