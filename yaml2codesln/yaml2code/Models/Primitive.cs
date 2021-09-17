using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yaml2code.Models
{
    public class Primitive
    {
        public string Name { get; set; }
        public string FormatString { get; set; }
        public DataType DataType { get; set; }
    }

    public enum DataType
    {
        Int,
        Float,
        String,
        Boolean,
        Date,
        Span,
        DateTime
    }
}
/*
Primitive: Descripcion 
    Name: Descripcion
    FormatString: MaxLength=64
    DataType: DataType.String
-- Descripcion Larga
Name: Descripcion Larga
FormatString: MaxLength=1024
DataType: String

-- correo electronico 
Name: CorreoElectronico
FormatString: MaxLength=128,regex=^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$
DataType: DataType.String

 */