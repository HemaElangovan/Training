use shop

create table Candidate(
Ccode int, Name char(20), DOJ Date)

Insert into Candidate values (1001, 'S.Raman', '1957-06-12');
Insert into Candidate values (1002, 'M.Sushil', '1957-11-12');
Insert into Candidate values (1003, 'Mohanyes', '1957-07-30');

select * from Candidate

update Candidate set Name= 'R.Krishnan' where Name='S.Raman'

drop table Candidate