 BEGIN TRY
  	IF  NOT EXISTS (SELECT 1 FROM [NeriumUP].[CapturePageTagInfo] WHERE [Key] = 'US-EN-US'
  			and [CapturePageName] = 'NewProductInterest')
  		BEGIN

  				Insert into [NeriumUP].[CapturePageTagInfo]
				([Key],
				[CapturePageName],
				[TagName],
				[TagId],
 				[MarketingListName],
				[MarketingListId],
				[ModifiedBy],
				[ModifiedDate],
				[CreatedBy],
				[CreatedDate])
 				values
				('US-EN-US',
				'NewProductInterest',
				'New Product Interest',
				'',
				N'US-ENG-NEW-PRODUCT',
				'9a9cad81-33a5-e611-80ed-5065f38a19e1',
				 null,
				 null,
				 'US6196',
				 getdate())
 				PRINT 'CapturePageTagInfo with key ''US-EN-US'' and capture ''New Product Interest'' is inserted successfully...'; 
 		END
 		ELSE
 		PRINT 'CapturePageTagInfo with key ''US-EN-US''  and capture ''New Product Interest'' is already exists!!' 

 	IF  NOT EXISTS (SELECT 1 FROM [NeriumUP].[CapturePageTagInfo] WHERE [Key] = 'MX-EN-US'
  			and [CapturePageName] = 'NewProductInterest')
  		BEGIN

  				Insert into [NeriumUP].[CapturePageTagInfo]
				([Key],
				[CapturePageName],
				[TagName],
				[TagId],
 				[MarketingListName],
				[MarketingListId],
				[ModifiedBy],
				[ModifiedDate],
				[CreatedBy],
				[CreatedDate])
 				values
				('MX-EN-US',
				'NewProductInterest',
				'New Product Interest',
				'',
				N'US-ENG-NEW-PRODUCT',
				'9a9cad81-33a5-e611-80ed-5065f38a19e1',
				 null,
				 null,
				 'US6196',
				 getdate())
 				PRINT 'CapturePageTagInfo with key ''MX-EN-US'' and capture ''New Product Interest'' is inserted successfully...'; 
 		END
 		ELSE
 		PRINT 'CapturePageTagInfo with key ''MX-EN-US''  and capture ''New Product Interest'' is already exists!!' 

 	IF  NOT EXISTS (SELECT 1 FROM [NeriumUP].[CapturePageTagInfo] WHERE [Key] = 'CA-EN-US'
  			and [CapturePageName] = 'NewProductInterest')
  		BEGIN

  				Insert into [NeriumUP].[CapturePageTagInfo]
				([Key],
				[CapturePageName],
				[TagName],
				[TagId],
 				[MarketingListName],
				[MarketingListId],
				[ModifiedBy],
				[ModifiedDate],
				[CreatedBy],
				[CreatedDate])
 				values
				('CA-EN-US',
				'NewProductInterest',
				'New Product Interest',
				'',
				N'US-ENG-NEW-PRODUCT',
				'9a9cad81-33a5-e611-80ed-5065f38a19e1',
				 null,
				 null,
				 'US6196',
				 getdate())
 				PRINT 'CapturePageTagInfo with key ''CA-EN-US'' and capture ''New Product Interest'' is inserted successfully...'; 
 		END
 		ELSE
 		PRINT 'CapturePageTagInfo with key ''CA-EN-US''  and capture ''New Product Interest'' is already exists!!' 

 	IF  NOT EXISTS (SELECT 1 FROM [NeriumUP].[CapturePageTagInfo] WHERE [Key] = 'JP-EN-US'
  			and [CapturePageName] = 'NewProductInterest')
  		BEGIN

  				Insert into [NeriumUP].[CapturePageTagInfo]
				([Key],
				[CapturePageName],
				[TagName],
				[TagId],
 				[MarketingListName],
				[MarketingListId],
				[ModifiedBy],
				[ModifiedDate],
				[CreatedBy],
				[CreatedDate])
 				values
				('JP-EN-US',
				'NewProductInterest',
				'New Product Interest',
				'',
				N'US-ENG-NEW-PRODUCT',
				'9a9cad81-33a5-e611-80ed-5065f38a19e1',
				 null,
				 null,
				 'US6196',
				 getdate())
 				PRINT 'CapturePageTagInfo with key ''JP-EN-US'' and capture ''New Product Interest'' is inserted successfully...'; 
 		END
 		ELSE
 		PRINT 'CapturePageTagInfo with key ''JP-EN-US''  and capture ''New Product Interest'' is already exists!!' 

 	IF  NOT EXISTS (SELECT 1 FROM [NeriumUP].[CapturePageTagInfo] WHERE [Key] = 'HK-EN-US'
  			and [CapturePageName] = 'NewProductInterest')
  		BEGIN

  				Insert into [NeriumUP].[CapturePageTagInfo]
				([Key],
				[CapturePageName],
				[TagName],
				[TagId],
 				[MarketingListName],
				[MarketingListId],
				[ModifiedBy],
				[ModifiedDate],
				[CreatedBy],
				[CreatedDate])
 				values
				('HK-EN-US',
				'NewProductInterest',
				'New Product Interest',
				'',
				N'US-ENG-NEW-PRODUCT',
				'9a9cad81-33a5-e611-80ed-5065f38a19e1',
				 null,
				 null,
				 'US6196',
				 getdate())
 				PRINT 'CapturePageTagInfo with key ''HK-EN-US'' and capture ''New Product Interest'' is inserted successfully...'; 
 		END
 		ELSE
 		PRINT 'CapturePageTagInfo with key ''HK-EN-US''  and capture ''New Product Interest'' is already exists!!' 

 	IF  NOT EXISTS (SELECT 1 FROM [NeriumUP].[CapturePageTagInfo] WHERE [Key] = 'AU-EN-US'
  			and [CapturePageName] = 'NewProductInterest')
  		BEGIN

  				Insert into [NeriumUP].[CapturePageTagInfo]
				([Key],
				[CapturePageName],
				[TagName],
				[TagId],
 				[MarketingListName],
				[MarketingListId],
				[ModifiedBy],
				[ModifiedDate],
				[CreatedBy],
				[CreatedDate])
 				values
				('AU-EN-US',
				'NewProductInterest',
				'New Product Interest',
				'',
				N'US-ENG-NEW-PRODUCT',
				'9a9cad81-33a5-e611-80ed-5065f38a19e1',
				 null,
				 null,
				 'US6196',
				 getdate())
 				PRINT 'CapturePageTagInfo with key ''AU-EN-US'' and capture ''New Product Interest'' is inserted successfully...'; 
 		END
 		ELSE
 		PRINT 'CapturePageTagInfo with key ''AU-EN-US''  and capture ''New Product Interest'' is already exists!!' 

 	IF  NOT EXISTS (SELECT 1 FROM [NeriumUP].[CapturePageTagInfo] WHERE [Key] = 'KR-EN-US'
  			and [CapturePageName] = 'NewProductInterest')
  		BEGIN

  				Insert into [NeriumUP].[CapturePageTagInfo]
				([Key],
				[CapturePageName],
				[TagName],
				[TagId],
 				[MarketingListName],
				[MarketingListId],
				[ModifiedBy],
				[ModifiedDate],
				[CreatedBy],
				[CreatedDate])
 				values
				('KR-EN-US',
				'NewProductInterest',
				'New Product Interest',
				'',
				N'US-ENG-NEW-PRODUCT',
				'9a9cad81-33a5-e611-80ed-5065f38a19e1',
				 null,
				 null,
				 'US6196',
				 getdate())
 				PRINT 'CapturePageTagInfo with key ''KR-EN-US'' and capture ''New Product Interest'' is inserted successfully...'; 
 		END
 		ELSE
 		PRINT 'CapturePageTagInfo with key ''KR-EN-US''  and capture ''New Product Interest'' is already exists!!' 

 	IF  NOT EXISTS (SELECT 1 FROM [NeriumUP].[CapturePageTagInfo] WHERE [Key] = 'US-ES-US'
  			and [CapturePageName] = 'NewProductInterest')
  		BEGIN

  				Insert into [NeriumUP].[CapturePageTagInfo]
				([Key],
				[CapturePageName],
				[TagName],
				[TagId],
 				[MarketingListName],
				[MarketingListId],
				[ModifiedBy],
				[ModifiedDate],
				[CreatedBy],
				[CreatedDate])
 				values
				('US-ES-US',
				'NewProductInterest',
				'New Product Interest',
				'',
				N'US-SPA-NEW-PRODUCT',
				'71339b93-33a5-e611-80ed-5065f38a19e1',
				 null,
				 null,
				 'US6196',
				 getdate())
 				PRINT 'CapturePageTagInfo with key ''US-ES-US'' and capture ''New Product Interest'' is inserted successfully...'; 
 		END
 		ELSE
 		PRINT 'CapturePageTagInfo with key ''US-ES-US''  and capture ''New Product Interest'' is already exists!!' 

 	IF  NOT EXISTS (SELECT 1 FROM [NeriumUP].[CapturePageTagInfo] WHERE [Key] = 'MX-ES-US'
  			and [CapturePageName] = 'NewProductInterest')
  		BEGIN

  				Insert into [NeriumUP].[CapturePageTagInfo]
				([Key],
				[CapturePageName],
				[TagName],
				[TagId],
 				[MarketingListName],
				[MarketingListId],
				[ModifiedBy],
				[ModifiedDate],
				[CreatedBy],
				[CreatedDate])
 				values
				('MX-ES-US',
				'NewProductInterest',
				'New Product Interest',
				'',
				N'US-SPA-NEW-PRODUCT',
				'71339b93-33a5-e611-80ed-5065f38a19e1',
				 null,
				 null,
				 'US6196',
				 getdate())
 				PRINT 'CapturePageTagInfo with key ''MX-ES-US'' and capture ''New Product Interest'' is inserted successfully...'; 
 		END
 		ELSE
 		PRINT 'CapturePageTagInfo with key ''MX-ES-US''  and capture ''New Product Interest'' is already exists!!' 

 	IF  NOT EXISTS (SELECT 1 FROM [NeriumUP].[CapturePageTagInfo] WHERE [Key] = 'CA-ES-US'
  			and [CapturePageName] = 'NewProductInterest')
  		BEGIN

  				Insert into [NeriumUP].[CapturePageTagInfo]
				([Key],
				[CapturePageName],
				[TagName],
				[TagId],
 				[MarketingListName],
				[MarketingListId],
				[ModifiedBy],
				[ModifiedDate],
				[CreatedBy],
				[CreatedDate])
 				values
				('CA-ES-US',
				'NewProductInterest',
				'New Product Interest',
				'',
				N'US-SPA-NEW-PRODUCT',
				'71339b93-33a5-e611-80ed-5065f38a19e1',
				 null,
				 null,
				 'US6196',
				 getdate())
 				PRINT 'CapturePageTagInfo with key ''CA-ES-US'' and capture ''New Product Interest'' is inserted successfully...'; 
 		END
 		ELSE
 		PRINT 'CapturePageTagInfo with key ''CA-ES-US''  and capture ''New Product Interest'' is already exists!!' 

 	IF  NOT EXISTS (SELECT 1 FROM [NeriumUP].[CapturePageTagInfo] WHERE [Key] = 'JP-ES-US'
  			and [CapturePageName] = 'NewProductInterest')
  		BEGIN

  				Insert into [NeriumUP].[CapturePageTagInfo]
				([Key],
				[CapturePageName],
				[TagName],
				[TagId],
 				[MarketingListName],
				[MarketingListId],
				[ModifiedBy],
				[ModifiedDate],
				[CreatedBy],
				[CreatedDate])
 				values
				('JP-ES-US',
				'NewProductInterest',
				'New Product Interest',
				'',
				N'US-SPA-NEW-PRODUCT',
				'71339b93-33a5-e611-80ed-5065f38a19e1',
				 null,
				 null,
				 'US6196',
				 getdate())
 				PRINT 'CapturePageTagInfo with key ''JP-ES-US'' and capture ''New Product Interest'' is inserted successfully...'; 
 		END
 		ELSE
 		PRINT 'CapturePageTagInfo with key ''JP-ES-US''  and capture ''New Product Interest'' is already exists!!' 

 	IF  NOT EXISTS (SELECT 1 FROM [NeriumUP].[CapturePageTagInfo] WHERE [Key] = 'HK-ES-US'
  			and [CapturePageName] = 'NewProductInterest')
  		BEGIN

  				Insert into [NeriumUP].[CapturePageTagInfo]
				([Key],
				[CapturePageName],
				[TagName],
				[TagId],
 				[MarketingListName],
				[MarketingListId],
				[ModifiedBy],
				[ModifiedDate],
				[CreatedBy],
				[CreatedDate])
 				values
				('HK-ES-US',
				'NewProductInterest',
				'New Product Interest',
				'',
				N'US-SPA-NEW-PRODUCT',
				'71339b93-33a5-e611-80ed-5065f38a19e1',
				 null,
				 null,
				 'US6196',
				 getdate())
 				PRINT 'CapturePageTagInfo with key ''HK-ES-US'' and capture ''New Product Interest'' is inserted successfully...'; 
 		END
 		ELSE
 		PRINT 'CapturePageTagInfo with key ''HK-ES-US''  and capture ''New Product Interest'' is already exists!!' 

 	IF  NOT EXISTS (SELECT 1 FROM [NeriumUP].[CapturePageTagInfo] WHERE [Key] = 'AU-ES-US'
  			and [CapturePageName] = 'NewProductInterest')
  		BEGIN

  				Insert into [NeriumUP].[CapturePageTagInfo]
				([Key],
				[CapturePageName],
				[TagName],
				[TagId],
 				[MarketingListName],
				[MarketingListId],
				[ModifiedBy],
				[ModifiedDate],
				[CreatedBy],
				[CreatedDate])
 				values
				('AU-ES-US',
				'NewProductInterest',
				'New Product Interest',
				'',
				N'US-SPA-NEW-PRODUCT',
				'71339b93-33a5-e611-80ed-5065f38a19e1',
				 null,
				 null,
				 'US6196',
				 getdate())
 				PRINT 'CapturePageTagInfo with key ''AU-ES-US'' and capture ''New Product Interest'' is inserted successfully...'; 
 		END
 		ELSE
 		PRINT 'CapturePageTagInfo with key ''AU-ES-US''  and capture ''New Product Interest'' is already exists!!' 

 	IF  NOT EXISTS (SELECT 1 FROM [NeriumUP].[CapturePageTagInfo] WHERE [Key] = 'KR-ES-US'
  			and [CapturePageName] = 'NewProductInterest')
  		BEGIN

  				Insert into [NeriumUP].[CapturePageTagInfo]
				([Key],
				[CapturePageName],
				[TagName],
				[TagId],
 				[MarketingListName],
				[MarketingListId],
				[ModifiedBy],
				[ModifiedDate],
				[CreatedBy],
				[CreatedDate])
 				values
				('KR-ES-US',
				'NewProductInterest',
				'New Product Interest',
				'',
				N'US-SPA-NEW-PRODUCT',
				'71339b93-33a5-e611-80ed-5065f38a19e1',
				 null,
				 null,
				 'US6196',
				 getdate())
 				PRINT 'CapturePageTagInfo with key ''KR-ES-US'' and capture ''New Product Interest'' is inserted successfully...'; 
 		END
 		ELSE
 		PRINT 'CapturePageTagInfo with key ''KR-ES-US''  and capture ''New Product Interest'' is already exists!!' 

END TRY
 BEGIN CATCH
 	PRINT 'In CATCH Block'
 	SELECT ERROR_MESSAGE() AS ErrorMessage;
 END CATCH;
