/****** Object:  Table [dbo].[UserClasses]    Script Date: 8/15/2019 3:23:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserClasses](
	[UserClassID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[ClassID] [int] NOT NULL,
 CONSTRAINT [PK_UserClasses] PRIMARY KEY CLUSTERED 
(
	[UserClassID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UserClasses] ON 

INSERT [dbo].[UserClasses] ([UserClassID], [UserID], [ClassID]) VALUES (1, 3, 1)
INSERT [dbo].[UserClasses] ([UserClassID], [UserID], [ClassID]) VALUES (2, 3, 1)
INSERT [dbo].[UserClasses] ([UserClassID], [UserID], [ClassID]) VALUES (3, 4, 1)
SET IDENTITY_INSERT [dbo].[UserClasses] OFF
