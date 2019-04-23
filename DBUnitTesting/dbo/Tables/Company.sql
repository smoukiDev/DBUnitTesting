CREATE TABLE [dbo].[Company] (
    [CompanyId]    NUMERIC (18)  IDENTITY (1, 1) NOT NULL,
    [CompanyName]  NVARCHAR (50) NULL,
    [IsActive]     BIT           CONSTRAINT [DF_Company_IsActive] DEFAULT ((0)) NOT NULL,
    [CreatedDate]  DATE          NOT NULL,
    [ModifiedDate] DATE          NULL,
    [CreatedBy]    NVARCHAR (50) NOT NULL,
    [ModifiedBy]   NVARCHAR (50) NULL,
    CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED ([CompanyId] ASC)
);

