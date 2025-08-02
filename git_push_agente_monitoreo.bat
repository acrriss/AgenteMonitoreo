@echo off
cd /d D:\AgenteMonitoreo

echo.
echo Agregando todos los archivos...
git add .

echo.
set /p msg="Ingrese el mensaje del commit: "
git commit -m "%msg%"

echo.
echo Cambiando a rama 'main'...
git branch -M main

echo.
echo Subiendo al repositorio remoto...
git push -u origin main

pause
