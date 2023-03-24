@echo off
if exist config.cfg goto allok
:firststart
echo Seems like manager started for the first time, lets configure it!
:afterincorrectdir
set /p drc="Path for game folder: "
if not exist %drc%\mods goto incorrectdir
echo %drc% > config.cfg
echo Made cfg file
echo msgbox "Restart manager to refresh mod list!",64,"Ok" > msg.vbs
msg.vbs
del msg.vbs
goto allok


:allok
exit




:incorrectdir
cls
echo [91mError! Incorrect path or Forge not installed. Check path and try again![0m
pause
cls
goto afterincorrectdir