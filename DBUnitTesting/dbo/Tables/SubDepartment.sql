CREATE TABLE [dbo].[SubDepartment] (
    [SubDepartmentId]   NUMERIC (18)  IDENTITY (1, 1) NOT NULL,
    [SubDepartmentName] NVARCHAR (50) NOT NULL,
    [DepartmentId]      NUMERIC (18)  NOT NULL,
    [IsActive]          BIT           CONSTRAINT [DF_Employee_IsActive] DEFAULT ((0)) NOT NULL,
    [CreatedDate]       DATE          NOT NULL,
    [ModifiedDate]      DATE          NULL,
    [CreatedBy]         NVARCHAR (50) NOT NULL,
    [ModifiedBy]        NVARCHAR (50) NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED ([SubDepartmentId] ASC),
    CONSTRAINT [FK_SubDepartment_Department] FOREIGN KEY ([DepartmentId]) REFERENCES [dbo].[Department] ([DepartmentId])
);

