using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000072")]
	public class CompromisedCredentialsRiskConfigurationType
	{
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x10")]
		private CompromisedCredentialsActionsType _actions;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x18")]
		private List<string> _eventFilter;

		[Token(Token = "0x170000AC")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C858", Offset = "0x1C858")]
		public CompromisedCredentialsActionsType Actions
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x10E4140", Offset = "0x10E4140", VA = "0x10E4140")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x10E4148", Offset = "0x10E4148", VA = "0x10E4148")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public List<string> EventFilter
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x10E4160", Offset = "0x10E4160", VA = "0x10E4160")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x10E4168", Offset = "0x10E4168", VA = "0x10E4168")]
			set
			{
			}
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x10E4150", Offset = "0x10E4150", VA = "0x10E4150")]
		internal bool IsSetActions()
		{
			return default;
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x10E4170", Offset = "0x10E4170", VA = "0x10E4170")]
		internal bool IsSetEventFilter()
		{
			return default;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x10E41C8", Offset = "0x10E41C8", VA = "0x10E41C8")]
		public CompromisedCredentialsRiskConfigurationType()
		{
		}
	}
}
