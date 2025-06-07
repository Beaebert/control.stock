CREATE TABLE Producto (
Cod_Prod int NOT NULL PRIMARY KEY,
Nombre VARCHAR NOT NULL UNIQUE,
Personaje VARCHAR NOT NULL,
Gusto VARCHAR NOT NULL,
)

CREATE TABLE Ingrediente (
Cod_Ingre int NOT NULL PRIMARY KEY,
Nombre VARCHAR NOT NULL UNIQUE,
Cantidad int NOT NULL,
)

CREATE TABLE Galleta (
Cod_Prod int NOT NULL FOREIGN KEY REFERENCES Producto (Cod_Prod),
Cod_Galle int NOT NULL PRIMARY KEY,
Nombre VARCHAR UNIQUE,
Personaje VARCHAR NOT NULL,
Gusto VARCHAR NOT NULL,
Cantidad int NOT NULL,
Cod_Ingre_Principal int NOT NULL FOREIGN KEY REFERENCES Ingrediente (Cod_Ingre),
Segundo_Ingrediente int NOT NULL FOREIGN KEY REFERENCES Ingrediente (Cod_Ingre),
)

ALTER TABLE Ingrediente
ADD Cod_Galle int NOT NULL FOREIGN KEY REFERENCES Galleta (Cod_Galle);
