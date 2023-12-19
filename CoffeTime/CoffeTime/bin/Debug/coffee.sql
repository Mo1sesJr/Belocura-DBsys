Create database Coffee
use Coffee
create table Account
(
username Varchar(30),
password1 varchar(30)

)
create table Account1
(
username Varchar(30),
password1 varchar(30)

)
create table Admin
(
username Varchar(30),
password1 varchar(30)

)
create table Crew
(
username Varchar(30),
password1 varchar(30)

)
create table CoffeeStocks
(
ItemNumber Int,
Coffeeitem varchar(30),
coffeeStock int,
coffeePrice int

)
create table CoffeeBuyers
(
ItemNumber Int,
Coffeeitem varchar(30),
Sugar Varchar(10),
coffeeStock int,
coffeePrice int,
CoffeeQuantiy Int,
ModeOfPayment Varchar(20),
Mobile Varchar(20)

)




select * from CoffeeStocks
INSERT INTO Admin(username,password1) VALUES ('Admin','Admin');
INSERT INTO Crew(username,password1) VALUES ('Crew','Crew');
