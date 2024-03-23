CREATE DATABASE DemoKrata

CREATE TABLE usuarios (
    id INT IDENTITY PRIMARY KEY,
    primer_nombre VARCHAR(50) NOT NULL,
    segundo_nombre VARCHAR(50),
    primer_apellido VARCHAR(50) NOT NULL,
    segundo_apellido VARCHAR(50),
    fecha_nacimiento DATE NOT NULL,
    sueldo DECIMAL(10, 2) NOT NULL CHECK (sueldo > 0),
    fecha_creacion DATE,
    fecha_modificacion VARCHAR(10)
);

select * from usuarios