Create procedure [dbo].[AddNewVehicle]  
(  
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
   Insert into Vehicle values(@FirstName,@LastName,@PhoneNumber,@UnitNumber,@AptNumber,@Make,@Model,@Color,@RegistrationNumber,@DOR)  
End