use [BelleCroissantLyonnais]

delete from Promotions;

-- insert 10 promotions into Promotions table
insert into Promotions
select top(10)
	'Promotion Name',
	case
		when rand(checksum(newid())) < 0.5 then 'Percentage'
		else 'FixedAmount'
	end,
	floor(rand(checksum(newid())) * 100),
	ProductName,
	dateadd(day, checksum(newid()) % 20, '2026-01-10'),
	dateadd(day, checksum(newid()) % 20, '2026-02-10'),
	floor(rand(checksum(newid())) * 20),
	floor(rand(checksum(newid())) * 99),
	null
from Products;

-- set 1 promotion to have end date before start date
with query as (
	select top(1) * from Promotions
	order by newid()
)
update query
set StartDate = '2026-01-10', EndDate = '2026-01-09';

-- set two promotions to be applicable to multiple products
with query as (
	select top(2) * from Promotions
	order by newid()
)
update query
set ApplicableProducts = 'Tarte Normande, Pain au Chocolat Pistache';