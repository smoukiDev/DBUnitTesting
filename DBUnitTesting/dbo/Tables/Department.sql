CREATE TABLE [dbo].[Department] (
    [DepartmentId]   NUMERIC (18)  IDENTITY (1, 1) NOT NULL,
    [DepartmentName] NVARCHAR (50) NOT NULL,
    [CompanyId]      NUMERIC (18)  NOT NULL,
    [IsActive]       BIT           CONSTRAINT [DF_Deaprtment_IsActive] DEFAULT ((0)) NOT NULL,
    [CreatedDate]    DATE          NOT NULL,
    [ModifiedDate]   DATE          NULL,
    [CreatedBy]      NVARCHAR (50) NOT NULL,
    [ModifiedBy]     NVARCHAR (50) NULL,
    CONSTRAINT [PK_Deaprtment] PRIMARY KEY CLUSTERED ([DepartmentId] ASC),
    CONSTRAINT [FK_Department_Company] FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Company] ([CompanyId]) ON DELETE CASCADE
);

