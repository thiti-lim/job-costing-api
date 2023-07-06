if not exists (SELECT 1 FROM dbo.[customer]) 
begin 
	INSERT INTO dbo.[customer] (name, location, contact, phone_number) 
	VALUES
	('Quality Ceramic', 'Lampang', 'K. Maew', '0811111111'), 
	('Company B', 'Chiang Mai', 'K. Mah', '0822222222'), 
	('Company C', 'Bangkok', 'K. Moo', '0833333333'), 
	('Company D', 'Chiang Rai', 'K. Mee', '0844444444')
end