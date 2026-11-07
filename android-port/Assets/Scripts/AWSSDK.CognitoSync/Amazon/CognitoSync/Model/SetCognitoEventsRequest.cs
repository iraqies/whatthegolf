using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000036")]
	public class SetCognitoEventsRequest : AmazonCognitoSyncRequest
	{
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, string> _events;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x38")]
		private string _identityPoolId;

		[Token(Token = "0x17000062")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24E1C", Offset = "0x24E1C")]
		public Dictionary<string, string> Events
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x11A73B8", Offset = "0x11A73B8", VA = "0x11A73B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x11A73C0", Offset = "0x11A73C0", VA = "0x11A73C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24E5C", Offset = "0x24E5C")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x11A7424", Offset = "0x11A7424", VA = "0x11A7424")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x11A742C", Offset = "0x11A742C", VA = "0x11A742C")]
			set
			{
			}
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x11A73C8", Offset = "0x11A73C8", VA = "0x11A73C8")]
		internal bool IsSetEvents()
		{
			return default;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x11A7434", Offset = "0x11A7434", VA = "0x11A7434")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x11A7444", Offset = "0x11A7444", VA = "0x11A7444")]
		public SetCognitoEventsRequest()
		{
		}
	}
}
