DROP DATABASE if exists proyecto;
CREATE DATABASE playsfi;

USE playsfi;

DROP TABLE if exists Libros;
CREATE TABLE Libros(
	libro_id INT PRIMARY KEY,
	user_id INT,
	isbn INT,
	titulo VARCHAR(30), 
	autor VARCHAR(30),
	categoría VARCHAR(30),
	FOREIGN KEY (user_id) REFERENCES Usuario(id_user)
);

USE playsfi;
DROP TABLE if exists Usuario;
CREATE TABLE Usuario(
	id_user INT PRIMARY KEY,
	nombre VARCHAR(35),
	apellidos VARCHAR(55),
	edad INT,
	dni VARCHAR(9)
);

USE playsfi;
DROP TABLE if exists Favoritos;
CREATE TABLE Favoritos(
	favs_id INT PRIMARY KEY,
	titulo VARCHAR(30),
	fecha_lectura DATE,
	nota VARCHAR(255),
	usuario_id INT,
	FOREIGN KEY (favs_id) REFERENCES Libros(libro_id),
	FOREIGN KEY (usuario_id) REFERENCES Usuario(id_user)
);

USE playsfi;
DROP TABLE if exists Descatalogados;
CREATE TABLE Descatalogados(
	borrado_id INT PRIMARY KEY,
	usuario_id INT,
	titulo VARCHAR(30),
	fecha DATE,
	razon VARCHAR(100),
	FOREIGN KEY (usuario_id) REFERENCES Usuario(id_user)
);

INSERT INTO playsfi.dbo.Usuario VALUES (1, 'Andrea', 'Cano Montes', 20, '123456B');
INSERT INTO playsfi.dbo.Usuario VALUES (2, 'Kenzo', 'Cano Montes', 11, '12K');

INSERT INTO playsfi.dbo.Libros VALUES (1, 1, 1234, '40tena', 'Andrea Cano Montes', 'Misterio');
INSERT INTO playsfi.dbo.Libros VALUES (2, 1, 5467, '5 errores y un acierto','Andrea Cano Montes', 'Romance');
INSERT INTO playsfi.dbo.Libros VALUES (3, 2, 8901, 'Bellodrama','Ana Mena', 'Bollodrama');
