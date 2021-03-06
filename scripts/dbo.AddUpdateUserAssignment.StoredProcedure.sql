/****** Object:  StoredProcedure [dbo].[AddUpdateUserAssignment]    Script Date: 8/15/2019 3:23:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddUpdateUserAssignment]
	@UserID INT,
	@AssignmentID INT,
	@Assignment NVARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[UserAssignments]
	SET [Assignment] = @Assignment
		,[IsSubmitted] = 1
		,[SubmittedOn] = GETDATE()
	WHERE UserID = @UserID AND AssignmentID = @AssignmentID
END
GO
