Create procedure [dbo].[DeleteVehicle]  
(  
   @VehicleId int  
)  
as   
begin  
   Delete from Vehicle where Id=@VehicleId  
End