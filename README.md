# yaml2code

La idea es crear un generador de codigo partiendo de una definición ``ObjectDefinition`` y luego parseandolo contra unas plantillas de codigo, sql_table, sql_crudfunctions, csharp_class, axaml_form etc 
El proyecto de genera a partir de un conjunto de instrucciones y unos datos en un archivo de proyecto que se parsea directamente a una clase TaskRunner 

## Ejemplo
-- Descripción
Primitive: Descripcion 
    Name: Descripcion
    FormatString: MaxLength=64
    DataType: String
-- Descripcion Larga
Primitive: DescripcionLarga
    Name: Descripcion Larga
    FormatString: MaxLength=1024
    DataType: String
-- correo electronico 
Primitive: CorreoElectronico
    Name: CorreoElectronico
    FormatString: MaxLength=128,regex=^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$
    DataType: String
-- Id Autonumerico
Primitive: Id
    Name: Id
    FormatString: MaxLength=64,Unsigned
    DataType: Int
-- TipoDocumento
ObjectType: TipoDocumento
    Id,Nombre,TieneVencimiento

