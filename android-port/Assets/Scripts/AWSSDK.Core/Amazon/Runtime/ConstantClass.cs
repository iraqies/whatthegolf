using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000AA")]
	public class ConstantClass
	{
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly object staticFieldsLock;

		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<Type, Dictionary<string, ConstantClass>> staticFields;

		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26838", Offset = "0x26838")]
		private string Value__BackingField;

		[Token(Token = "0x170001A1")]
		public string Value
		{
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x11E4494", Offset = "0x11E4494", VA = "0x11E4494")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28D4C", Offset = "0x28D4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x11E449C", Offset = "0x11E449C", VA = "0x11E449C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28D5C", Offset = "0x28D5C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x11E4468", Offset = "0x11E4468", VA = "0x11E4468")]
		protected ConstantClass(string value)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x11E44A4", Offset = "0x11E44A4", VA = "0x11E44A4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x11E463C", Offset = "0x11E463C", VA = "0x11E463C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x11E465C", Offset = "0x11E465C", VA = "0x11E465C")]
		public static implicit operator string(ConstantClass value)
		{
			return null;
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x11E44C4", Offset = "0x11E44C4", VA = "0x11E44C4")]
		internal ConstantClass Intern()
		{
			return null;
		}

		[Token(Token = "0x600066E")]
		protected static T FindValue<T>(string value) where T : ConstantClass
		{
			return null;
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x11E4720", Offset = "0x11E4720", VA = "0x11E4720")]
		private static void LoadFields(Type t)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x11E4F28", Offset = "0x11E4F28", VA = "0x11E4F28", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x11E4F48", Offset = "0x11E4F48", VA = "0x11E4F48", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x11E503C", Offset = "0x11E503C", VA = "0x11E503C", Slot = "4")]
		public virtual bool Equals(ConstantClass obj)
		{
			return default;
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x11E5118", Offset = "0x11E5118", VA = "0x11E5118", Slot = "5")]
		protected virtual bool Equals(string value)
		{
			return default;
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x11E4700", Offset = "0x11E4700", VA = "0x11E4700")]
		public static bool operator ==(ConstantClass a, ConstantClass b)
		{
			return default;
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x11E51DC", Offset = "0x11E51DC", VA = "0x11E51DC")]
		public static bool operator !=(ConstantClass a, ConstantClass b)
		{
			return default;
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x11E5280", Offset = "0x11E5280", VA = "0x11E5280")]
		public static bool operator ==(ConstantClass a, string b)
		{
			return default;
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x11E52A4", Offset = "0x11E52A4", VA = "0x11E52A4")]
		public static bool operator ==(string a, ConstantClass b)
		{
			return default;
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x11E533C", Offset = "0x11E533C", VA = "0x11E533C")]
		public static bool operator !=(ConstantClass a, string b)
		{
			return default;
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x11E53CC", Offset = "0x11E53CC", VA = "0x11E53CC")]
		public static bool operator !=(string a, ConstantClass b)
		{
			return default;
		}
	}
}
