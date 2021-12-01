CREATE DATABASE Odontologia;
USE Odontologia;

CREATE TABLE Usuarios
(
    Usuario VARCHAR(12) PRIMARY KEY,
    Clave VARCHAR(12) NOT NULL,
    Nombre VARCHAR(20) NOT NULL,
);

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
    Especialidad VARCHAR(40) NOT NULL
);

CREATE TABLE Asistente 
(
    IdAsistente INT IDENTITY(1, 1) PRIMARY KEY,
    Nombre VARCHAR(20) NOT NULL,
    Apellido VARCHAR(20) NOT NULL,
    Telefono VARCHAR(24) NOT NULL,
    Salario MONEY NOT NULL,
    IdDentista INT FOREIGN KEY REFERENCES Dentista(IdDentista)
);

CREATE TABLE Consulta
(
    IdConsulta INT IDENTITY(1, 1) PRIMARY KEY,
    Fecha DATETIME NOT NULL,
    Descripcion VARCHAR(255),
    IdDentista INT FOREIGN KEY REFERENCES Dentista(IdDentista),
    IdPaciente INT FOREIGN KEY REFERENCES Paciente(IdPaciente) NOT NULL
);

CREATE TABLE Servicio
(
    IdServicio INT IDENTITY(1, 1) PRIMARY KEY,
    Monto MONEY NOT NULL,
    TipoServicio VARCHAR(60),
    IdPaciente INT FOREIGN KEY REFERENCES Paciente(IdPaciente) NOT NULL,
    IdDentista INT FOREIGN KEY REFERENCES Dentista(IdDentista) NOT NULL
);

CREATE TABLE Factura 
(
    IdFactura INT IDENTITY(1, 1) PRIMARY KEY,
    Total MONEY NOT NULL,
    Fecha DATETIME NOT NULL
    IdPaciente INT FOREIGN KEY REFERENCES Paciente(IdPaciente) NOT NULL,
);

CREATE PROCEDURE spGenerarFactura @Total MONEY, @Fecha DATETIME, @IdPaciente INT
AS
    INSERT INTO Factura(Total, Fecha, IdPaciente) VALUES(@Total, @Fecha, @IdPaciente);
    DELETE FROM Servicio WHERE IdPaciente = @IdPaciente;
GO

EXECUTE spGenerarFactura 60000, '1996 Apr 15', 13;
SELECT SUM(Monto) as Total FROM Servicio WHERE IdPaciente = 13;