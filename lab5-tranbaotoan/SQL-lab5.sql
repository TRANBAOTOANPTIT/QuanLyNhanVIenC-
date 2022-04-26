/*----------------------------------------------------------
MASV: N18DCAT076
HO TEN:Tran Bao Toan
LAB: 05
NGAY:10/06/2021
----------------------------------------------------------*/
use master
CREATE MASTER KEY ENCRYPTION BY PASSWORD = '123@';
OPEN MASTER KEY DECRYPTION BY PASSWORD = '123@'   
use master
go
create certificate TDECert
 from file = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER2\MSSQL\SVA_Certificate_Backup.cer'
 with private key
  ( file = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER2\MSSQL\SVA_PK_Backup.pvk'
  , decryption by password = '123abc'
   );
 