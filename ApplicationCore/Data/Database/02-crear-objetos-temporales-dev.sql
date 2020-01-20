USE CONDOMINIUM_DB;

CREATE TABLE `USUARIO_TEMP` (
        `Id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
        `Nombre` VARCHAR(100) NOT NULL
)

-- validacion de motor de persistencia (InnoDB o MyISAM)
SELECT TABLE_NAME, ENGINE
FROM   information_schema.TABLES
WHERE  TABLE_SCHEMA = 'condominium_db';

insert into usuario_temp (nombre) values ('Miguel Toro');
insert into usuario_temp (nombre) values ('Jorge Mendez');
insert into usuario_temp (nombre) values ('Ernesto Alvarez');

select * from usuario_temp