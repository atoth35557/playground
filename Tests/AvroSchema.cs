using System.Text.Json.Serialization;

namespace Tests;


/// <summary>
/// Represents the overall schema structure.
/// </summary>
public class AvroSchema
{
    public string Type { get; set; }
    public string Name { get; set; }
    public string Namespace { get; set; }
    public string Doc { get; set; }
    public List<Field> Fields { get; set; }
}

public class Field
{
    public string Name { get; set; }
    public string Doc { get; set; }
    public object Type { get; set; } // Type can be string or a complex object
    public object Default { get; set; } // Optional default value
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string LogicalType { get; set; } // For logical types like decimal or timestamp
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Size { get; set; } // For fixed size types
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<string> Symbols { get; set; } // For enum types
}

public enum FieldType
{
    Int,
    Long,
    Float,
    Double,
    Bytes,
    Boolean,
    String,
    Array,
    Map,
    Record,
    Enum,
    Null
}

