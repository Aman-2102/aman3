-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE InsertUserdetail
	-- Add the parameters for the stored procedure here
	@userid int,
	@UserName varchar(40),
	@GENDER VARCHAR(10),
@PickUpLocationId int,
@DropLocationId int,
@OPType varchar(5)
 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	end
	if( @userid=0)
	begin 
	insert into UserDetail values (@UserName ,
	@GENDER,
@PickUpLocationId,
@DropLocationId )
end
if(@OPType ='U')
begin
update UserDetail set UserName=@username,GENDER=@gender,PickUpLocationId=@PickUpLocationId,DropLocationId=@DropLocationId 
where userid=@userid
end
else 
begin
Delete UserDetail where UserId=@userid


end

GO
