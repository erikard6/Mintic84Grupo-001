
-- -----------------------------------------------------
-- Schema Proyectos_g84_001
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Table tipo_proveedor
-- -----------------------------------------------------
CREATE TABLE tipo_proveedor (
  tippro_id [int] IDENTITY(1,1) NOT NULL,
  tippro_nombre VARCHAR(45) NOT NULL,
  PRIMARY KEY (tippro_id))
;


-- -----------------------------------------------------
-- Table proveedor
-- -----------------------------------------------------
CREATE TABLE proveedor (
  pro_identificacion VARCHAR(15) NOT NULL,
  pro_nombre VARCHAR(45) NOT NULL,
  pro_correo VARCHAR(250) NOT NULL,
  pro_celular VARCHAR(45) NULL,
  pro_tipo_proveedor INT NOT NULL,
  PRIMARY KEY (pro_identificacion),
  CONSTRAINT fk_proveedor_tipo_proveedor1
    FOREIGN KEY (pro_tipo_proveedor)
    REFERENCES tipo_proveedor (tippro_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX fk_proveedor_tipo_proveedor1_idx ON proveedor (pro_tipo_proveedor ASC) ;


-- -----------------------------------------------------
-- Table licencia_conductor
-- -----------------------------------------------------
CREATE TABLE licencia_conductor (
  liccon_id [int] IDENTITY(1,1) NOT NULL,
  liccon_nombre VARCHAR(45) NOT NULL,
  PRIMARY KEY (liccon_id))
;


-- -----------------------------------------------------
-- Table Conductor
-- -----------------------------------------------------
CREATE TABLE Conductor (
  con_identificacion VARCHAR(45) NOT NULL,
  con_nombre VARCHAR(45) NOT NULL,
  con_licencia VARCHAR(45) NOT NULL,
  con_celular VARCHAR(45) NULL,
  con_tipo_licencia INT NOT NULL,
  PRIMARY KEY (con_identificacion),
  CONSTRAINT fk_Conductor_licencia_conductor1
    FOREIGN KEY (con_tipo_licencia)
    REFERENCES licencia_conductor (liccon_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX fk_Conductor_licencia_conductor1_idx ON Conductor (con_tipo_licencia ASC) ;


-- -----------------------------------------------------
-- Table licencia_cliente
-- -----------------------------------------------------
CREATE TABLE licencia_cliente (
  liccli_id [int] IDENTITY(1,1) NOT NULL,
  liccli_nombre VARCHAR(45) NOT NULL,
  PRIMARY KEY (liccli_id))
;


-- -----------------------------------------------------
-- Table cliente
-- -----------------------------------------------------
CREATE TABLE cliente (
  cli_identificacion VARCHAR(15) NOT NULL,
  cli_nombre VARCHAR(45) NOT NULL,
  cli_correo VARCHAR(250) NOT NULL,
  cli_celular VARCHAR(45) NULL,
  cli_licencia VARCHAR(45) NULL,
  cli_tipolicencia VARCHAR(45) NOT NULL,
  cli_tipo_licencia INT NOT NULL,
  PRIMARY KEY (cli_identificacion),
  CONSTRAINT fk_cliente_licencia_cliente
    FOREIGN KEY (cli_tipo_licencia)
    REFERENCES licencia_cliente (liccli_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX fk_cliente_licencia_cliente_idx ON cliente (cli_tipo_licencia ASC) ;


-- -----------------------------------------------------
-- Table disponibilidad
-- -----------------------------------------------------
CREATE TABLE disponibilidad (
  disp_id [int] IDENTITY(1,1) NOT NULL,
  disp_nombre VARCHAR(7) NOT NULL,
  PRIMARY KEY (disp_id))
;


-- -----------------------------------------------------
-- Table capacidad
-- -----------------------------------------------------
CREATE TABLE capacidad (
  cap_id [int] IDENTITY(1,1) NOT NULL,
  cap_rango VARCHAR(24) NOT NULL,
  PRIMARY KEY (cap_id))
;


-- -----------------------------------------------------
-- Table tipo_alquiler
-- -----------------------------------------------------
CREATE TABLE tipo_alquiler (
  tipalq_id [int] IDENTITY(1,1) NOT NULL,
  tipalq_nombre VARCHAR(24) NOT NULL,
  PRIMARY KEY (tipalq_id))
;


-- -----------------------------------------------------
-- Table marca
-- -----------------------------------------------------
CREATE TABLE marca (
  marca_id [int] IDENTITY(1,1) NOT NULL,
  marca_nombre VARCHAR(24) NOT NULL,
  PRIMARY KEY (marca_id))
;


-- -----------------------------------------------------
-- Table tipo_vehiculo
-- -----------------------------------------------------
CREATE TABLE tipo_vehiculo (
  tipveh_id [int] IDENTITY(1,1) NOT NULL,
  tipveh_nombre VARCHAR(45) NOT NULL,
  PRIMARY KEY (tipveh_id))
;


-- -----------------------------------------------------
-- Table ciudad
-- -----------------------------------------------------
CREATE TABLE ciudad (
  ciu_id [int] IDENTITY(1,1) NOT NULL,
  ciu_nombre VARCHAR(45) NOT NULL,
  PRIMARY KEY (ciu_id))
;


-- -----------------------------------------------------
-- Table vehiculo
-- -----------------------------------------------------
CREATE TABLE vehiculo (
  veh_placa VARCHAR(7) NOT NULL,
  veh_identificacion_proveedor VARCHAR(15) NOT NULL,
  veh_modelo VARCHAR(10) NOT NULL,
  veh_precio VARCHAR(45) NOT NULL,
  veh_capacidad INT NOT NULL,
  veh_disponibilidad INT NOT NULL,
  veh_tipo_alquiler INT NOT NULL,
  veh_marca INT NOT NULL,
  veh_tipo_vehiculo INT NOT NULL,
  veh_ciudad INT NOT NULL,
  PRIMARY KEY (veh_placa),
  CONSTRAINT fk_vehiculo_capacidad1
    FOREIGN KEY (veh_capacidad)
    REFERENCES capacidad (cap_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_vehiculo_disponibilidad1
    FOREIGN KEY (veh_disponibilidad)
    REFERENCES disponibilidad (disp_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_vehiculo_tipo_alquiler1
    FOREIGN KEY (veh_tipo_alquiler)
    REFERENCES tipo_alquiler (tipalq_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_vehiculo_marca1
    FOREIGN KEY (veh_marca)
    REFERENCES marca (marca_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_vehiculo_tipo_vehiculo1
    FOREIGN KEY (veh_tipo_vehiculo)
    REFERENCES tipo_vehiculo (tipveh_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_vehiculo_ciudad1
    FOREIGN KEY (veh_ciudad)
    REFERENCES ciudad (ciu_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_vehiculo_proveedor1
    FOREIGN KEY (veh_identificacion_proveedor)
    REFERENCES proveedor (pro_identificacion)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX fk_vehiculo_capacidad1_idx ON vehiculo (veh_capacidad ASC) ;

CREATE INDEX fk_vehiculo_disponibilidad1_idx ON vehiculo (veh_disponibilidad ASC) ;

CREATE INDEX fk_vehiculo_tipo_alquiler1_idx ON vehiculo (veh_tipo_alquiler ASC) ;

CREATE INDEX fk_vehiculo_marca1_idx ON vehiculo (veh_marca ASC) ;

CREATE INDEX fk_vehiculo_tipo_vehiculo1_idx ON vehiculo (veh_tipo_vehiculo ASC) ;

CREATE INDEX fk_vehiculo_ciudad1_idx ON vehiculo (veh_ciudad ASC) ;

CREATE INDEX fk_vehiculo_proveedor1_idx ON vehiculo (veh_identificacion_proveedor ASC) ;


-- -----------------------------------------------------
-- Table clasificacion_carga
-- -----------------------------------------------------
CREATE TABLE clasificacion_carga (
  clacar_id [int] IDENTITY(1,1) NOT NULL,
  claclar_nombre VARCHAR(45) NOT NULL,
  PRIMARY KEY (clacar_id))
;


-- -----------------------------------------------------
-- Table tipo_carga
-- -----------------------------------------------------
CREATE TABLE tipo_carga (
  tipcar_id [int] IDENTITY(1,1) NOT NULL,
  tipcar_nombre VARCHAR(45) NOT NULL,
  PRIMARY KEY (tipcar_id))
;


-- -----------------------------------------------------
-- Table carga
-- -----------------------------------------------------
CREATE TABLE carga (
  car_id [int] IDENTITY(1,1) NOT NULL,
  car_clasificacion INT NOT NULL,
  car_tipo INT NOT NULL,
  PRIMARY KEY (car_id),
  CONSTRAINT fk_carga_clasificacion_carga1
    FOREIGN KEY (car_clasificacion)
    REFERENCES clasificacion_carga (clacar_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_carga_tipo_carga1
    FOREIGN KEY (car_tipo)
    REFERENCES tipo_carga (tipcar_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX fk_carga_clasificacion_carga1_idx ON carga (car_clasificacion ASC) ;

CREATE INDEX fk_carga_tipo_carga1_idx ON carga (car_tipo ASC) ;


-- -----------------------------------------------------
-- Table vehiculo_carga
-- -----------------------------------------------------
CREATE TABLE vehiculo_carga (
  vehcar_placa VARCHAR(7) NOT NULL,
  vehcar_carga_id INT NOT NULL,
  vehcar_peso_max FLOAT NOT NULL,
  vehcar_peso_min FLOAT NOT NULL,
  PRIMARY KEY (vehcar_placa, vehcar_carga_id),
  CONSTRAINT fk_vehiculo_carga_vehiculo1
    FOREIGN KEY (vehcar_placa)
    REFERENCES vehiculo (veh_placa)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_vehiculo_carga_carga1
    FOREIGN KEY (vehcar_carga_id)
    REFERENCES carga (car_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX fk_vehiculo_carga_vehiculo1_idx ON vehiculo_carga (vehcar_placa ASC) ;

CREATE INDEX fk_vehiculo_carga_carga1_idx ON vehiculo_carga (vehcar_carga_id ASC) ;


-- -----------------------------------------------------
-- Table Estado
-- -----------------------------------------------------
CREATE TABLE Estado (
  est_id [int] IDENTITY(1,1) NOT NULL,
  est_nombre VARCHAR(45) NOT NULL,
  PRIMARY KEY (est_id))
;


-- -----------------------------------------------------
-- Table reserva
-- -----------------------------------------------------
CREATE TABLE reserva (
  res_id [int] IDENTITY(1,1) NOT NULL,
  res_identificacion_cliente VARCHAR(15) NOT NULL,
  res_placa VARCHAR(7) NOT NULL,
  res_carga_id INT NOT NULL,
  res_fecha_reserva DATE NOT NULL,
  res_fecha_inicio DATE NOT NULL,
  res_fecha_fin DATE NOT NULL,
  res_ciudad_destino VARCHAR(45) NOT NULL,
  res_peso FLOAT NOT NULL,
  res_contenido_paquete VARCHAR(200) NOT NULL,
  Estado_est_id INT NOT NULL,
  PRIMARY KEY (res_id),
  CONSTRAINT fk_reserva_vehiculo_carga1
    FOREIGN KEY (res_placa , res_carga_id)
    REFERENCES vehiculo_carga (vehcar_placa , vehcar_carga_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_reserva_cliente1
    FOREIGN KEY (res_identificacion_cliente)
    REFERENCES cliente (cli_identificacion)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_reserva_Estado1
    FOREIGN KEY (Estado_est_id)
    REFERENCES Estado (est_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX fk_reserva_vehiculo_carga1_idx ON reserva (res_placa ASC, res_carga_id ASC) ;

CREATE INDEX fk_reserva_cliente1_idx ON reserva (res_identificacion_cliente ASC) ;

CREATE INDEX fk_reserva_Estado1_idx ON reserva (Estado_est_id ASC) ;


-- -----------------------------------------------------
-- Table vehiculo_conductor
-- -----------------------------------------------------
CREATE TABLE vehiculo_conductor (
  vehcon_placa VARCHAR(7) NOT NULL,
  vehcon_identificaion_conductor VARCHAR(45) NOT NULL,
  CONSTRAINT fk_vehiculo_conductor_vehiculo1
    FOREIGN KEY (vehcon_placa)
    REFERENCES vehiculo (veh_placa)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_vehiculo_conductor_Conductor1
    FOREIGN KEY (vehcon_identificaion_conductor)
    REFERENCES Conductor (con_identificacion)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX fk_vehiculo_conductor_vehiculo1_idx ON vehiculo_conductor (vehcon_placa ASC) ;

CREATE INDEX fk_vehiculo_conductor_Conductor1_idx ON vehiculo_conductor (vehcon_identificaion_conductor ASC) ;
