
USE RESTAURANTE
GO
/****** Object:  Table dbo.ItemMenu    Script Date: 23/03/2023 10:31:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE dbo.ItemMenu(
	IdMenu int IDENTITY(1,1) NOT NULL,
	Nombre nvarchar(50) NULL,
	Categoria nvarchar(50) NULL,
	Imagen nvarchar(150) NULL,
	Precio decimal(10, 2) NULL,
 CONSTRAINT PK_ItemMenu PRIMARY KEY CLUSTERED 
(
	IdMenu ASC
))

GO
/****** Object:  Table dbo.Mesa    Script Date: 23/03/2023 10:31:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE dbo.Mesa(
	IdMesa int IDENTITY(1,1) NOT NULL,
	Estado varchar(50) NULL,
	Numero int NULL,
	Cantidad int NULL,
 CONSTRAINT PK_Mesa PRIMARY KEY CLUSTERED 
(
	IdMesa ASC
))

GO
/****** Object:  Table dbo.Pedido    Script Date: 23/03/2023 10:31:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE dbo.Pedido(
	IdPedido int IDENTITY(1,1) NOT NULL,
	Total decimal(10, 2) NULL,
	Fecha datetime NULL,
	ItemsMenu varchar(50) NULL,
	IdMesa int NULL,
	IdMenu int NULL,
 CONSTRAINT PK_Pedido PRIMARY KEY CLUSTERED 
(
	IdPedido ASC
))

GO
SET IDENTITY_INSERT dbo.ItemMenu ON 

INSERT dbo.ItemMenu (IdMenu, Nombre, Categoria, Imagen, Precio) VALUES (7, N'Arroz 3 Delicias', N'arroz', N'https://i.pinimg.com/564x/e2/ed/7e/e2ed7ed9df0ddf129b66992b18207228.jpg', CAST(2.00 AS Decimal(10, 2)))
INSERT dbo.ItemMenu (IdMenu, Nombre, Categoria, Imagen, Precio) VALUES (8, N'Arroz 3 Delicias', N'arroz', N'https://i.pinimg.com/564x/e2/ed/7e/e2ed7ed9df0ddf129b66992b18207228.jpg', CAST(2.00 AS Decimal(10, 2)))
INSERT dbo.ItemMenu (IdMenu, Nombre, Categoria, Imagen, Precio) VALUES (9, N'x', N'x', N'x', CAST(4499.00 AS Decimal(10, 2)))
INSERT dbo.ItemMenu (IdMenu, Nombre, Categoria, Imagen, Precio) VALUES (10, N'd', N'd', N'd', CAST(2203.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT dbo.ItemMenu OFF
GO
SET IDENTITY_INSERT dbo.Mesa ON 

INSERT dbo.Mesa (IdMesa, Estado, Numero, Cantidad) VALUES (1, N'Ocupado', 3, 2)
INSERT dbo.Mesa (IdMesa, Estado, Numero, Cantidad) VALUES (2, N'Libre', 6, 6)
SET IDENTITY_INSERT dbo.Mesa OFF
GO
SET IDENTITY_INSERT dbo.Pedido ON 

INSERT dbo.Pedido (IdPedido, Total, Fecha, ItemsMenu, IdMesa, IdMenu) VALUES (1146, CAST(200.00 AS Decimal(10, 2)), CAST(N'2023-03-23T10:08:40.127' AS DateTime), N'Arroz 3 Delicias', 3, 8)
INSERT dbo.Pedido (IdPedido, Total, Fecha, ItemsMenu, IdMesa, IdMenu) VALUES (1147, CAST(449900.00 AS Decimal(10, 2)), CAST(N'2023-03-23T10:11:33.283' AS DateTime), N'x', 2, 9)
INSERT dbo.Pedido (IdPedido, Total, Fecha, ItemsMenu, IdMesa, IdMenu) VALUES (1148, CAST(200.00 AS Decimal(10, 2)), CAST(N'2023-03-23T10:13:14.117' AS DateTime), N'Arroz 3 Delicias', 0, 7)
INSERT dbo.Pedido (IdPedido, Total, Fecha, ItemsMenu, IdMesa, IdMenu) VALUES (1149, CAST(200.00 AS Decimal(10, 2)), CAST(N'2023-03-23T10:14:42.387' AS DateTime), N'Arroz 3 Delicias', 0, 8)
INSERT dbo.Pedido (IdPedido, Total, Fecha, ItemsMenu, IdMesa, IdMenu) VALUES (1150, CAST(449900.00 AS Decimal(10, 2)), CAST(N'2023-03-23T10:14:53.367' AS DateTime), N'x', 0, 9)
INSERT dbo.Pedido (IdPedido, Total, Fecha, ItemsMenu, IdMesa, IdMenu) VALUES (1151, CAST(200.00 AS Decimal(10, 2)), CAST(N'2023-03-23T10:19:23.010' AS DateTime), N'Arroz 3 Delicias', 0, 8)
INSERT dbo.Pedido (IdPedido, Total, Fecha, ItemsMenu, IdMesa, IdMenu) VALUES (1153, CAST(200.00 AS Decimal(10, 2)), CAST(N'2023-03-23T10:21:25.720' AS DateTime), N'Arroz 3 Delicias', 1, 8)
INSERT dbo.Pedido (IdPedido, Total, Fecha, ItemsMenu, IdMesa, IdMenu) VALUES (1154, CAST(449900.00 AS Decimal(10, 2)), CAST(N'2023-03-23T10:21:58.887' AS DateTime), N'x', 2, 9)
INSERT dbo.Pedido (IdPedido, Total, Fecha, ItemsMenu, IdMesa, IdMenu) VALUES (1155, CAST(200.00 AS Decimal(10, 2)), CAST(N'2023-03-23T10:22:16.127' AS DateTime), N'Arroz 3 Delicias', 0, 8)
INSERT dbo.Pedido (IdPedido, Total, Fecha, ItemsMenu, IdMesa, IdMenu) VALUES (1156, CAST(220300.00 AS Decimal(10, 2)), CAST(N'2023-03-23T10:25:52.023' AS DateTime), N'd', 2, 10)
INSERT dbo.Pedido (IdPedido, Total, Fecha, ItemsMenu, IdMesa, IdMenu) VALUES (1157, CAST(200.00 AS Decimal(10, 2)), CAST(N'2023-03-23T10:26:04.447' AS DateTime), N'Arroz 3 Delicias', 0, 7)
SET IDENTITY_INSERT dbo.Pedido OFF
GO
