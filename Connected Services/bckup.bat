CLS
ECHO OFF
CHCP 866
 
REM УКАЗАНИЕ ПЕРЕМЕННЫХ СРЕДЫ POSTGRESQL 
SET PGBIN=C:\Program Files\PostgreSQL\16\bin
SET PGDATABASE=postgres
SET PGHOST=localhost
SET PGPORT=5432
SET PGUSER=postgres
SET PGPASSWORD=postgres
 
REM ПЕРЕХОД В КАТАЛОГ С bat-ФАЙЛОМ (ОТКУДА ЗАПУЩЕН ФАЙЛ)
%~d0
CD %~dp0
 
REM ФОРМИРОВАНИЕ ИМЕНИ ФАЙЛА ДЛЯ РЕЗЕРВНОЙ КОПИИ И LOG ФАЙЛА ОТЧЕТА
SET DAT=%date:~0,2%%date:~3,2%%date:~6,4%
SET DUMPFILE=D:\backups\PG\%DAT%-postgres.backup
SET LOGFILE=D:\backups\PG\%DAT%-postgres.log
SET DUMPPATH="%DUMPFILE%"
SET LOGPATH="%LOGFILE%"
 
REM ВЫПОЛНЕНИЕ КОМАНДЫ (ПРОГРАММЫ) ДЛЯ СОЗДАНИЯ РЕЗЕРВНОЙ КОПИИ БАЗЫ 
::CALL "%PGBIN%\pg_dump.exe" --format=custom -U postgres --verbose --file=%DUMPPATH% 2>%LOGPATH%
CALL "%PGBIN%\pg_dump.exe" --host localhost --port 5432 --username "postgres" --role "postgres" --format custom --blobs --section pre-data --section data --section post-data --encoding UTF8 --verbose --file %DUMPPATH% 2>%LOGPATH%
REM ВЫПОЛНЕНИЕ КОМАНДЫ (ПРОГРАММЫ) ЗАВЕРШЕНО, ЕСЛИ ОШИБОК НЕТ - ТО КОНЕЦ
IF NOT %ERRORLEVEL%==0 GOTO Error
GOTO Successfull
REM ПРИ ВОЗНИКНОВЕНИИ ОШИБОК УДАЛЯЕТСЯ ПОВРЕЖДЕННЫЙ ФАЙЛ КОПИИ И СООТВЕТСТВУЮЩАЯ ЗАПИСЬ В ЖУРНАЛЕ О ЕЕ СОЗДАНИИ
:Error
DEL %DUMPPATH%
MSG * "Ошибка при создании резервной копии базы данных. Смотрите backup_postgres.log."
ECHO %DATETIME% Ошибки при создании резервной копии базы данных %DUMPFILE%. Смотрите отчет %LOGFILE%. >> postgres.log
GOTO End
 
REM ЕСЛИ КОПИЯ СДЕЛАНА БЕЗ ОШИБОК ДЕЛАЕТСЯ ЗАПИСЬ В ЖУРНАЛЕ РЕГИСТРАЦИИ
:Successfull
ECHO %DATETIME% Успешное создание резервной копии %DUMPFILE% >> postgres.log
GOTO End
:End