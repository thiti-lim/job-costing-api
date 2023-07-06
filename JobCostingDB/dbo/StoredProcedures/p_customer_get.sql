CREATE PROCEDURE [dbo].[p_customer_get]
	@id int 
AS
begin
	SELECT id, name, location, contact, phone_number FROM dbo.[customer] WHERE id = @id; 
end
