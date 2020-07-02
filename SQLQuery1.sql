CREATE TABLE Cliente(
	phone INT NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	pass VARCHAR(50) NOT NULL,
	PRIMARY KEY(phone)
);

CREATE TABLE Cajero(
	rut INT NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	pass VARCHAR(50) NOT NULL,
	PRIMARY KEY(rut)
);
USE PizzeriaDB;
CREATE TABLE Producto(
	id INT NOT NULL IDENTITY (1,1),
	nombre VARCHAR(50) NOT NULL,
	precio FLOAT NOT NULL DEFAULT 0,
	cantidad INT NOT NULL DEFAULT 0,
	PRIMARY KEY(id)
);

CREATE TABLE Venta(
	fecha INT NOT NULL,
	idProducto INT NOT NULL,
	idCajero INT NOT NULL,
	idCliente INT NOT NULL,
	
	FOREIGN KEY(idProducto) REFERENCES Producto(id),
	FOREIGN KEY(idCajero) REFERENCES Cajero(rut),
	FOREIGN KEY(idCliente) REFERENCES Cliente(phone),
	PRIMARY KEY(fecha)
);
drop table Producto;
insert into Producto values (1,'Familiar',22000,1);
use PizzeriaDB;
select * from Producto;
--eliminar todos los productos de la tabla
delete from Producto;
--reiniciar el indice
DBCC CHECKIDENT (Producto, RESEED,0);