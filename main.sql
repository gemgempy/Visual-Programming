
CREATE TABLE Karyawan
(
nomor_karyawan INT IDENTITY(1,1) NOT NULL,
ID_karyawan AS ('K00'+CAST(nomor_karyawan AS VARCHAR(7))) PERSISTED,

nama_kry VARCHAR(50),
email_kry VARCHAR(50),
pass_kry VARCHAR(50),
tgl_lahir_karyawan DATE,
jk_karyawan CHAR(1) not null 
CHECK (jk_karyawan = 'M' OR jk_karyawan = 'F'),
alamat_karyawan VARCHAR(50),
telp_karyawan VARCHAR(50),
PRIMARY KEY (ID_karyawan)
)

SELECT * FROM Karyawan
DELETE FROM Karyawan
DROP TABLE Karyawan
DELETE FROM Karyawan

-----------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE Hewan
(
nomor_hewan INT IDENTITY(1,1) NOT NULL,
ID_hewan AS ('H00'+CAST(nomor_hewan AS VARCHAR(7))) PERSISTED,

nama_hewan VARCHAR(50),
spesies_hewan VARCHAR(50),
jenis_hewan VARCHAR(50),
tanggal_masuk DATE,
jk_hewan CHAR(1) not null 
CHECK (jk_hewan = 'M' OR jk_hewan = 'F'),
riwayat_penyakit VARCHAR(50),
umur_hewan NUMERIC(18,0),
PRIMARY KEY (ID_hewan)
)

ALTER TABLE Hewan
ALTER COLUMN umur_hewan INT;
DELETE FROM Hewan
SELECT * FROM Hewan
DROP TABLE Hewan

--------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE adopter
(
nomor_adopter INT IDENTITY(1,1) NOT NULL,
ID_adopter AS ('A00'+CAST(nomor_adopter AS VARCHAR(7))) PERSISTED,
nama_adopter VARCHAR(50)	not null,
email VARCHAR(50) not null, 
pswrd varchar (50) not null, 
tanggal_join date not null, 
alamat VARCHAR(50),
role_ VARCHAR(50),
PRIMARY KEY (ID_adopter)
)

SELECT * FROM adopter
DROP TABLE adopter
DELETE FROM adopter

-----------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE adopsi
(
no_adop INT IDENTITY(1,1) NOT NULL,
nomor_adopsi AS ('ADOPT00'+CAST(no_adop AS VARCHAR(10))) PERSISTED,
tanggal_adopsi date,
ID_hewan VARCHAR(10),
ID_adopter VARCHAR(10),
--FOREIGN KEY	(ID_hewan) REFERENCES Hewan,
FOREIGN KEY	(ID_adopter) REFERENCES adopter,
PRIMARY KEY (nomor_adopsi)
)

SELECT * FROM adopsi
DROP TABLE adopsi
DELETE FROM adopsi

-----------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE donasi
(
no_do INT IDENTITY(1,1) NOT NULL,
ID_donasi AS ('D0'+CAST(no_do AS VARCHAR(7))) PERSISTED,
nomor_adopsi VARCHAR(17),
jumlah_donasi int,
jenis_pembayaran VARCHAR(15),
tanggal_donasi date,
FOREIGN KEY	(nomor_adopsi) REFERENCES adopsi,
PRIMARY KEY (ID_donasi)
)

SELECT * FROM donasi
DROP TABLE donasi
DELETE FROM donasi

-----------------------------------------------------------------------------------------------------------------------------------------------------------

--MAU LIAT ID ADOPTER dari email
-- jadi join tabel adopsi dan adopter DI ID_adopter
SELECT adopter.ID_adopter, adopter.email, adopter.nama_adopter


SELECT adopter.email, adopsi.nomor_adopsi, adopter.nama_adopter, adopsi.tanggal_adopsi
FROM adopter
JOIN adopsi
ON adopter.ID_adopter = adopter.ID_adopter
WHERE email = 'historia@gmail.com'



-- MAU AMBIL NOMOR ADOPSI. nomor adopsi ada di tabel adopsi. kita punyanya, email adopter
-- jadi kita join tabel adopsi dan adopter DI ID_adopter
SELECT adopter.email, adopsi.nomor_adopsi, adopter.nama_adopter, adopsi.tanggal_adopsi
FROM adopter
JOIN adopsi
ON adopter.ID_adopter = adopter.ID_adopter
WHERE email = 'historia@gmail.com'
--where textbox email

SELECT adopter.email, adopsi.nomor_adopsi
FROM adopter
JOIN adopsi
ON adopter.ID_adopter = adopter.ID_adopter
WHERE email = 'sansa@gmail.com'


--donasi > adopsi > adopter > hewan> karyawan




