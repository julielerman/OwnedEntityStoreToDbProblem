This solution has a webapi project, a domain test project an a data model test project.

The web api has a samurai class. One of its properties is SecreteIdentity, which is of PersonName type. PersonName does not have an ID property.

the context maps the SecretIdentity property as an owned entity of Samurai.

In the DataModel tests, there are 4 InMemory tests and one that points to sql server. You may want to change it's connection string.

Two of the in memory tests are to see if I can create a samurai WITHOUT a secretidentity and WITH a secret identity. Both pass.

The SQLDB test, is a copy of the inmemory test that inserts a samurai WITH a secretidentity.

The SQLDB test throws on the insert, saying that secret identity needs an ID value.

System.InvalidOperationException : The entity of 'Samurai' is sharing the table 'Samurais' with 'Samurai.SecretIdentity#PersonName', but there is no entity of this type with the same key value that has been marked as 'Added'.

The database schema is generated correctly.

CREATE TABLE [dbo].[Samurais](  
	[Id] [int] IDENTITY(1,1) NOT NULL,  
	[Name] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,  
	[SecretIdentity_First] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,  
	[SecretIdentity_Last] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
  ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]