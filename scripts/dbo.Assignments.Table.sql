/****** Object:  Table [dbo].[Assignments]    Script Date: 8/15/2019 3:23:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assignments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Instructions] [nvarchar](max) NULL,
	[Attachment] [nvarchar](max) NULL,
	[DueDate] [nvarchar](250) NOT NULL,
	[CASClassId] [int] NULL,
	[ClassID] [int] NOT NULL,
	[AddedOn] [nvarchar](50) NULL,
 CONSTRAINT [PK_Assignments] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Assignments] ON 

INSERT [dbo].[Assignments] ([ID], [Title], [Instructions], [Attachment], [DueDate], [CASClassId], [ClassID], [AddedOn]) VALUES (1, N'Assignment 1', N'Follow the following instruction.

"On the other hand, we denounce with righteous indignation and dislike men who are so beguiled and demoralized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided. But in certain circumstances and owing to the claims of duty or the obligations of business it will frequently occur that pleasures have to be repudiated and annoyances accepted. The wise man therefore always holds in these matters to this principle of selection: he rejects pleasures to secure other greater pleasures, or else he endures pains to avoid worse pains."', N'wwwroot\uploads\files\Assignment-1.pdf', N'2019-05-06T18:14:06.000Z', NULL, 1, N'May  2 2019  7:52AM')
SET IDENTITY_INSERT [dbo].[Assignments] OFF
ALTER TABLE [dbo].[Assignments] ADD  CONSTRAINT [DF__Assignmen__Class__534D60F1]  DEFAULT ((0)) FOR [ClassID]
GO
ALTER TABLE [dbo].[Assignments] ADD  CONSTRAINT [DF_Assignments_AddedOn]  DEFAULT (getdate()) FOR [AddedOn]
GO
