CREATE PROCEDURE [dbo].[p_customer_delete]
	@id int 
AS
begin
	DELETE FROM dbo.[customer] WHERE id = @id; 
end
