create database dbsNilai

create table tb_nilai(id int primary key, npm int, kd_matkul int, uas int, 
uts int, kuis int,tugas int, kehadiran int, nilai_akhir int, grade varchar(1));

create table tb_mhs(npm int primary key, nama varchar(50), prodi varchar(20), kelas varchar(20),
alamat varchar(100))

create table tb_matkul(kd_matkul int primary key, nama_matkul varchar(100), kd_dosen int) 

insert tb_matkul VALUES (1001, 'Data and Information Management', 10011),
(1002, 'Programming Language 2', 10012)

insert tb_mhs VALUES (14180057, 'Habsyi Ikhlashul Ariq', 'Sistem Informasi', 'B', 'Dramaga'),
(14180006, 'Dera Ayu Rasyita', 'Sistem Informasi', 'B', 'Cilebut')

insert into tb_nilai VALUES(1, 14180057, 1001, 81, 82, 83, 84, 85, 82, 'A')

UPDATE tb_nilai SET kd_matkul = 1001 WHERE id=1

SELECT * FROM tb_matkul
SELECT * FROM tb_nilai
SELECT * FROM tb_mhs

SELECT a.id, a.npm, (select nama from tb_mhs where npm = a.npm) As nama,
(select nama_matkul from tb_matkul where kd_matkul= a.kd_matkul) As mata_kuliah,
a.tugas, a.kehadiran, a.kuis, a.uts, a.uas, a.nilai_akhir, a.grade
 FROM tb_nilai a
 
CREATE PROCEDURE print_nilai @aNPM BIGINT, @aNIS BIGINT OUTPUT, @aMAT CHAR(30) OUTPUT, @aUAS FLOAT OUTPUT,
@aUTS FLOAT OUTPUT, @aKUIS FLOAT OUTPUT, @aTGS FLOAT OUTPUT, @aHDR FLOAT OUTPUT,@aNA FLOAT OUTPUT, @aHDR FLOAT OUTPUT
AS SELECT
@aNIS = npm, @aMAT = kd_matkul,
@aUAS = uas, @aUTS = uts,
@aKUIS = kuis, @aTGS = tugas,
@aHDR = kehadiran
FROM tb_nilai WHERE NPM=@aNPM
 
 
CREATE PROCEDURE PRINTHURUF @aNPM BIGINT, @aNIS BIGINT OUTPUT, @aMAT CHAR(30) OUTPUT, @aUAS FLOAT OUTPUT,
@aUTS FLOAT OUTPUT, @aKUIS FLOAT OUTPUT, @aTGS FLOAT OUTPUT, @aHDR FLOAT OUTPUT
AS SELECT
@aNIS = npm, @aMAT = kd_matkul,
@aUAS = uas, @aUTS = uts,
@aKUIS = kuis, @aTGS = tugas,
@aHDR = kehadiran
FROM tb_nilai WHERE NPM=@aNPM


DECLARE @xNis BIGINT
DECLARE @xMAT VARCHAR(30)
DECLARE @xUAS FLOAT
DECLARE @xUTS FLOAT
DECLARE @xKUIS FLOAT
DECLARE @xTGS FLOAT
DECLARE @xHDR FLOAT

EXEC PRINTHURUF @aNPM=14180057,
@aNIS=@xNis OUTPUT,
@aMAT=@xMAT OUTPUT,
@aUAS=@xUAS OUTPUT,
@aUTS=@xUTS OUTPUT,
@aKUIS=@xKUIS OUTPUT,
@aTGS=@xTGS OUTPUT,
@aHDR=@xHDR OUTPUT
PRINT 'NILAI PERKULIAHAN'
PRINT '-----------------'
PRINT ''
PRINT 'NPM SISWA : ' + convert(varchar(13),@xNis)
PRINT 'MATA KULIAH : ' + convert(varchar(30),@xMAT)
PRINT 'NILAI UAS : ' + convert(varchar(5),@xUAS)
PRINT 'NILAI UTS : ' + convert(varchar(5),@xUTS)
PRINT 'NILAI KUIS : ' + convert(varchar(5),@xKUIS)
PRINT 'NILAI TUGAS : ' + convert(varchar(5),@xTGS)
PRINT 'KEHADIRAN : ' + convert(varchar(5),@xHDR)
PRINT ''
PRINT 'TOTAL NILAI : ' +
convert(varchar(5),(@xUAS+@xUTS+@xKUIS+@xTGS+@xHDR)/5)

 

