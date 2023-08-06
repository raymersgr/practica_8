CREATE DATABASE PRACTICA8

USE PRACTICA8

CREATE TABLE documentos (
    factura INT,
    condicion VARCHAR(15),
    cliente VARCHAR(30),
    fecha DATE,
    monto NUMERIC,
    estado VARCHAR(15)
);


INSERT INTO documentos (factura, condicion, cliente, fecha, monto, estado)
VALUES (12345, 'Contado', 'Cliente A', '2023-08-05', 1000.50, 'Pagado'),
		(12346, 'Crédito', 'Cliente B', '2023-08-06', 2500.75, 'Pendiente'),
       (12347, 'Contado', 'Cliente C', '2023-08-07', 800.30, 'Pagado'),
       (12348, 'Crédito', 'Cliente D', '2023-08-08', 1800.20, 'Pendiente');

SELECT * FROM documentos