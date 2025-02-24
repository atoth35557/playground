// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.12.0+8c27801dc8d42ccc00997f25c0b8f45f8d4a233e
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace YourNamespace
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using global::Avro;
	using global::Avro.Specific;
	
	/// <summary>
	/// This record represents a user in the system.
	/// </summary>
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("avrogen", "1.12.0+8c27801dc8d42ccc00997f25c0b8f45f8d4a233e")]
	public partial class User : global::Avro.Specific.ISpecificRecord
	{
		public static global::Avro.Schema _SCHEMA = global::Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"User\",\"doc\":\"This record represents a user in the system" +
				".\",\"namespace\":\"YourNamespace\",\"fields\":[{\"name\":\"Id\",\"doc\":\"Unique identifier f" +
				"or the user.\",\"type\":\"int\"},{\"name\":\"BigId\",\"doc\":\"A larger unique identifier fo" +
				"r systems that require larger ID ranges.\",\"type\":\"long\"},{\"name\":\"SmallId\",\"doc\"" +
				":\"A smaller ID, used in specific contexts where integer IDs are sufficient.\",\"ty" +
				"pe\":\"int\"},{\"name\":\"Age\",\"doc\":\"The age of the user.\",\"type\":\"int\"},{\"name\":\"Hei" +
				"ghtInMeters\",\"doc\":\"The user\'s height in meters.\",\"type\":\"float\"},{\"name\":\"Weigh" +
				"tInKg\",\"doc\":\"The user\'s weight in kilograms.\",\"type\":\"double\"},{\"name\":\"Salary\"" +
				",\"doc\":\"The user\'s salary as a precise decimal value.\",\"type\":\"bytes\"},{\"name\":\"" +
				"IsActive\",\"doc\":\"Indicates if the user is active or not.\",\"type\":\"boolean\"},{\"na" +
				"me\":\"Gender\",\"doc\":\"The gender of the user, represented as a single character.\"," +
				"\"type\":\"string\"},{\"name\":\"FirstName\",\"doc\":\"The user\'s first name.\",\"type\":\"stri" +
				"ng\"},{\"name\":\"LastName\",\"doc\":\"The user\'s last name.\",\"type\":\"string\"},{\"name\":\"" +
				"DateOfBirth\",\"doc\":\"The user\'s date of birth, stored as a timestamp in milliseco" +
				"nds.\",\"type\":{\"type\":\"long\",\"logicalType\":\"timestamp-millis\"}},{\"name\":\"WorkingH" +
				"ours\",\"doc\":\"The number of working hours the user is assigned.\",\"type\":\"long\"},{" +
				"\"name\":\"Role\",\"doc\":\"The user\'s role in the system.\",\"type\":{\"type\":\"enum\",\"name" +
				"\":\"UserRole\",\"namespace\":\"YourNamespace\",\"symbols\":[\"Admin\",\"User\",\"Guest\"]}},{\"" +
				"name\":\"UserAddress\",\"doc\":\"The user\'s address information.\",\"type\":{\"type\":\"reco" +
				"rd\",\"name\":\"Address\",\"namespace\":\"YourNamespace\",\"fields\":[{\"name\":\"Street\",\"doc" +
				"\":\"Street address of the user.\",\"type\":\"string\"},{\"name\":\"City\",\"doc\":\"City wher" +
				"e the user resides.\",\"type\":\"string\"},{\"name\":\"State\",\"doc\":\"State where the use" +
				"r resides.\",\"type\":\"string\"},{\"name\":\"Country\",\"doc\":\"Country of residence.\",\"ty" +
				"pe\":\"string\"},{\"name\":\"PostalCode\",\"doc\":\"Postal code of the user\'s address.\",\"t" +
				"ype\":\"string\"}]}},{\"name\":\"Hobbies\",\"doc\":\"A list of the user\'s hobbies.\",\"type\"" +
				":{\"type\":\"array\",\"items\":\"string\"}},{\"name\":\"Attributes\",\"doc\":\"A map of additio" +
				"nal attributes related to the user, represented as key-value pairs.\",\"type\":{\"ty" +
				"pe\":\"map\",\"values\":\"string\"}},{\"name\":\"MiddleInitial\",\"doc\":\"Optional middle ini" +
				"tial of the user. Can be null.\",\"default\":null,\"type\":[\"null\",\"int\"]},{\"name\":\"L" +
				"astLogin\",\"doc\":\"The timestamp of the user\'s last login. Can be null.\",\"default\"" +
				":null,\"type\":[\"null\",{\"type\":\"long\",\"logicalType\":\"timestamp-millis\"}]},{\"name\":" +
				"\"UserIdentifier\",\"doc\":\"A globally unique identifier for the user.\",\"type\":{\"typ" +
				"e\":\"fixed\",\"name\":\"guid\",\"namespace\":\"YourNamespace\",\"size\":16}}]}");
		/// <summary>
		/// Unique identifier for the user.
		/// </summary>
		private int _Id;
		/// <summary>
		/// A larger unique identifier for systems that require larger ID ranges.
		/// </summary>
		private long _BigId;
		/// <summary>
		/// A smaller ID, used in specific contexts where integer IDs are sufficient.
		/// </summary>
		private int _SmallId;
		/// <summary>
		/// The age of the user.
		/// </summary>
		private int _Age;
		/// <summary>
		/// The user's height in meters.
		/// </summary>
		private float _HeightInMeters;
		/// <summary>
		/// The user's weight in kilograms.
		/// </summary>
		private double _WeightInKg;
		/// <summary>
		/// The user's salary as a precise decimal value.
		/// </summary>
		private byte[] _Salary;
		/// <summary>
		/// Indicates if the user is active or not.
		/// </summary>
		private bool _IsActive;
		/// <summary>
		/// The gender of the user, represented as a single character.
		/// </summary>
		private string _Gender;
		/// <summary>
		/// The user's first name.
		/// </summary>
		private string _FirstName;
		/// <summary>
		/// The user's last name.
		/// </summary>
		private string _LastName;
		/// <summary>
		/// The user's date of birth, stored as a timestamp in milliseconds.
		/// </summary>
		private System.DateTime _DateOfBirth;
		/// <summary>
		/// The number of working hours the user is assigned.
		/// </summary>
		private long _WorkingHours;
		/// <summary>
		/// The user's role in the system.
		/// </summary>
		private YourNamespace.UserRole _Role;
		/// <summary>
		/// The user's address information.
		/// </summary>
		private YourNamespace.Address _UserAddress;
		/// <summary>
		/// A list of the user's hobbies.
		/// </summary>
		private IList<System.String> _Hobbies;
		/// <summary>
		/// A map of additional attributes related to the user, represented as key-value pairs.
		/// </summary>
		private IDictionary<string,System.String> _Attributes;
		/// <summary>
		/// Optional middle initial of the user. Can be null.
		/// </summary>
		private System.Nullable<System.Int32> _MiddleInitial;
		/// <summary>
		/// The timestamp of the user's last login. Can be null.
		/// </summary>
		private System.Nullable<System.DateTime> _LastLogin;
		/// <summary>
		/// A globally unique identifier for the user.
		/// </summary>
		private YourNamespace.guid _UserIdentifier;
		public virtual global::Avro.Schema Schema
		{
			get
			{
				return User._SCHEMA;
			}
		}
		/// <summary>
		/// Unique identifier for the user.
		/// </summary>
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				this._Id = value;
			}
		}
		/// <summary>
		/// A larger unique identifier for systems that require larger ID ranges.
		/// </summary>
		public long BigId
		{
			get
			{
				return this._BigId;
			}
			set
			{
				this._BigId = value;
			}
		}
		/// <summary>
		/// A smaller ID, used in specific contexts where integer IDs are sufficient.
		/// </summary>
		public int SmallId
		{
			get
			{
				return this._SmallId;
			}
			set
			{
				this._SmallId = value;
			}
		}
		/// <summary>
		/// The age of the user.
		/// </summary>
		public int Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				this._Age = value;
			}
		}
		/// <summary>
		/// The user's height in meters.
		/// </summary>
		public float HeightInMeters
		{
			get
			{
				return this._HeightInMeters;
			}
			set
			{
				this._HeightInMeters = value;
			}
		}
		/// <summary>
		/// The user's weight in kilograms.
		/// </summary>
		public double WeightInKg
		{
			get
			{
				return this._WeightInKg;
			}
			set
			{
				this._WeightInKg = value;
			}
		}
		/// <summary>
		/// The user's salary as a precise decimal value.
		/// </summary>
		public byte[] Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				this._Salary = value;
			}
		}
		/// <summary>
		/// Indicates if the user is active or not.
		/// </summary>
		public bool IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				this._IsActive = value;
			}
		}
		/// <summary>
		/// The gender of the user, represented as a single character.
		/// </summary>
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				this._Gender = value;
			}
		}
		/// <summary>
		/// The user's first name.
		/// </summary>
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				this._FirstName = value;
			}
		}
		/// <summary>
		/// The user's last name.
		/// </summary>
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				this._LastName = value;
			}
		}
		/// <summary>
		/// The user's date of birth, stored as a timestamp in milliseconds.
		/// </summary>
		public System.DateTime DateOfBirth
		{
			get
			{
				return this._DateOfBirth;
			}
			set
			{
				this._DateOfBirth = value;
			}
		}
		/// <summary>
		/// The number of working hours the user is assigned.
		/// </summary>
		public long WorkingHours
		{
			get
			{
				return this._WorkingHours;
			}
			set
			{
				this._WorkingHours = value;
			}
		}
		/// <summary>
		/// The user's role in the system.
		/// </summary>
		public YourNamespace.UserRole Role
		{
			get
			{
				return this._Role;
			}
			set
			{
				this._Role = value;
			}
		}
		/// <summary>
		/// The user's address information.
		/// </summary>
		public YourNamespace.Address UserAddress
		{
			get
			{
				return this._UserAddress;
			}
			set
			{
				this._UserAddress = value;
			}
		}
		/// <summary>
		/// A list of the user's hobbies.
		/// </summary>
		public IList<System.String> Hobbies
		{
			get
			{
				return this._Hobbies;
			}
			set
			{
				this._Hobbies = value;
			}
		}
		/// <summary>
		/// A map of additional attributes related to the user, represented as key-value pairs.
		/// </summary>
		public IDictionary<string,System.String> Attributes
		{
			get
			{
				return this._Attributes;
			}
			set
			{
				this._Attributes = value;
			}
		}
		/// <summary>
		/// Optional middle initial of the user. Can be null.
		/// </summary>
		public System.Nullable<System.Int32> MiddleInitial
		{
			get
			{
				return this._MiddleInitial;
			}
			set
			{
				this._MiddleInitial = value;
			}
		}
		/// <summary>
		/// The timestamp of the user's last login. Can be null.
		/// </summary>
		public System.Nullable<System.DateTime> LastLogin
		{
			get
			{
				return this._LastLogin;
			}
			set
			{
				this._LastLogin = value;
			}
		}
		/// <summary>
		/// A globally unique identifier for the user.
		/// </summary>
		public YourNamespace.guid UserIdentifier
		{
			get
			{
				return this._UserIdentifier;
			}
			set
			{
				this._UserIdentifier = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.Id;
			case 1: return this.BigId;
			case 2: return this.SmallId;
			case 3: return this.Age;
			case 4: return this.HeightInMeters;
			case 5: return this.WeightInKg;
			case 6: return this.Salary;
			case 7: return this.IsActive;
			case 8: return this.Gender;
			case 9: return this.FirstName;
			case 10: return this.LastName;
			case 11: return this.DateOfBirth;
			case 12: return this.WorkingHours;
			case 13: return this.Role;
			case 14: return this.UserAddress;
			case 15: return this.Hobbies;
			case 16: return this.Attributes;
			case 17: return this.MiddleInitial;
			case 18: return this.LastLogin;
			case 19: return this.UserIdentifier;
			default: throw new global::Avro.AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.Id = (System.Int32)fieldValue; break;
			case 1: this.BigId = (System.Int64)fieldValue; break;
			case 2: this.SmallId = (System.Int32)fieldValue; break;
			case 3: this.Age = (System.Int32)fieldValue; break;
			case 4: this.HeightInMeters = (System.Single)fieldValue; break;
			case 5: this.WeightInKg = (System.Double)fieldValue; break;
			case 6: this.Salary = (System.Byte[])fieldValue; break;
			case 7: this.IsActive = (System.Boolean)fieldValue; break;
			case 8: this.Gender = (System.String)fieldValue; break;
			case 9: this.FirstName = (System.String)fieldValue; break;
			case 10: this.LastName = (System.String)fieldValue; break;
			case 11: this.DateOfBirth = (System.DateTime)fieldValue; break;
			case 12: this.WorkingHours = (System.Int64)fieldValue; break;
			case 13: this.Role = (YourNamespace.UserRole)fieldValue; break;
			case 14: this.UserAddress = (YourNamespace.Address)fieldValue; break;
			case 15: this.Hobbies = (IList<System.String>)fieldValue; break;
			case 16: this.Attributes = (IDictionary<string,System.String>)fieldValue; break;
			case 17: this.MiddleInitial = (System.Nullable<System.Int32>)fieldValue; break;
			case 18: this.LastLogin = (System.Nullable<System.DateTime>)fieldValue; break;
			case 19: this.UserIdentifier = (YourNamespace.guid)fieldValue; break;
			default: throw new global::Avro.AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
