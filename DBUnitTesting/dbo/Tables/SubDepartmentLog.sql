CREATE TABLE [dbo].[SubDepartmentLog] (
    [SubDepartmentLogId] NUMERIC (18)  IDENTITY (1, 1) NOT NULL,
    [SubDepartmentId]    NUMERIC (18)  NULL,
    [SubDepartmentName]  NVARCHAR (50) NULL,
    [DepartmentId]       NUMERIC (18)  NULL,
    [IsActive]           BIT           NULL,
    [CreatedDate]        DATE          NULL,
    [ModifiedDate]       DATE          NULL,
    [CreatedBy]          NVARCHAR (50) NULL,
    [ModifiedBy]         NVARCHAR (50) NULL,
    CONSTRAINT [PK_SubDepartmentLog] PRIMARY KEY CLUSTERED ([SubDepartmentLogId] ASC)
);

