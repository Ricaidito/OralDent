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
('ricardo', 'ricardo', 'Ricardo'), 
('admin', 'admin', 'Admin'),
('carlos', 'carlos', 'Carlos'),
('fernando', 'fernando', 'Fernando'),
('luis', 'luis', 'Luis');

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

INSERT INTO Paciente(Nombre,Apellido,Cedula,Correo,Edad,Telefono,TipoPaciente) VALUES
  ('Aretha Petersen','Troy Combs','87948341817','tincidunt@google.org',25,'809-430-7871','Mayor'),
  ('Bertha Salazar','Lila Ratliff','81726575804','lorem.ipsum.dolor@outlook.net',8,'809-473-1136','Mayor'),
  ('Cally Mcgowan','Magee Hutchinson','54890216031','odio@yahoo.com',7,'829-273-3380','Mayor'),
  ('Timon Atkinson','Vaughan Roth','25282886966','egestas.blandit@icloud.net',79,'829-248-8240','Mayor'),
  ('Jin Morrow','Lamar Mathews','54563257317','vivamus.nibh.dolor@google.edu',15,'849-631-7862','Menor'),
  ('Rebekah Larson','Kermit Hardy','64683584092','ut.odio@aol.edu',84,'849-776-2571','Menor'),
  ('Remedios Frazier','Wynter Johns','81167525158','luctus@yahoo.com',74,'849-452-0757','Menor'),
  ('Boris Solis','Shelly Hale','97769670712','vestibulum.neque@hotmail.ca',19,'849-152-4406','Menor'),
  ('Veronica Dunlap','Rae Barrera','34183101734','et@aol.net',53,'829-887-5882','Mayor'),
  ('Tad Tran','Erasmus Padilla','13481665536','curabitur.vel@yahoo.couk',31,'849-987-2631','Mayor'),
  ('Autumn Downs','Acton Sloan','67124382067','ante.maecenas@icloud.com',77,'809-412-8041','Mayor'),
  ('Aidan Hopkins','Brett Maxwell','55657242193','malesuada.augue@outlook.net',30,'849-186-6972','Mayor'),
  ('Sonya Short','Xavier Reid','92548246280','est@aol.org',77,'829-798-8753','Menor'),
  ('Maryam Lloyd','Pearl Bond','18641926428','elementum@protonmail.ca',39,'809-417-1333','Menor'),
  ('Peter Parker','Dante Tran','55572523818','ipsum.suspendisse@hotmail.org',4,'809-343-1363','Menor'),
  ('Dylan Stein','September Kennedy','43635341498','sociis.natoque@icloud.net',35,'829-531-7059','Menor'),
  ('Carson Buck','Nash Bauer','31819703524','felis.ullamcorper@aol.net',57,'849-377-7624','Mayor'),
  ('Zachery Jacobs','Irma Fields','28764433389','vulputate.nisi@protonmail.com',11,'829-575-8667','Mayor'),
  ('Quail Benton','Samantha Ratliff','18441577812','malesuada.malesuada@icloud.org',35,'809-286-8444','Mayor'),
  ('Joy Horne','Lamar Delaney','11942426772','sed.nec@yahoo.org',5,'809-384-8581','Mayor');

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

DROP TABLE Servicio

CREATE TABLE Servicio
(
    IdServicio INT IDENTITY(1, 1) PRIMARY KEY,
    Monto MONEY NOT NULL,
	Fecha DATETIME NOT NULL,
    TipoServicio VARCHAR(60),
    IdPaciente INT FOREIGN KEY REFERENCES Paciente(IdPaciente) NOT NULL,
    IdDentista INT FOREIGN KEY REFERENCES Dentista(IdDentista) NOT NULL,
	IdSucursal INT FOREIGN KEY REFERENCES Sucursal(IdSucursal)
);

CREATE TABLE Factura 
(
    IdFactura INT IDENTITY(1, 1) PRIMARY KEY,
    Total MONEY NOT NULL,
    Fecha DATETIME NOT NULL,
    IdPaciente INT FOREIGN KEY REFERENCES Paciente(IdPaciente) NOT NULL,
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


--Creación del stored procedure para facturarle a un cliente

CREATE PROCEDURE spGenerarFactura @Total MONEY, @Fecha DATETIME, @IdPaciente INT, @IdSucursal INT
AS
    INSERT INTO Factura(Total, Fecha, IdPaciente, IdSucursal) VALUES(@Total, @Fecha, @IdPaciente, @IdSucursal);
    DELETE FROM Servicio WHERE IdPaciente = @IdPaciente;
GO

DROP PROCEDURE spGenerarServicio

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

SELECT * FROM Servicio
SELECT * FROM ServiciosLog