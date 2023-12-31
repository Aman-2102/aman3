
create table UserDetail (UserId int identity(1,1),UserName varchar(30),Gender nvarchar(5),WalletAmount int)00

create table DriverDetail(DriverId int identity(201,1),DriverName varchar(30),Gender nvarchar(5))

create table UserDrive(UserDriveMappingId int identity(301,1),UserId int,PickupLocationId int,DropLocationId int)

create table DriverLocation (DriverId int,DriverLocation int,Avaliablity varchar(5))

create table LocationMapping(LocationMappingId int identity(501,1),LocationName varchar(40))

create table BookingDetail(BookingId int identity(1001,1),UserId int,DriverId int,UserDriveMappingId int,Charge int)
insert into BookingDetail values(1,202,501,502,300)
select * from DriverDetail
select * from LocationMapping
select * from DriverLocation
select * from UserDrive
select * from UserDetail
select * from BookingDetail
truncate table bookingdetail
update DriverLocation set Avaliablity='yes'
insert into BookingDetail(UserId,DriverId,PickupLocationId,DropLocationId)
select ud.UserId,dd.DriverId,ud.userdrivemappingid from UserDrive ud 
cross join DriverLocation dd where ud.PickupLocationId=dd.DriverLocation


select * from locationtable lt join  locationoption lo on lo.locationmappingid=lt.locationmappingid 
join DriverLocation dl on dl.DriverLocation=lt.locationmappingid  join UserDrive ud on ud.PickupLocationId=lo.optionid
where dl.DriverLocation=lt.locationmappingid 
and ud.PickupLocationId=lo.optionid
