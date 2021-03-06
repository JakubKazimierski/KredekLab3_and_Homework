USE [WarehouseManagement]
GO
SET IDENTITY_INSERT [dbo].[Producer] ON 

INSERT [dbo].[Producer] ([ProducerId], [ProducerName]) VALUES (1, N'Asus')
INSERT [dbo].[Producer] ([ProducerId], [ProducerName]) VALUES (2, N'Archos')
SET IDENTITY_INSERT [dbo].[Producer] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductId], [ProductName], [ProducerId]) VALUES (1, N'ZenBook', 1)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProducerId]) VALUES (2, N'Vivobook', 1)
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (1, N'Client')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (2, N'Warehousman')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (3, N'Management')
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[UserLogin] ON 

INSERT [dbo].[UserLogin] ([UserId], [UserName], [Password], [RoleId]) VALUES (1, N'Adam', N'AD121518', 3)
INSERT [dbo].[UserLogin] ([UserId], [UserName], [Password], [RoleId]) VALUES (2, N'Alan', N'AL121518', 3)
INSERT [dbo].[UserLogin] ([UserId], [UserName], [Password], [RoleId]) VALUES (3, N'Aron', N'AR121518', 2)
INSERT [dbo].[UserLogin] ([UserId], [UserName], [Password], [RoleId]) VALUES (4, N'Bartosz', N'BA121518', 1)
INSERT [dbo].[UserLogin] ([UserId], [UserName], [Password], [RoleId]) VALUES (5, N'Bastian', N'BA121518', 2)
INSERT [dbo].[UserLogin] ([UserId], [UserName], [Password], [RoleId]) VALUES (6, N'Bruno', N'BR121518', 3)
INSERT [dbo].[UserLogin] ([UserId], [UserName], [Password], [RoleId]) VALUES (7, N'Eliasz', N'El151218', 2)
INSERT [dbo].[UserLogin] ([UserId], [UserName], [Password], [RoleId]) VALUES (8, N'Eryk', N'ER151218', 3)
INSERT [dbo].[UserLogin] ([UserId], [UserName], [Password], [RoleId]) VALUES (9, N'Feliks', N'FE151218', 1)
INSERT [dbo].[UserLogin] ([UserId], [UserName], [Password], [RoleId]) VALUES (10, N'Gustaw', N'GU151218', 2)
SET IDENTITY_INSERT [dbo].[UserLogin] OFF
SET IDENTITY_INSERT [dbo].[OrderProduct] ON 

INSERT [dbo].[OrderProduct] ([OrderId], [ClientId], [ProductId], [DataOrder]) VALUES (1, 1, 2, CAST(N'2019-12-03' AS Date))
SET IDENTITY_INSERT [dbo].[OrderProduct] OFF
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([ClientId], [Name], [Surname], [Address], [ZipCode], [City], [Country], [Email], [NumberPhone]) VALUES (1, N'Frederic', N'Mistral', N'Francja ', 55900, N'Paryż', N'Francja', N'Frederic@gmail.com', 999000349)
SET IDENTITY_INSERT [dbo].[Client] OFF
