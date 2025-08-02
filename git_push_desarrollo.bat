@echo off
cd /d D:\AgenteMonitoreo

echo Creando nueva rama 'desarrollo' y cambiando a ella...
git checkout -b desarrollo

echo.
echo Agregando todos los archivos...
git add .

echo.
set /p msg="Ingrese el mensaje del commit: "
git commit -m "%msg%"

echo.
echo Subiendo rama 'desarrollo' al repositorio remoto...
git push -u origin desarrollo

pause
