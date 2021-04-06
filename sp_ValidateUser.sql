-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE sp_ValidateUser
	-- Add the parameters for the stored procedure here
	@username nvarchar(20),
	@pwd nvarchar(20),
	@status bit output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @uname nvarchar(20)
	declare @upwd nvarchar(20)
    -- Insert statements for procedure here
	SELECT @uname=username,@upwd=pwd from Users
	where username=@username
	if(@uname=@username and @upwd=@pwd) 
	begin
	set @status=0
	end
	else	
	begin
	set @status=1
	end
END
GO
