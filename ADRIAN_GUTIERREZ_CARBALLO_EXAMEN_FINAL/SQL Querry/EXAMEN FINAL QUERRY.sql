CREATE DATABASE aduana
USE aduana

CREATE TABLE usuarios
(
	id INT IDENTITY NOT NULL,
	nombre varchar(25) NOT NULL,
	correo varchar(30) UNIQUE NOT NULL,
	contra varchar(15) NOT NULL DEFAULT '123',
	CONSTRAINT PK_usuarios PRIMARY KEY (id)
)

CREATE TABLE motivo_viaje
(
	id INT IDENTITY NOT NULL,
	nombre_tipo varchar(25) UNIQUE NOT NULL,
	CONSTRAINT PK_motivo PRIMARY KEY (id)
)

CREATE TABLE registro --viajes
(
	travel_id INT IDENTITY NOT NULL,
	tipo_id INT NOT NULL,
	fecha DATETIME NOT NULL,
	destino varchar(35) NOT NULL,
	CONSTRAINT PK_registro PRIMARY KEY (travel_id),
	CONSTRAINT FK_registro1 FOREIGN KEY (tipo_id) REFERENCES tipo_registro(id_tipo)
)

CREATE TABLE tipo_registro
(
	id_tipo INT IDENTITY NOT NULL,
	nom_tipo varchar(25) UNIQUE NOT NULL DEFAULT 'Turismo',
	CONSTRAINT PK_tip_registro PRIMARY KEY (id_tipo)
)

CREATE TABLE viajeros
(
	id_viaje INT IDENTITY NOT NULL,
	cedula char(9) UNIQUE NOT NULL,
	nom_viajero varchar(25) NOT NULL,
	edad INT NOT NULL DEFAULT 18 CHECK (edad >= 18 and edad <= 120),
	nacion varchar(35) NOT NULL,
	viaje_id INT NOT NULL,
	mot_id INT NOT NULL,
	CONSTRAINT PK_viajeros PRIMARY KEY (id_viaje),
	CONSTRAINT FK_viajeros1 FOREIGN KEY (viaje_id) REFERENCES registro(travel_id),
	CONSTRAINT FK_viajeros2 FOREIGN KEY (mot_id) REFERENCES motivo_viaje(id)
)