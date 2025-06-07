INSERT INTO Ingrediente (Cod_Ingre, Cod_Galle, Nombre, Cantidad)
VALUES (01, 01, 'harina Blanca', 1000),
(02, 01, 'Escencia de Vainilla', 5),
(03, 01, 'Azúcar', 1000),
(04, 01, 'Manteca', 500);

INSERT INTO Galleta (Cod_Prod, Cod_Galle, Nombre, Personaje, Gusto, Cantidad, Cod_Ingre_Principal, Segundo_Ingrediente)
VALUES (01, 01, 'clasic Vainilla', 'Eevee', 'Vainilla', 30, 01, 02),
(01, 02, 'clasic Vainilla', 'Pikachu', 'Vainilla', 30, 01, 02),
(01, 03, 'clasic Vainilla', 'Charmander', 'Vainilla', 30, 01, 02);

SELECT * FROM Galleta;

SELECT * FROM Ingrediente;

DECLARE @miValor VARCHAR(100) = 'Harina blanca'; -- Aquí pega el valor exacto que estás intentando insertar

SELECT Valor = @miValor,
LongitudConLEN = LEN(@miValor),             -- Mide caracteres, pero ignora espacios al final
LongitudConDATALENGTH = DATALENGTH(@miValor) -- Mide el número de bytes (más preciso)
