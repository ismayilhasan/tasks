create database Homework_task_books

use Homework_task_books

create table Authors(
Id int primary key identity,
[Name] nvarchar(30),
Surname nvarchar(30)

)

create table Books(
Id int identity,
[Name] nvarchar(100) check (len([Name]) > 2),
AuthorId int foreign key references Authors(Id),
[PageCount] int check ([PageCount] > 10)
)


Create view vw_Books 
as 
select Authors.Name + ' '+ Surname as fullname,Books.Name,Books.PageCount from Authors
right join Books on
Books.AuthorId = Authors.Id



select * from vw_Books

create procedure FindBooks
@Searching_fullname  nvarchar(30)
as
select Authors.Name + Surname as Fullname,Books.Name,Books.PageCount from Authors 
left join Books on
Books.AuthorId = Authors.Id
where @Searching_fullname = Authors.Name + ' ' + Authors.Surname

alter procedure FindBooks
@Searching_fullname  nvarchar(30)
as
select Authors.Name + ' ' + Surname as Fullname,Books.Name,Books.PageCount from Authors 
left join Books on
Books.AuthorId = Authors.Id
where @Searching_fullname = Authors.Name + ' ' + Authors.Surname



exec FindBooks 'Adam Fawer'

create procedure AddAuthor
@Name nvarchar(30),
@Surname nvarchar(30)
as
insert into Authors
values (@Name,@Surname)

exec AddAuthor 'Qurban' ,'Said'

create procedure DeleteAuthor -- delete prodeuce
@Id int
as
delete from Authors 
where  Authors.Id =  @Id 




