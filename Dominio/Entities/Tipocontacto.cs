using System;
using System.Collections.Generic;

namespace Dominio.Entities;

public partial class Tipocontacto : BaseEntity
{
    

    public string? Descripcion { get; set; }

    public virtual ICollection<Contactopersona> Contactopersonas { get; set; } = new List<Contactopersona>();
}

INSERT INTO TipoPersona(Descripcion) VALUES ("Cliente"), ("Empleado")

INSERT INTO ContactoPersona (Descripcion, IdPersonaFk, IdTipoContactoFk) VALUES
    -- Insertar contactos para la persona 1
    ('555-1234', 1, 1), 
    ('555-5678', 1, 2), -- Teléfono fijo
    ('persona1@email.com', 1, 3), -- Correo electrónico
    ('facebook.com/persona1', 1, 4), -- Red social
    ('555-9999', 1, 5), -- Fax

    -- Insertar contactos para la persona 2
    ('555-4321', 2, 1), -- Celular
    ('555-8765', 2, 2), -- Teléfono fijo
    ('persona2@email.com', 2, 3), -- Correo electrónico
    ('twitter.com/persona2', 2, 4), -- Red social
    ('555-8888', 2, 5), -- Fax

    -- ... Puedes continuar agregando más inserciones para otras personas

    -- Insertar contactos para la persona 10
    ('555-4444', 10, 1), -- Celular
    ('555-3333', 10, 2); -- Teléfono fijo

INSERT INTO ContactoPersona (Descripcion, IdPersona, IdTipoContacto) VALUES
    ('555-1111', 3, 1), -- Celular
    ('555-2222', 3, 2), -- Teléfono fijo
    ('persona3@email.com', 3, 3), -- Correo electrónico
    ('instagram.com/persona3', 3, 4), -- Red social
    ('555-7777', 3, 5), -- Fax

    ('555-5555', 4, 1), -- Celular
    ('555-6666', 4, 2), -- Teléfono fijo
    ('persona4@email.com', 4, 3), -- Correo electrónico
    ('linkedin.com/persona4', 4, 4), -- Red social
    ('555-0000', 4, 5), -- Fax

    ('555-7777', 5, 1), -- Celular
    ('555-8888', 5, 2), -- Teléfono fijo
    ('persona5@email.com', 5, 3), -- Correo electrónico
    ('pinterest.com/persona5', 5, 4), -- Red social
    ('555-2222', 5, 5), -- Fax

    ('555-9999', 6, 1), -- Celular
    ('555-1111', 6, 2), -- Teléfono fijo
    ('persona6@email.com', 6, 3), -- Correo electrónico
    ('tiktok.com/persona6', 6, 4), -- Red social
    ('555-3333', 6, 5), -- Fax

    -- ... Puedes continuar agregando más inserciones según sea necesario
    ('555-5555', 8, 1), -- Celular
    ('555-6666', 8, 2), -- Teléfono fijo
    ('persona8@email.com', 8, 3), -- Correo electrónico
    ('snapchat.com/persona8', 8, 4), -- Red social
    ('555-0000', 8, 5);

INSERT INTO Persona (Id, IdPersonaFk, Nombre, FechaRegistro, IdTipoPersonaFk, IdCategoriaFk, IdCiudadFk) VALUES
(1, "a", 1, '2023-01-01', 1,1,1),
(2, "b", 2, '2023-01-02', 2,1,1),
(3, "c", 3, '2023-01-03', 1,1,1),
(4, "d", 4, '2023-01-04', 2,1,1),
(5, "e", 5, '2023-01-05', 1,1,1),
(6, "f", 6, '2023-01-06', 2,1,1),
(7, "g", 7, '2023-01-07', 1,1,1),
(8, "h", 8, '2023-01-08', 2,1,1),
(9, "i", 9, '2023-01-09', 1,1,1),
(10,"j",  10, '2023-01-10', 2,1,1),
(11,"k",  11, '2023-01-11', 1,1,1),
(12,"l",  12, '2023-01-12', 2,1,1),
(13,"m",  13, '2023-01-13', 1,1,1),
(14,"n",  14, '2023-01-14', 2,1,1),
(15,"ñ",  15, '2023-01-15', 1,1,1),
(16,"o",  16, '2023-01-16', 2,1,1),
(17,"p",  17, '2023-01-17', 1,1,1),
(18,"q",  18, '2023-01-18', 2,1,1),
(19,"r",  19, '2023-01-19', 1,1,1),
(20,"s",  20, '2023-01-20', 2,1,1),
(21,"t",  21, '2023-01-21', 1,1,1),
(22,"w",  22, '2023-01-22', 2,1,1),
(23,"x",  23, '2023-01-23', 1,1,1),
(24,"y",  24, '2023-01-24', 2,1,1),
(25,"z",  25, '2023-01-25', 1,1,1),
(26,"a",  26, '2023-01-26', 2,1,1),
(27,"b",  27, '2023-01-27', 1,1,1),
(28,"c",  28, '2023-01-28', 2,1,1),
(29,"d",  29, '2023-01-29', 1,1,1),
(30,"e",  30, '2023-01-30', 2,1,1),
(31,"f",  31, '2023-01-31', 1,1,1),
(32,"g",  32, '2023-02-01', 2,1,1),
(33,"h",  33, '2023-02-02', 1,1,1),
(34,"i",  34, '2023-02-03', 2,1,1),
(35,"j",  35, '2023-02-04', 1,1,1),
(36,"k",  36, '2023-02-05', 2,1,1),
(37,"l",  37, '2023-02-06', 1,1,1),
(38,"m",  38, '2023-02-07', 2,1,1),
(39,"n",  39, '2023-02-08', 1,1,1),
(40,"ñ",  40, '2023-02-09', 2,1,1);