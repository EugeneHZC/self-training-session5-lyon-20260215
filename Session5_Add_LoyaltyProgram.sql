use [BelleCroissantLyonnais]

delete from LoyaltyProgram;

-- insert all customers into LoyaltyProgram table
insert into LoyaltyProgram
select CustomerId, 0, MembershipStatus from Customers;

-- set 250 customers with random point values
with query as (
	select top(250) * from LoyaltyProgram
	order by newid()
)
update query
set Points = floor(rand(checksum(newid())) * 1450) + 50;