CREATE DATABASE dbsNIK

CREATE table tbl_ktp( 
	nik varchar(20) primary key,
	nama varchar(50),
	ttl varchar(50),
	jk varchar(10),
	alamat varchar(200),
	agama varchar(20),
	pekerjaan varchar(50),
	berlaku varchar(30)
)
CREATE table tbl_kk(
	id int primary key not null,
	no_kk varchar(20),
	nik varchar(20),
	nama varchar(50),
	ttl varchar(50),
	agama varchar(20),
	pekerjaan varchar(50)
)

SELECT * FROM tbl_kk;
drop table tbl_kk

INSERT INTO tbl_kk VALUES 
(1, 1234567890123456, 3671132205830006, 'Hamzah', '20/01/1950', 'islam', 'guru'),
(2, 1234567890123456, 3671132205830001, 'Siti', '03/03/1959', 'islam', 'Petani'),
(3, 1234567890123456, 3671132205830100, 'Bayu', '22/05/1999', 'islam', 'pelajar/mahasiswa'),
(4, 1234567890123456, 3671132205831000, 'Manda', '22/05/2005', 'islam', 'pelajar/siswa'),
(5, 1234567890123456, 3671132205832000, 'Noni', '29/05/2010', 'islam', 'pelajar/siswa')

INSERT INTO tbl_ktp VALUES 
('3671132205830', 'Hamzah', '20/01/1950','lk','Bogor', 'islam', 'guru', 'seumur hidup'),
('3671132205831', 'Siti', '03/03/1959', 'pr','Depok', 'islam', 'Petani', 'seumur hidup'),
('3671132205802', 'Bayu', '22/05/1999', 'lk','Jakarta', 'islam', 'pelajar/mahasiswa', 'seumur hidup'),
('3671132205833', 'Manda', '22/05/2005', 'pr','Bogor', 'islam', 'pelajar/siswa', 'seumur hidup'),
('3671132205834', 'Noni', '29/05/2010', 'pr','Tangerang', 'islam','pelajar/siswa', 'seumur hidup');

drop table tbl_ktp

select * from tbl_ktp
SELECT * FROM tbl_kk;

