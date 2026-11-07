using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace UnityEngine.AddressableAssets
{
	[Token(Token = "0x200000D")]
	public class InvalidKeyException : Exception
	{
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B129C", Offset = "0x1B129C")]
		private object Key__BackingField;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B12AC", Offset = "0x1B12AC")]
		private Type Type__BackingField;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B12BC", Offset = "0x1B12BC")]
		private readonly Addressables.MergeMode? MergeMode__BackingField;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0xA0")]
		private AddressablesImpl m_Addressables;

		[Token(Token = "0x4000012")]
		private const string BaseInvalidKeyMessageFormat = "{0}, Key={1}, Type={2}";

		[Token(Token = "0x1700000A")]
		public object Key
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x2A333A0", Offset = "0x2A333A0", VA = "0x2A333A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1B94", Offset = "0x1B1B94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2A333A8", Offset = "0x2A333A8", VA = "0x2A333A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1BA4", Offset = "0x1B1BA4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public Type Type
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x2A333B0", Offset = "0x2A333B0", VA = "0x2A333B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1BB4", Offset = "0x1B1BB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x2A333B8", Offset = "0x2A333B8", VA = "0x2A333B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1BC4", Offset = "0x1B1BC4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Addressables.MergeMode? MergeMode
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2A333C0", Offset = "0x2A333C0", VA = "0x2A333C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1BD4", Offset = "0x1B1BD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public override string Message
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x2A3385C", Offset = "0x2A3385C", VA = "0x2A3385C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2A333C8", Offset = "0x2A333C8", VA = "0x2A333C8")]
		public InvalidKeyException(object key)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2A334B8", Offset = "0x2A334B8", VA = "0x2A334B8")]
		public InvalidKeyException(object key, Type type)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2A22C84", Offset = "0x2A22C84", VA = "0x2A22C84")]
		internal InvalidKeyException(object key, Type type, AddressablesImpl addr)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2A3353C", Offset = "0x2A3353C", VA = "0x2A3353C")]
		public InvalidKeyException(object key, Type type, Addressables.MergeMode mergeMode)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2A23C7C", Offset = "0x2A23C7C", VA = "0x2A23C7C")]
		internal InvalidKeyException(object key, Type type, Addressables.MergeMode mergeMode, AddressablesImpl addr)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2A335FC", Offset = "0x2A335FC", VA = "0x2A335FC")]
		public InvalidKeyException()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2A33678", Offset = "0x2A33678", VA = "0x2A33678")]
		public InvalidKeyException(string message)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2A33704", Offset = "0x2A33704", VA = "0x2A33704")]
		public InvalidKeyException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2A337A8", Offset = "0x2A337A8", VA = "0x2A337A8")]
		protected InvalidKeyException(SerializationInfo message, StreamingContext context)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2A33EE8", Offset = "0x2A33EE8", VA = "0x2A33EE8")]
		private string GetMessageForSingleKey(string keyString)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2A35AC0", Offset = "0x2A35AC0", VA = "0x2A35AC0")]
		private string GetNotFoundMessage(string keyString)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2A35B2C", Offset = "0x2A35B2C", VA = "0x2A35B2C")]
		private string GetTypeNotAssignableMessage(string keyString, HashSet<Type> typesAvailableForKey)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2A35E1C", Offset = "0x2A35E1C", VA = "0x2A35E1C")]
		private string GetMultipleAssignableTypesMessage(string keyString, HashSet<Type> typesAvailableForKey)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2A343A8", Offset = "0x2A343A8", VA = "0x2A343A8")]
		private string GetMessageforMergeKeys(List<string> keys)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2A35354", Offset = "0x2A35354", VA = "0x2A35354")]
		private HashSet<Type> GetTypesForKey(string keyString)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2A36154", Offset = "0x2A36154", VA = "0x2A36154")]
		private bool GetTypeToKeys(string key, Dictionary<Type, List<string>> typeToKeys)
		{
			return default;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2A33FC8", Offset = "0x2A33FC8", VA = "0x2A33FC8")]
		private string GetCSVString(IEnumerable<string> enumerator, string prefixSingle, string prefixPlural)
		{
			return null;
		}
	}
}
