@echo off
cd /d D:\AgenteMonitoreo

echo Eliminando historial Git anterior...
rd /s /q .git

echo Inicializando repositorio Git limpio...
git init

echo Conectando al repositorio remoto...
git remote add origin https://github.com/acrriss/AgenteMonitoreo.git

echo Agregando todos los archivos...
git add .

echo Creando nuevo commit limpio...
git commit -m "Versión limpia del sistema AgenteMonitoreo (historial reiniciado sin secretos)"

echo Estableciendo rama principal como main...
git branch -M main

echo Subiendo proyecto a GitHub con --force...
git push -u origin main --force

echo.
echo ==== PROCESO FINALIZADO ====
pause
