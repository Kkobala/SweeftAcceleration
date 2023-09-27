create database Sweeft_dbo

use [Sweeft_dbo]
go

create table [dbo].Teacher(
	Id int primary key,
	FirstName varchar(20) not null,
	LastName varchar(30) not null,
	Gender varchar(20) not null,
	Subjects varchar(50) not null
);

create table [dbo].Pupil(
	Id int primary key,
	FirstName varchar(20) not null,
	LastName varchar(30) not null,
	Gender varchar(20) not null,
	Class varchar(50) not null
);

create table [dbo].TeacherPupil(
    TeacherId int references [dbo].Teacher(Id),
    PupilId int references [dbo].Pupil(Id),
    primary key (TeacherId, PupilId)
);

insert into Teacher (Id, FirstName, LastName, Gender, Subjects) values
(1, 'Manana', 'Mgaloblishvili', 'Female', 'Math');
insert into Teacher (Id, FirstName, LastName, Gender, Subjects) values
(2,'Gela', 'Maglakelidze', 'Male', 'Science');
insert into Teacher (Id, FirstName, LastName, Gender, Subjects) values
(3,'Qeti', 'Sanamiani', 'Female', 'English');
insert into Teacher (Id, FirstName, LastName, Gender, Subjects) values
(4, 'Nino', 'Odishelidze', 'Female', 'Chemistry');

insert into Pupil (Id, FirstName, LastName, Gender, Class) values
(1, 'Giorgi', 'Kekenadze', 'Male', 'ClassA');
insert into Pupil (Id, FirstName, LastName, Gender, Class) values
(2, 'Lasha', 'Maisuradze', 'Male', 'ClassB');
insert into Pupil (Id, FirstName, LastName, Gender, Class) values
(3, 'Sergo', 'Kobaladze', 'Male', 'ClassC');


insert into TeacherPupil (TeacherId, PupilId)
values ((select Id from Teacher where FirstName = 'Manana'), (select Id from Pupil where FirstName = 'Giorgi'));

insert into TeacherPupil (TeacherId, PupilId) 
values ((select Id from Teacher where FirstName = 'Gela'), (select Id from Pupil where FirstName = 'Giorgi'));

insert into TeacherPupil (TeacherId, PupilId)
values ((select Id from Teacher where FirstName = 'Qeti'), (select Id from Pupil where FirstName = 'Giorgi'));

select distinct t.*
from Teacher t
inner join TeacherPupil tp on t.Id = tp.TeacherId
inner join Pupil p on tp.PupilId = p.Id
where p.FirstName = 'Giorgi';
