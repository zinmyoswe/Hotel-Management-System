CREATE TABLE Guest
(
	GuestID varchar(20)NOT NULL PRIMARY KEY,
	GuestName varchar(50),
	NRCNo varchar(50),
	Addres varchar(50),
);

CREATE TABLE Room
(
	RoomID varchar(20)NOT NULL PRIMARY KEY,
	RoomNo varchar(50),
	RoomType varchar(50)
);

CREATE TABLE RoomType
(
	RoomTypeID varchar(20)NOT NULL PRIMARY KEY,
	RoomType varchar(50)
);
SELECT*FROM RoomType

SELECT * FROM Room

CREATE TABLE CheckIn
(
	CheckInID varchar(20)NOT NULL PRIMARY KEY,
	CheckInDate varchar(50),
	GuestName varchar(50),
	RoomNo varchar(50)
);

CREATE TABLE CheckOut
(
	CheckOutID varchar(20)NOT NULL PRIMARY KEY,
	CheckOutDate varchar(50),
	CheckOutTime varchar(50),
	RoomNo varchar(50),
	GuestName varchar(50),
	CheckInDate varchar(50),
	NoOfDay varchar(50),
	TotalCharges varchar(50),
	OtherCharges varchar(50),
	Discount varchar(50),
	Total varchar(50),
);

SELECT*FROM CheckOut

CREATE TABLE Reservation
(
	ReservationID varchar(20)NOT NULL PRIMARY KEY,
	ReservationDate varchar(50),
	RoomNo varchar(50),
	DepositReservation varchar(50),
	RoomNo varchar(50),
	GuestName varchar(50)
);

CREATE TABLE Drinkandliquid
(
	DrinkandliquidID varchar(20)NOT NULL PRIMARY KEY,
	DrinkandliquidType varchar(50),
	DrinkandliquidName varchar(50),
	Price varchar(50),
);

Select*from room
CREATE TABLE Food
(
	FoodID varchar(20)NOT NULL PRIMARY KEY,
	FoodType varchar(50),
	FoodName varchar(50),
	Price varchar(50),
);

CREATE TABLE ExtraItem
(
	ExtraItemID varchar(20)NOT NULL PRIMARY KEY,
	ExtraItemType varchar(50),
	Price varchar(50)
);

CREATE TABLE Orderfoodanddrink
(
	OrderID varchar(20)NOT NULL PRIMARY KEY,
	OrderDate varchar(50),
	RoomNo varchar(50),
	TotalAmount int
);

CREATE TABLE RentItem
(
	RentID varchar(20)NOT NULL PRIMARY KEY,
	RentDate varchar(50),
	ExtraItemID varchar(20),
	ExtraItemType varchar(50),
	RoomNo varchar(50),
	Price varchar(50),
	Quantity varchar(50),
	Night varchar(50),
	Amount varchar(50),
);

CREATE TABLE Cool
(
	CoolID varchar(20)NOT NULL PRIMARY KEY,
	CoolType varchar(50),
	CoolName varchar(50),
	Price varchar(50),
);

CREATE TABLE DrinkType
(
	DrinkTypeID varchar(20)NOT NULL PRIMARY KEY,
	TypeName varchar(50)
)

CREATE TABLE FoodType
(
	FoodTypeID varchar(20)NOT NULL PRIMARY KEY,
	TypeName varchar(50)
)

CREATE TABLE OrderFood
(
	OrderID varchar(20),
	FoodID varchar(20),
Quantity int,
Amount int,
	PRIMARY KEY (OrderID,FoodID)
)

CREATE TABLE OrderDrink
(
	OrderID varchar(20),
	DrinkandliquidID varchar(20),
Quantity int,
Amount int,
	PRIMARY KEY (OrderID,DrinkandliquidID)
)

insert into DrinkType values ('DT-01','Beer')
insert into DrinkType values ('DT-02','Juice')
insert into DrinkType values ('DT-03','Liquid')
insert into DrinkType values ('DT-04','Hot')
insert into DrinkType values ('DT-05','Cool')
insert into DrinkType values ('DT-06','Wine')

SELECT*FROM DrinkType
select * from Food

insert into FoodType values ('FT-01','Chicken')
insert into FoodType values ('FT-02','Pork')
insert into FoodType values ('FT-03','Sea Food')
insert into FoodType values ('FT-04','Fish')
insert into FoodType values ('FT-05','Soup')
insert into FoodType values ('FT-06','Salad')
insert into FoodType values ('FT-07','Toast')

select * from orderfood
select * from orderfoodanddrink
select * from orderdrink
select*from DrinkType

create view orderdetailview as
(
select ofd.OrderID,ofd.OrderDate,ofd.RoomNo,(dl.DrinkandliquidName) as orderName,od.Quantity,od.Amount
from Orderfoodanddrink ofd,orderdrink od,DrinkandLiquid dl
where ofd.OrderID=od.OrderID
and dl.DrinkandliquidID=od.DrinkandliquidID
UNION
select ofd.OrderID,ofd.OrderDate,ofd.RoomNo,f.FoodName,ofs.Quantity,ofs.Amount
from Orderfoodanddrink ofd,orderfood ofs,Food f
where ofd.OrderID=ofs.OrderID
and f.FoodID=ofs.FoodID
)
select * from orderfoodanddrink
select * from orderfood
select * from orderdrink
select * from Drinkandliquid

select * from checkout
select * from room

select ci.CheckinID,ci.CheckinDate,ci.CheckinTime,ci.GuestName,ci.NoofRoom,ci.RoomNo,co.checkoutDate,co.CheckoutTime,co.RoomNo ,co.NoofDay,co.Total
from checkout co,checkin ci,detail d,room r,guest g
where co.checkinDate=ci.checkinDate
and d.roomID=r.roomid
and r.roomno=co.roomno
and g.guestName=ci.guestName





select * from Food
select * from foodtype