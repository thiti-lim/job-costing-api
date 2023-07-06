CREATE PROCEDURE [dbo].[p_customer_update]
	@id INT, 
	@name NVARCHAR(50), 
	@location NVARCHAR(50), 
	@contact NVARCHAR(50), 
	@phone_number NVARCHAR(50) 
AS
begin
	UPDATE dbo.[customer] SET
	name = @name, location = @location, contact = @contact, phone_number = @phone_number 
	WHERE id = @id; 
end
