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
    CONSTRAINT [FK_SubDepartment_Department] FOREIGN KEY ([DepartmentId]) REFERENCES [dbo].[Department] ([DepartmentId]) ON DELETE CASCADE
);




GO
CREATE TRIGGER [dbo].[SubDepartment_Update] ON [dbo].[SubDepartment]
For update
AS
BEGIN
       
     declare @SubDepartmentId numeric(18,0)
	 , @subDepartmentName nvarchar(50)
	 , @DepartmentId numeric(18,0)
	 , @IsActive bit
	 , @createddate date
	 , @modifieddate date
	 , @createdby nvarchar(50)
	 , @modifiedby nvarchar(50)

	 select @SubDepartmentId=i.SubDepartmentId from inserted i; 
	 select @subDepartmentName=i.subDepartmentName from inserted i;
     select @DepartmentId=i.DepartmentId from inserted i; 
	 select @IsActive=i.IsActive from inserted i; 
	 select @createddate=i.createddate from inserted i;
     select @modifieddate=i.modifieddate from inserted i; 
	 select @createdby=i.CreatedBy from inserted i; 
	 select @modifiedby=i.ModifiedBy from inserted i;
     
	 insert into [dbo].[SubDepartmentLog] values (@SubDepartmentId, @subDepartmentName,@DepartmentId, @IsActive,
	 @createddate, @modifieddate, @createdby, @modifiedby )

END