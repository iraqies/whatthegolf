using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.SAML
{
	[Token(Token = "0x2000011")]
	public class SAMLAssertion
	{
		[Token(Token = "0x400001A")]
		private const string AssertionNamespace = "urn:oasis:names:tc:SAML:2.0:assertion";

		[Token(Token = "0x400001B")]
		private const string RoleXPath = "//response:Attribute[@Name='https://aws.amazon.com/SAML/Attributes/Role']";

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30A6C", Offset = "0x30A6C")]
		private string AssertionDocument__BackingField;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30A7C", Offset = "0x30A7C")]
		private IDictionary<string, string> RoleSet__BackingField;

		[Token(Token = "0x17000008")]
		public string AssertionDocument
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x12E456C", Offset = "0x12E456C", VA = "0x12E456C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30AEC", Offset = "0x30AEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x12E4574", Offset = "0x12E4574", VA = "0x12E4574")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30AFC", Offset = "0x30AFC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public IDictionary<string, string> RoleSet
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x12E457C", Offset = "0x12E457C", VA = "0x12E457C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30B0C", Offset = "0x30B0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x12E4584", Offset = "0x12E4584", VA = "0x12E4584")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30B1C", Offset = "0x30B1C")]
			private set
			{
			}
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x12D0854", Offset = "0x12D0854", VA = "0x12D0854")]
		public SAMLImmutableCredentials GetRoleCredentials(IAmazonSecurityTokenService stsClient, string principalAndRoleArns, TimeSpan duration)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x12D03DC", Offset = "0x12D03DC", VA = "0x12D03DC")]
		internal SAMLAssertion(string assertion)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x12E45F8", Offset = "0x12E45F8", VA = "0x12E45F8")]
		private IDictionary<string, string> ExtractRoleData()
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x12E458C", Offset = "0x12E458C", VA = "0x12E458C")]
		private static bool IsSamlProvider(string chunk)
		{
			return default;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x12E4F4C", Offset = "0x12E4F4C", VA = "0x12E4F4C")]
		private static string ExtractRoleName(string chunk)
		{
			return null;
		}
	}
}
