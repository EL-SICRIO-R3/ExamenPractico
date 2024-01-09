--CREATE DATABASE pruebatecnica;
USE pruebatecnica;

--DROP TABLE cat_observacionesrechazo;
--DROP TABLE cat_prospectos;
--DROP TABLE cat_direcciones;
--DROP TABLE cat_documentos;

--DROP PROCEDURE proc_obtenerprospectoslistado;
--DROP PROCEDURE proc_actualizarestatus;
--DROP PROCEDURE proc_guardarobservaciones;
--DROP PROCEDURE proc_obtenerprospectoporid;
--DROP PROCEDURE proc_registrarprospecto;
--DROP PROCEDURE proc_registrarDocumento;
--DROP PROCEDURE proc_obtenerdocumentosporprospecto;

-- CREACIÓN DE LAS TABLAS

CREATE TABLE cat_direcciones (
    idu_direccion INTEGER IDENTITY(1,1) PRIMARY KEY,
    nom_calle VARCHAR(50),
    num_casa INTEGER,
    nom_colonia VARCHAR(50),
    num_codigoPostal INTEGER,
    num_telefono VARCHAR(20),
    des_rfc VARCHAR(13)
);

CREATE TABLE cat_prospectos (
    idu_prospecto INTEGER IDENTITY(1001,1) PRIMARY KEY,
    nom_prospecto VARCHAR(30),
    des_apellidoPaterno VARCHAR(30),
    des_apellidoMaterno VARCHAR(30),
    des_estatus VARCHAR(30),
    idu_direccion INTEGER,
    FOREIGN KEY (idu_direccion) REFERENCES cat_direcciones(idu_direccion)
);

CREATE TABLE cat_documentos (
    idu_documento INTEGER IDENTITY(1,1) PRIMARY KEY,
    nom_documento VARCHAR(100),
    des_ruta VARCHAR(200),
	idu_prospecto INTEGER,
	
	FOREIGN KEY (idu_prospecto) REFERENCES cat_prospectos(idu_prospecto)
);

CREATE TABLE cat_observacionesrechazo (
    idu_observacion INTEGER IDENTITY(1,1) PRIMARY KEY,
    des_observacion VARCHAR(250),
    idu_prospecto INTEGER,
    FOREIGN KEY (idu_prospecto) REFERENCES cat_prospectos(idu_prospecto)
);

GO
-- CREACIÓN DE LOS PROCEDIMIENTOS ALMACENADOS
CREATE PROCEDURE proc_obtenerprospectoslistado
AS
BEGIN
    SELECT *
    FROM cat_prospectos AS cp
    INNER JOIN cat_direcciones AS cd ON cp.idu_direccion = cd.idu_direccion
END;

GO

CREATE PROCEDURE proc_actualizarestatus
    @iduProspecto INTEGER,
    @estatus VARCHAR(30)
AS
BEGIN
    UPDATE cat_prospectos
    SET des_estatus = @estatus
    WHERE idu_prospecto = @iduProspecto;
END;

GO 

CREATE PROCEDURE proc_guardarobservaciones
    @observaciones VARCHAR(250),
    @iduProspecto INTEGER,
    @estatus VARCHAR(30)
AS
BEGIN
    INSERT INTO cat_observacionesrechazo(des_observacion, idu_prospecto)
    VALUES (@observaciones, @iduProspecto);

    UPDATE cat_prospectos
    SET des_estatus = @estatus
    WHERE idu_prospecto = @iduProspecto;
END;

GO

CREATE PROCEDURE proc_obtenerprospectoporid
    @id INTEGER
AS
BEGIN
    SELECT *
    FROM cat_prospectos AS cp
    INNER JOIN cat_direcciones AS cd ON cp.idu_direccion = cd.idu_direccion
    LEFT JOIN cat_observacionesrechazo AS obr ON cp.idu_prospecto = obr.idu_prospecto
    WHERE cp.idu_prospecto = @id;
END;

GO

CREATE PROCEDURE proc_registrarprospecto
    @nombre VARCHAR(30),
    @apellidoPaterno VARCHAR(30),
    @apellidoMaterno VARCHAR(30),
    @calle VARCHAR(50),
    @numCasa INTEGER,
    @colonia VARCHAR(50),
    @codigoPostal INTEGER,
    @telefono VARCHAR(20),
    @RFC VARCHAR(13)
AS
BEGIN

    DECLARE @iduDireccion INT;

    -- REGISTRO DE LA INFORMACION DE DIRECCIÓN
    INSERT INTO cat_direcciones(nom_calle, num_casa, nom_colonia, num_codigoPostal, num_telefono, des_rfc)
    VALUES (@calle, @numCasa, @colonia, @codigoPostal, @telefono, @RFC);

    SELECT @iduDireccion = MAX(idu_direccion) FROM cat_direcciones;

    -- REGISTRO DE LA INFORMACIÓN PERSONAL
    INSERT INTO cat_prospectos(nom_prospecto, des_apellidoPaterno, des_apellidoMaterno, des_estatus, idu_direccion)
    VALUES (@nombre, @apellidoPaterno, @apellidoMaterno, 'Enviado', @iduDireccion);
END;

GO 
CREATE PROCEDURE proc_registrarDocumento
    @nomDocumento VARCHAR(100),
    @desRuta VARCHAR(200)
AS
BEGIN
	DECLARE @iduProspecto INT;
	SELECT @iduProspecto = MAX(idu_prospecto) FROM cat_prospectos;
    INSERT INTO cat_documentos(nom_documento, des_ruta,idu_prospecto) 
    VALUES (@nomDocumento, @desRuta, @iduProspecto);
END;

GO

CREATE PROCEDURE proc_obtenerdocumentosporprospecto
    @id INTEGER
AS
BEGIN
    SELECT *
    FROM cat_documentos
    WHERE idu_prospecto = @id;
END;
