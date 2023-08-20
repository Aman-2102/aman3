 alter TRIGGER Updateuserwallet
ON bookingdetail
AFTER INSERT
AS
BEGIN
	
    UPDATE UserDetail
    SET  WalletAmount-=(select sum(charge) from inserted)
    WHERE   UserDetail.UserId IN (SELECT inserted.UserId FROM inserted) 
	
END;  
alter trigger updatedriver
on bookingdetail
AFTER INSERT
AS
BEGIN
update DriverLocation set Avaliablity='no' 
 WHERE   DriverLocation.Avaliablity ='yes' and DriverId in (select inserted.driverid from inserted)
 end



