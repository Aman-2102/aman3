
create table UserDetail (UserId int primary key,UserName varchar(30),Gender nvarchar(5),WalletAmount int)

create table DriverDetail(DriverId int primary key,DriverName varchar(30),Gender nvarchar(5))

create table UserDrive(UserDriveMappingId int primary key,UserId int foreign key references userdetail(userid)
,PickupLocationId int foreign key references LocationMapping (LocationMappingId) ,
DropLocationId int foreign key references LocationMapping (LocationMappingId),CancelBooking varchar(15)  )

create table DriverLocation (DriverLocationId int primary key,DriverId int foreign key references driverdetail(driverid),
DriverLocation int,Avaliablity varchar(5))

--create table LocationMapping (LocationMappingId int primary key,LocationName varchar(40))

create table paymentType(PaymentId int primary key,PaymentType varchar(30))

create table BookingDetail(BookingId int primary key ,DriverId int foreign key references driverdetail(driverid),
UserMappingId int foreign key references UserDrive(UserDriveMappingId),Charge int,
PaymentTypeId int foreign key references PaymentType(PaymentId) ,BookingTime datetime default getdate())