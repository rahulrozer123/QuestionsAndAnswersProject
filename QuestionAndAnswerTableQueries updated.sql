use QuestionsAndAnswersDB

--create table Roles
--(
--RoleId int not null primary key identity(1,1),
--RoleName nvarchar(100)
--)

--create table UserRegistration
--(
--UserId int not null primary key identity(1,1),
--RoleId int foreign key references Roles(RoleId) ON DELETE CASCADE ON UPDATE CASCADE,
--Username nvarchar(150),
--Pwd nvarchar(100), 
--Confirmpassword nvarchar(100),
--Email nvarchar(MAX),
--YearsOfExperience int,
--Technology nvarchar(100)
--)

--create table QuestionandAnswer
--(
--QuestionID int not null primary key identity(1,1),
--TechnologyID int foreign key references MasterTechnology(TechnologyID) ON DELETE CASCADE ON UPDATE CASCADE,
--Question nvarchar(MAX),
--Option1 nvarchar(MAX),
--Option2 nvarchar(MAX),
--Option3 nvarchar(MAX),
--Option4 nvarchar(MAX),
--ActualAnswer nvarchar(MAX)
--)

--create table MasterTechnology
--(
--TechnologyID int not null primary key identity(1,1),
--TechnologyName nvarchar(100)
--)


--create table Answers
--(
--AnswersID int not null primary key identity(1,1),
--ReceivedAnswers nvarchar(MAX),
--Result bit,
--UserId int foreign key references UserRegistration(UserId) ON DELETE CASCADE ON UPDATE CASCADE,
--TechnologyID int foreign key references MasterTechnology(TechnologyID),
--QuestionID int foreign key references QuestionandAnswer(QuestionID) ON DELETE CASCADE ON UPDATE CASCADE
--)

--ON DELETE CASCADE ON UPDATE CASCADE means if you UPDATE OR DELETE the parent, the change is cascaded to the child. This is the equivalent of AND ing the outcomes of first two statements.

--select * from Roles

--select * from UserRegistration

--select * from MasterTechnology

--select Question,Option1,Option2,Option3,Option4 from QuestionandAnswer where TechnologyID=1
--select *  from QuestionandAnswer where TechnologyID=5

--select ActualAnswer from QuestionandAnswer where QuestionID=5


--select *  from QuestionandAnswer
--select * from Answers
--select * from UserRegistration
--select * from MasterTechnology
--select * from Roles

--select UserId from UserRegistration where Username='Rahul'

--DELETE FROM Answers WHERE AnswersID=4
