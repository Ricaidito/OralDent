--Grupo #1 Base de Datos I
--Implementación de la base de datos para el App (OralDent)

--Creación de la base de datos
CREATE DATABASE Odontologia;
USE Odontologia;
DROP DATABASE Odontologia;
USE master

--Creación de las tablas

CREATE TABLE Usuarios
(
    Usuario VARCHAR(12) PRIMARY KEY,
    Clave VARCHAR(12) NOT NULL,
    Nombre VARCHAR(20) NOT NULL,
);

INSERT INTO Usuarios(Usuario, Clave, Nombre) VALUES -- Creación de usuarios
('RicardoR', '12345', 'Ricardo'), 
('admin', 'admin', 'Admin'),
('ReniD', '12345', 'Reni'),
('AbdelM', '12345', 'Abdel'),
('WilsonC', '12345', 'Wilson');

CREATE TABLE Sucursal
(
	IdSucursal INT IDENTITY(1,1) PRIMARY KEY,
	NombreSucursal VARCHAR(100),
	Direccion VARCHAR(100),
	Ciudad VARCHAR(100),
	Provincia VARCHAR(100),
);

INSERT INTO Sucursal VALUES ('Sucursal Churchill', 'Av. Winston Churchll', 'Distrito Nacional', 'Santo Domingo'),
('Sucursal Gazcue', 'Av. Independencia', 'Distrito Nacional', 'Santo Domingo'),
('Sucursal Piantnni', 'Av. Abrham Lincoln', 'Distrito Nacional', 'Santo Domingo'),
('Sucursal Villa Mella', 'Calle Yuma', 'Distrito Nacional', 'Santo Domingo'),
('Sucursal Alma Rosa II', 'Calle El Lider', 'Santo Domingo Este', 'Santo Domingo');



CREATE TABLE Paciente
(
    IdPaciente INT IDENTITY(1, 1) PRIMARY KEY,
    Nombre VARCHAR(20) NOT NULL,
    Apellido VARCHAR(20) NOT NULL,
    Cedula VARCHAR(20) NOT NULL,
    Correo VARCHAR(40) NOT NULL,
    Edad INT NOT NULL,
    Telefono VARCHAR(24) NOT NULL,
    TipoPaciente VARCHAR(5) NOT NULL
);

CREATE TABLE Dentista
(
    IdDentista INT IDENTITY(1, 1) PRIMARY KEY,
    Nombre VARCHAR(20) NOT NULL,
    Apellido VARCHAR(20) NOT NULL,
    Telefono VARCHAR(24) NOT NULL,
    Salario MONEY NOT NULL,
    Especialidad VARCHAR(40) NOT NULL,
	IdSucursal INT FOREIGN KEY REFERENCES Sucursal(IdSucursal)
);

CREATE TABLE Asistente 
(
    IdAsistente INT IDENTITY(1, 1) PRIMARY KEY,
    Nombre VARCHAR(20) NOT NULL,
    Apellido VARCHAR(20) NOT NULL,
    Telefono VARCHAR(24) NOT NULL,
    Salario MONEY NOT NULL,
    IdDentista INT FOREIGN KEY REFERENCES Dentista(IdDentista),
);

CREATE TABLE Consulta
(
    IdConsulta INT IDENTITY(1, 1) PRIMARY KEY,
    Fecha DATETIME NOT NULL,
    Descripcion VARCHAR(255),
    IdDentista INT FOREIGN KEY REFERENCES Dentista(IdDentista),
    IdPaciente INT FOREIGN KEY REFERENCES Paciente(IdPaciente) NOT NULL,
	IdSucursal INT FOREIGN KEY REFERENCES Sucursal(IdSucursal)
);

CREATE TABLE Servicio
(
    IdServicio INT IDENTITY(1, 1) PRIMARY KEY,
    Monto MONEY NOT NULL,
    TipoServicio VARCHAR(60),
    IdPaciente INT FOREIGN KEY REFERENCES Paciente(IdPaciente) NOT NULL,
    IdDentista INT FOREIGN KEY REFERENCES Dentista(IdDentista) NOT NULL,
	IdSucursal INT FOREIGN KEY REFERENCES Sucursal(IdSucursal)
);

DROP TABLE ServiciosLog

CREATE TABLE ServiciosLog
(
	IdPaciente INT FOREIGN KEY REFERENCES Paciente(IdPaciente) NOT NULL,
	IdSucursal INT FOREIGN KEY REFERENCES Sucursal(IdSucursal),
	IdDentista INT FOREIGN KEY REFERENCES Dentista(IdDentista) NOT NULL,
	Monto MONEY,
	TipoServicio VARCHAR(60),
	Fecha DATETIME NOT NULL
);

CREATE TABLE Factura 
(
    IdFactura INT IDENTITY(1, 1) PRIMARY KEY,
    Total MONEY NOT NULL,
    Fecha DATETIME NOT NULL,
    IdPaciente INT FOREIGN KEY REFERENCES Paciente(IdPaciente) NOT NULL,
	IdSucursal INT FOREIGN KEY REFERENCES Sucursal(IdSucursal)
);

--Creación del stored procedure para facturarle a un cliente

CREATE PROCEDURE spGenerarFactura @Total MONEY, @Fecha DATETIME, @IdPaciente INT, @IdSucursal INT
AS
    INSERT INTO Factura(Total, Fecha, IdPaciente, IdSucursal) VALUES(@Total, @Fecha, @IdPaciente, @IdSucursal);
    DELETE FROM Servicio WHERE IdPaciente = @IdPaciente;
GO

CREATE PROCEDURE spGenerarServicio @Monto MONEY, @Fecha DATETIME, @IdPaciente INT, @IdSucursal INT, @IdDentista INT, @TipoServicio VARCHAR(60)
AS
    INSERT INTO Servicio(Monto, Fecha, IdPaciente,IdSucursal, IdDentista,TipoServicio) VALUES(@Monto, @Fecha, @IdPaciente, @IdSucursal,@IdDentista,@TipoServicio);
	INSERT INTO ServiciosLog(Monto, Fecha, IdPaciente,IdSucursal, IdDentista,TipoServicio) VALUES(@Monto, @Fecha, @IdPaciente, @IdSucursal,@IdDentista, @TipoServicio);
GO

--Prueba del stored procedure
EXECUTE spGenerarFactura 60000, '1996 Apr 15', 13;
EXECUTE spGenerarServicio 60000, '1996 Apr 15', 1,1,1,'Limpieza';

--Query ejemplo para calcular el total de todos los servicios de un paciente
SELECT SUM(Monto) as Total FROM Servicio WHERE IdPaciente = 13;