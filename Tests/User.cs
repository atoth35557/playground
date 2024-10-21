namespace Tests;public class User

{
    // Integer Types
    public int Id { get; set; }  // Integer
    public long BigId { get; set; }  // Long (Int64)
    public short SmallId { get; set; }  // Short (Int16)
    public byte Age { get; set; }  // Byte (0 - 255)

    // Floating Point Types
    public float HeightInMeters { get; set; }  // Float (Single precision floating point)
    public double WeightInKg { get; set; }  // Double (Double precision floating point)
    
    // Decimal
    public decimal Salary { get; set; }  // Decimal (high precision for financial calculations)

    // Boolean Type
    public bool IsActive { get; set; }  // Boolean (True/False)

    // Character Types
    public char Gender { get; set; }  // Char (Single character)

    // String
    public string FirstName { get; set; }  // String (Text)
    public string LastName { get; set; }  // String (Text)

    // DateTime and TimeSpan
    public DateTime DateOfBirth { get; set; }  // DateTime (for dates and times)
    public TimeSpan WorkingHours { get; set; }  // TimeSpan (represents time intervals)

    // Enum
    public UserRole Role { get; set; }  // Enum (User-defined enumeration)

    // Object and Complex Types
    public Address UserAddress { get; set; }  // Complex type (another object)
    public List<string> Hobbies { get; set; }  // List (Collection of strings)
    public Dictionary<string, string> Attributes { get; set; }  // Dictionary (Key-Value pairs)

    // Nullable Types
    public int? MiddleInitial { get; set; }  // Nullable int (can hold null)
    public DateTime? LastLogin { get; set; }  // Nullable DateTime (can hold null)

    // Custom Types
    public Guid UserIdentifier { get; set; }  // Guid (Unique identifier)
}

// Supporting Enum and Address Class
public enum UserRole
{
    Admin,
    User,
    Guest
}

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string PostalCode { get; set; }
}
