CREATE PROCEDURE [dbo].[p_customer_insert]
	@name NVARCHAR(50), 
	@location NVARCHAR(50), 
	@contact NVARCHAR(50), 
	@phone_number NVARCHAR(50) 
AS
begin
	INSERT INTO dbo.[customer] (name, location, contact, phone_number) VALUES (@name, @location, @contact, @phone_number); 
end
