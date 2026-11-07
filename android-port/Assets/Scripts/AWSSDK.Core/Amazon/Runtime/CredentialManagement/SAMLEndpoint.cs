using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.CredentialManagement
{
	[Token(Token = "0x200013A")]
	public class SAMLEndpoint
	{
		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x10")]
		private SAMLAuthenticationType DefaultAuthenticationType;

		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27048", Offset = "0x27048")]
		private string Name__BackingField;

		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27058", Offset = "0x27058")]
		private Uri EndpointUri__BackingField;

		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27068", Offset = "0x27068")]
		private SAMLAuthenticationType AuthenticationType__BackingField;

		[Token(Token = "0x170002A2")]
		public string Name
		{
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x126AEC0", Offset = "0x126AEC0", VA = "0x126AEC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29E5C", Offset = "0x29E5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x126AEC8", Offset = "0x126AEC8", VA = "0x126AEC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29E6C", Offset = "0x29E6C")]
			private set
			{
			}
		}

		[Token(Token = "0x170002A3")]
		public Uri EndpointUri
		{
			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x126AED0", Offset = "0x126AED0", VA = "0x126AED0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29E7C", Offset = "0x29E7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x126AED8", Offset = "0x126AED8", VA = "0x126AED8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29E8C", Offset = "0x29E8C")]
			private set
			{
			}
		}

		[Token(Token = "0x170002A4")]
		public SAMLAuthenticationType AuthenticationType
		{
			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x126AEE0", Offset = "0x126AEE0", VA = "0x126AEE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29E9C", Offset = "0x29E9C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x126AEE8", Offset = "0x126AEE8", VA = "0x126AEE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29EAC", Offset = "0x29EAC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x126AEF0", Offset = "0x126AEF0", VA = "0x126AEF0")]
		internal SAMLEndpoint(string name, string endpointUri, string authenticationType)
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x126B188", Offset = "0x126B188", VA = "0x126B188")]
		public SAMLEndpoint(string name, Uri endpointUri)
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x126B1D4", Offset = "0x126B1D4", VA = "0x126B1D4")]
		public SAMLEndpoint(string name, Uri endpointUri, SAMLAuthenticationType authenticationType)
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x126B080", Offset = "0x126B080", VA = "0x126B080")]
		private void SetProperties(string name, Uri endpointUri, SAMLAuthenticationType authenticationType)
		{
		}
	}
}
