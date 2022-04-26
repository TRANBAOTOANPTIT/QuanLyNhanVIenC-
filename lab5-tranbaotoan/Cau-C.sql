/*----------------------------------------------------------
MASV: N18DCAT076
HO TEN:Tran Bao Toan
LAB: 05
NGAY:10/06/2021
----------------------------------------------------------*/
CREATE MASTER KEY ENCRYPTION BY PASSWORD = 'Aa1234';
DROP CERTIFICATE TDECert
use master
go
CREATE CERTIFICATE TDECert 
WITH SUBJECT = 'Database_Encryption';
go

USE QLBongDa;
GO
CREATE DATABASE ENCRYPTION KEY
WITH ALGORITHM = AES_256
ENCRYPTION BY SERVER CERTIFICATE TDECert
GO
ALTER DATABASE QLBongDa
SET ENCRYPTION ON;
GO
use master
go
backup certificate TDECert to file = 'D:\SVA_Certificate_Backup.cer'
with private key(
file = 'D:\SVA_PK_Backup.pvk',
encryption by password = '123abc')