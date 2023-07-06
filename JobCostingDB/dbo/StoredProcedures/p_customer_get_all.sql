CREATE PROCEDURE [dbo].[p_customer_get_all]
AS
begin 
	SELECT id, name, location, contact, phone_number  FROM dbo.[customer];
end 
