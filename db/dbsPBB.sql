CREATE DATABASE dbsPBB

CREATE TABLE tblObjek(noPbb char(25), nama varchar(75), alamat
varchar(250), lokasi varchar(250), luasrumah int, luastanah int,
klsrumah char(3), klstanah char(3))

CREATE TABLE tblKelas(kdKelas char(3), keterangan varchar(80), nilaiNJOP
int, nilaiTKP int, nilaiTarif smallint)

insert into tblKelas values('065','Bangunan Rumah', 50000000, 1500000, 10),
('021','Tanah Sertifikat Hak Milik', 50000000, 1200000, 10)

insert into tblObjek values('32.71.060.009.005-0365.0','AMINAH
SUSILOWATI','BUMI KENCANA PERMAI BLOK F1/26 RT. 010 RW. 01 KENCANA
TANAH SAREL KOTA BOGOR','BUMI KENCANA PERMAI BLOK F1/26 RT. 010 RW. 01
KENCANA TANAH SAREL KOTA BOGOR',27,70,'021','065')

SELECT * FROM tblKelas
SELECT * FROM tblObjek

select o.noPbb, o.nama, o.alamat, o.luastanah as [luas bumi],
o.klstanah as [kelas bumi],k.nilaiNJOP as NJOP, (o.luastanah * k.nilaiTKP) as
total from tblObjek o INNER JOIN tblKelas k ON k.kdKelas=o.klstanah

select o.noPbb, o.nama, o.alamat, o.luasrumah as [luas bangunan],
o.klsrumah as [kelas bangunan],k.nilaiNJOP as NJOP, (o.luasrumah *
k.nilaiNJOP) as total from tblObjek as o,tblKelas as k where
k.kdKelas=o.klsrumah

