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
    IdPaciente INT IDENTITY(1,1) PRIMARY KEY,
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