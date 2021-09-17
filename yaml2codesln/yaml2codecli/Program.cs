using System;
using yaml2code;
using yaml2code.Models;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace yaml2codecli
{
    class Program
    {
        static void Main(string[] args)
        {
            var clase = new ObjectType { Name = "TipoDocumento",
                Fields = { "Id","Name","HasExpirationDate" }    
            };
            var Name = new Primitive { Name = "Name", FormatString = "MaxLength=64", DataType = DataType.String };
            var Description = new Primitive { Name = "Description", FormatString = "MaxLength=1024", DataType = DataType.String };
            var HasExpirationDate = new Primitive { Name = "HasExpirationDate", FormatString = "Default=False", DataType = DataType.Boolean };

            var test = new Test { 
                Objetos = new System.Collections.Generic.List<ObjectType> { clase }, 
                Primitivas = new System.Collections.Generic.List<Primitive> { Name,Description,HasExpirationDate } 
            };
            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
            var yaml = serializer.Serialize(test);
            System.Console.WriteLine(yaml);
        }
    }
}
