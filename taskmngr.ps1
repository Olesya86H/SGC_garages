$Env:PGPASSWORD = 'postgres';
$DateStr = (Get-Date).ToString("yyyy-MM-dd")
$BackupPath = 'D:\tmp!!!'
#cd "C:\Program Files\PostgreSQL\16\bin"
psql -U postgres -W postgres -Atc "SELECT datname FROM pg_database;" | foreach {
  if ($_ -notmatch 'postgres|template1|template0') {
    pg_dump $_ > $BackupPath\$_.$DateStr.sql
  }
}