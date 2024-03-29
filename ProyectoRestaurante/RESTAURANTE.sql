
CREATE TABLE ItemMenu(
	IdMenu int IDENTITY(1,1) NOT NULL,
	Nombre nvarchar(50) NULL,
	Categoria nvarchar(50) NULL,
	Imagen nvarchar(150) NULL,
	Precio decimal(10, 2) NULL,
 CONSTRAINT PK_ItemMenu PRIMARY KEY CLUSTERED 
(
	IdMenu ASC
)
)
GO
/****** Object:  Table Mesa    Script Date: 27/03/2023 9:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Mesa(
	IdMesa int IDENTITY(1,1) NOT NULL,
	Estado varchar(50) NULL,
	Cantidad int NULL,
 CONSTRAINT PK_Mesa PRIMARY KEY CLUSTERED 
(
	IdMesa ASC
)
)
GO
/****** Object:  Table Pedido    Script Date: 27/03/2023 9:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Pedido(
	IdPedido int IDENTITY(1,1) NOT NULL,
	Precio decimal(10, 2) NULL,
	Fecha datetime NULL,
	ItemsMenu varchar(50) NULL,
	IdMesa int NULL,
	IdMenu int NULL,
	Cantidad int NULL,
 CONSTRAINT PK_Pedido PRIMARY KEY CLUSTERED 
(
	IdPedido ASC
)
)
GO
SET IDENTITY_INSERT ItemMenu ON 

INSERT ItemMenu (IdMenu, Nombre, Categoria, Imagen, Precio) VALUES (30, N'Arroz 3 Delicias', N'Arroz', N'arroz3delicias.jpg', CAST(3.50 AS Decimal(10, 2)))
INSERT ItemMenu (IdMenu, Nombre, Categoria, Imagen, Precio) VALUES (31, N'Sopa Marisco', N'Sopa', N'sopaMarisco.jpg', CAST(4.50 AS Decimal(10, 2)))
INSERT ItemMenu (IdMenu, Nombre, Categoria, Imagen, Precio) VALUES (32, N'ku bak tres delicias', N'Arroz', N'kubak.jpg', CAST(6.50 AS Decimal(10, 2)))
INSERT ItemMenu (IdMenu, Nombre, Categoria, Imagen, Precio) VALUES (33, N'Gambas con Champiñones', N'Marisco', N'gambaschampinion.jpg', CAST(5.00 AS Decimal(10, 2)))
INSERT ItemMenu (IdMenu, Nombre, Categoria, Imagen, Precio) VALUES (34, N'Calamares con Curry', N'Marisco', N'calamares con curry.jpg', CAST(7.50 AS Decimal(10, 2)))
INSERT ItemMenu (IdMenu, Nombre, Categoria, Imagen, Precio) VALUES (36, N'Ternera con Champiñon', N'Ternera', N'Ternera con Champiñon.jpg', CAST(8.00 AS Decimal(10, 2)))
INSERT ItemMenu (IdMenu, Nombre, Categoria, Imagen, Precio) VALUES (38, N'Ternera con Salsa Barbacoa China', N'Ternera', N'Ternera con Salsa Barbacoa China.jpg', CAST(8.50 AS Decimal(10, 2)))
INSERT ItemMenu (IdMenu, Nombre, Categoria, Imagen, Precio) VALUES (39, N'Cerdo Agridulce', N'Ternera', N'Cerdo Agridulce.jpg', CAST(6.50 AS Decimal(10, 2)))
INSERT ItemMenu (IdMenu, Nombre, Categoria, Imagen, Precio) VALUES (40, N'Pato Asado', N'Ternera', N'Pato Asado.jpg', CAST(8.50 AS Decimal(10, 2)))
INSERT ItemMenu (IdMenu, Nombre, Categoria, Imagen, Precio) VALUES (41, N'Lata refresco', N'Bebida', N'Lata refresco.jpg', CAST(1.50 AS Decimal(10, 2)))
INSERT ItemMenu (IdMenu, Nombre, Categoria, Imagen, Precio) VALUES (45, N'Helado', N'Postre', N'helado.jpg', CAST(3.50 AS Decimal(10, 2)))
INSERT ItemMenu (IdMenu, Nombre, Categoria, Imagen, Precio) VALUES (46, N'Sopa de Aletas de Tiburon', N'Sopa', N'Sopa de Aletas de Tiburon.jpg', CAST(5.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT ItemMenu OFF
GO
SET IDENTITY_INSERT Mesa ON 

INSERT Mesa (IdMesa, Estado, Cantidad) VALUES (1, N'Libre', 2)
INSERT Mesa (IdMesa, Estado, Cantidad) VALUES (2, N'Libre', 6)
INSERT Mesa (IdMesa, Estado, Cantidad) VALUES (3, N'Ocupado', 3)
SET IDENTITY_INSERT Mesa OFF
GO
SET IDENTITY_INSERT Pedido ON 

INSERT Pedido (IdPedido, Precio, Fecha, ItemsMenu, IdMesa, IdMenu, Cantidad) VALUES (1240, CAST(6.50 AS Decimal(10, 2)), CAST(N'2023-03-27T09:37:33.837' AS DateTime), N'ku bak tres delicias', 3, 32, 5)
SET IDENTITY_INSERT Pedido OFF
GO
USE master
GO
ALTER DATABASE RESTAURANTE SET  READ_WRITE 
GO


