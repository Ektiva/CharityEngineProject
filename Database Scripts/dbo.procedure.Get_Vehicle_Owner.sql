Create Procedure [dbo].[GetVehicleOwner]  
(  
   @RegistrationNumber int  
)
as  
begin  

   select FirstName, PhoneNumber, RegistrationNumber  from Vehicle where RegistrationNumber=@RegistrationNumber 

End