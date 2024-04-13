CREATE DATABASE Floreria;
USE Floreria;

CREATE TABLE Clientes(
Nombre NVARCHAR(50),
Apellido NVARCHAR(50),
Telefono int
);

CREATE TABLE Pedidos(
Cliente NVARCHAR(50),
Producto NVARCHAR(50),
Cantidad int,
Fecha Date
);

CREATE TABLE Vendedor(
Nombre NVARCHAR(50),
Apellido NVARCHAR(50),
Cedula NVARCHAR(50),
Telefono int
);

CREATE TABLE Proveedores(
Nombre NVARCHAR(50),
Apellido NVARCHAR(50),
Telefono int,
Productos NVARCHAR
);


SELECT * FROM dbo.Pedidos;


