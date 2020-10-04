Create procedure [dbo].[UpdateVehicleDetails]  
(  
   @VehicleId int, 
   @FirstName nvarchar (50), 
   @LastName nvarchar (50),
   @PhoneNumber nvarchar (50),  
   @UnitNumber int,
   @AptNumber int,
   @Make nvarchar (50), 
   @Model nvarchar (50),
   @Color nvarchar (50),  
   @RegistrationNumber int,
   @DOR datetime
)  
as  
begin  
   Update Vehicle   
   set FirstName=@FirstName, 
   LastName=@LastName,
   PhoneNumber=@PhoneNumber,  
   UnitNumber=@UnitNumber,
   AptNumber=@AptNumber,
   Make=@Make, 
   Model=@Model,
   Color=@Color,  
   RegistrationNumber=@RegistrationNumber,
   DOR=@DOR
   where Id=@VehicleId  
End