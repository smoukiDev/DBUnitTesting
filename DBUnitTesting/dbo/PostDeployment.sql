/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

/*********** Populate Company*****************/
INSERT INTO [dbo].[Company] ([CompanyName],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('Gaja Digital Agency',1,getdate(),NULL,'System',NULL);
INSERT INTO [dbo].[Company] ([CompanyName],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('Palmex',1,getdate(),NULL,'System',NULL);
INSERT INTO [dbo].[Company] ([CompanyName],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('Arsha Consulting',1,getdate(),NULL,'System',NULL);
INSERT INTO [dbo].[Company] ([CompanyName],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('Toboc',1,getdate(),NULL,'System',NULL);

/*********** Populate Department*****************/
INSERT INTO [dbo].[Department] ([DepartmentName],[CompanyId],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('Software Development',1,1,getdate(),NULL,'System',NULL);
INSERT INTO [dbo].[Department] ([DepartmentName],[CompanyId],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('Application Maintenance',1,1,getdate(),NULL,'System',NULL);
INSERT INTO [dbo].[Department] ([DepartmentName],[CompanyId],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('Sales & Marketing',2,1,getdate(),NULL,'System',NULL);
INSERT INTO [dbo].[Department] ([DepartmentName],[CompanyId],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('Consulting',3,1,getdate(),NULL,'System',NULL);
INSERT INTO [dbo].[Department] ([DepartmentName],[CompanyId],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('Management',4,1,getdate(),NULL,'System',NULL);
INSERT INTO [dbo].[Department] ([DepartmentName],[CompanyId],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('Toboc Deals',4,1,getdate(),NULL,'System',NULL);

/*********** Populate SubDepartment*****************/
INSERT INTO [dbo].[SubDepartment] ([SubDepartmentName],[DepartmentId],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('Dotnet',1,1,getdate(),NULL,'System',NULL);
INSERT INTO [dbo].[SubDepartment] ([SubDepartmentName],[DepartmentId],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('Nopcommerce',1,1,getdate(),NULL,'System',NULL);
INSERT INTO [dbo].[SubDepartment] ([SubDepartmentName],[DepartmentId],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('Umbraco',2,1,getdate(),NULL,'System',NULL);
INSERT INTO [dbo].[SubDepartment] ([SubDepartmentName],[DepartmentId],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('Palmex Commercial',3,1,getdate(),NULL,'System',NULL);
INSERT INTO [dbo].[SubDepartment] ([SubDepartmentName],[DepartmentId],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('Palmex Individual',3,1,getdate(),NULL,'System',NULL);
INSERT INTO [dbo].[SubDepartment] ([SubDepartmentName],[DepartmentId],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('Business Consultation',4,1,getdate(),NULL,'System',NULL);
INSERT INTO [dbo].[SubDepartment] ([SubDepartmentName],[DepartmentId],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('HR',5,1,getdate(),NULL,'System',NULL);
INSERT INTO [dbo].[SubDepartment] ([SubDepartmentName],[DepartmentId],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('Finance',5,1,getdate(),NULL,'System',NULL);
INSERT INTO [dbo].[SubDepartment] ([SubDepartmentName],[DepartmentId],[IsActive],[CreatedDate],[ModifiedDate],[CreatedBy],[ModifiedBy]) VALUES('Toboc Deals Website',6,1,getdate(),NULL,'System',NULL);