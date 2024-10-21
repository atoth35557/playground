using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Avro;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Tests;

public class UnitTest1
{
    public static AvroSchema MapTypeToSchema(Type type)
    {
        var schema = new AvroSchema
        {
            Type = "record",
            Name = type.Name,
            Namespace = "YourNamespace",
            Doc = $"This record represents a {type.Name} in the system.",
            Fields = new List<Field>()
        };

        foreach (var property in type.GetProperties())
        {
            var field = new Field
            {
                Name = property.Name,
                Doc = GetPropertyDocComment(property),
                Type = MapTypeToAvroType(property.PropertyType),
                Default = null, // Implement logic for default if needed
                LogicalType = GetLogicalType(property.PropertyType),
                Size = GetFixedSize(property.PropertyType),
                Symbols = GetEnumSymbols(property.PropertyType)
            };

            schema.Fields.Add(field);
        }

        return schema;
    }

    private static object MapTypeToAvroType(Type type)
    {
        if (type == typeof(int) || type == typeof(short) || type == typeof(byte)) return "int";
        if (type == typeof(long)) return "long";
        if (type == typeof(float)) return "float";
        if (type == typeof(double)) return "double";
        if (type == typeof(decimal)) return new { type = "bytes", logicalType = "decimal", precision = 4, scale = 2 };
        if (type == typeof(bool)) return "boolean";
        if (type == typeof(string) || type == typeof(char)) return "string";

        // Handle enums
        if (type.IsEnum) return new { type = "enum", name = type.Name, symbols = Enum.GetNames(type).ToList() };

        // Handle records (nested classes)
        if (type.IsClass && type != typeof(string))
        {
            var nestedSchema = MapTypeToSchema(type);
            return new { type = "record", name = nestedSchema.Name, doc = nestedSchema.Doc, fields = nestedSchema.Fields };
        }

        // Handle collections
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
            return new { type = "array", items = MapTypeToAvroType(type.GenericTypeArguments[0]) };

        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Dictionary<,>))
            return new { type = "map", values = MapTypeToAvroType(type.GenericTypeArguments[1]) };

        // Handle nullable types
        if (Nullable.GetUnderlyingType(type) != null)
            return new List<object> { "null", MapTypeToAvroType(Nullable.GetUnderlyingType(type)) };

        return null; // Handle unsupported types
    }

    private static string GetPropertyDocComment(PropertyInfo property)
    {
        //var docAttr = property.GetCustomAttributes(typeof(DescriptionAttribute), false)
          //                     .FirstOrDefault() as DescriptionAttribute;

       // return docAttr?.Description ?? $"The {property.Name} property of {property.DeclaringType.Name}.";
       return $"The {property.Name} property of {property.DeclaringType.Name}.";
    }

    private static string GetLogicalType(Type type)
    {
        if (type == typeof(decimal) || type == typeof(double)) return "decimal"; // Example for logical type
        return null;
    }

    private static int? GetFixedSize(Type type)
    {
        if (type.Name == "Guid") return 16; // Fixed size for Guid
        return null;
    }

    private static List<string> GetEnumSymbols(Type type)
    {
        if (type.IsEnum)
            return Enum.GetNames(type).ToList();
        return null;
    }

    [Fact]
    public void Test1()
    {
        var user = new User
        {
            Id = 1,
            BigId = 123456789123456789,
            SmallId = 123,
            Age = 25,
            HeightInMeters = 1.75f,
            WeightInKg = 70.5,
            Salary = 50000.75m,
            IsActive = true,
            Gender = 'M',
            FirstName = "John",
            LastName = "Doe",
            DateOfBirth = new DateTime(1990, 5, 21),
            WorkingHours = new TimeSpan(8, 30, 0),
            Role = UserRole.Admin,
            UserAddress = new Address
            {
                Street = "123 Main St",
                City = "Springfield",
                State = "IL",
                Country = "USA",
                PostalCode = "62701"
            },
            Hobbies = new List<string> { "Reading", "Cycling", "Gaming" },
            Attributes = new Dictionary<string, string>
            {
                { "FavoriteColor", "Blue" },
                { "SkillLevel", "Expert" }
            },
            MiddleInitial = null,
            LastLogin = DateTime.Now,
            UserIdentifier = Guid.NewGuid()
        };

        var schema = MapTypeToSchema(typeof(User));
        
        var settings = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull 
        };

        string jsonSchema = JsonSerializer.Serialize(schema, settings);
        Assert.True(true);

    }
}