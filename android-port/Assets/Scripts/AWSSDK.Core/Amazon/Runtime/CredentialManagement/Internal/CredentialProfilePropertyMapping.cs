using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace Amazon.Runtime.CredentialManagement.Internal
{
	[Token(Token = "0x200013E")]
	public class CredentialProfilePropertyMapping
	{
		[Serializable]
		[Token(Token = "0x200013F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25C34", Offset = "0x25C34")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40004D1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40004D2")]
			[FieldOffset(Offset = "0x8")]
			public static Func<string, bool> _003C_003E9__4_0;

			[Token(Token = "0x40004D3")]
			[FieldOffset(Offset = "0x10")]
			public static Func<PropertyInfo, string> _003C_003E9__10_0;

			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x1289B10", Offset = "0x1289B10", VA = "0x1289B10")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x1289B18", Offset = "0x1289B18", VA = "0x1289B18")]
			internal bool _003C_002Ector_003Eb__4_0(string v)
			{
				return default;
			}

			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x1289B38", Offset = "0x1289B38", VA = "0x1289B38")]
			internal string _003CConvert_003Eb__10_0(PropertyInfo p)
			{
				return null;
			}

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x1289B5C", Offset = "0x1289B5C", VA = "0x1289B5C")]
			internal string _003C_002Ecctor_003Eb__11_0(PropertyInfo p)
			{
				return null;
			}
		}

		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<string> TypePropertySet;

		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly PropertyInfo[] CredentialProfileReflectionProperties;

		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, string> _nameMapping;

		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x18")]
		private readonly HashSet<string> _mappedNames;

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x11E92C0", Offset = "0x11E92C0", VA = "0x11E92C0")]
		public CredentialProfilePropertyMapping(Dictionary<string, string> nameMapping)
		{
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x11E966C", Offset = "0x11E966C", VA = "0x11E966C")]
		public void ExtractProfileParts(Dictionary<string, string> profileDictionary, HashSet<string> reservedKeys, out CredentialProfileOptions profileOptions, out Dictionary<string, string> userProperties)
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x11E9694", Offset = "0x11E9694", VA = "0x11E9694")]
		public void ExtractProfileParts(Dictionary<string, string> profileDictionary, HashSet<string> reservedKeys, out CredentialProfileOptions profileOptions, out Dictionary<string, string> reservedProperties, out Dictionary<string, string> userProperties)
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x11E9A98", Offset = "0x11E9A98", VA = "0x11E9A98")]
		public Dictionary<string, string> CombineProfileParts(CredentialProfileOptions profileOptions, HashSet<string> reservedPropertyNames, Dictionary<string, string> reservedProperties, Dictionary<string, string> userProperties)
		{
			return null;
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x11EA144", Offset = "0x11EA144", VA = "0x11EA144")]
		private static void ValidateNoReservedProperties(HashSet<string> reservedPropertyNames, Dictionary<string, string> userProperties)
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x11E9EAC", Offset = "0x11E9EAC", VA = "0x11E9EAC")]
		private void ValidateNoProfileOptionsProperties(Dictionary<string, string> userProperties)
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x11EA494", Offset = "0x11EA494", VA = "0x11EA494")]
		private Dictionary<string, string> Convert(CredentialProfileOptions profileOptions)
		{
			return null;
		}
	}
}
