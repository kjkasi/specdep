use ACS_WORK_COPY
go

if object_id('dbo.test1412') is not null
    drop table dbo.test1412
go

create table dbo.test1412
(
    door_id int not null,
    log_date datetime not null
)
go

insert into dbo.test1412 (door_id, log_date)
values (0, '11.12.2022'),
       (0, '12.12.2022'),
       (1, '12.12.2022')

select foo.door_id, foo.ccount,
        (
            select top 1 bar.log_date
            from dbo.test1412 as bar
            where bar.door_id = foo.door_id
            order by bar.log_date
        ) as log_date
from    (
            select door_id, count(door_id) as ccount
            from dbo.test1412
            group by door_id
        ) as foo