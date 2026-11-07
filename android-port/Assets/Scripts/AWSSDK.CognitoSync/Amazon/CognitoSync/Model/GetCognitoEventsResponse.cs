using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200001D")]
	public class GetCognitoEventsResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, string> _events;

		[Token(Token = "0x17000025")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x247DC", Offset = "0x247DC")]
		public Dictionary<string, string> Events
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x119AC34", Offset = "0x119AC34", VA = "0x119AC34")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x119AC3C", Offset = "0x119AC3C", VA = "0x119AC3C")]
			set
			{
			}
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x119AC44", Offset = "0x119AC44", VA = "0x119AC44")]
		internal bool IsSetEvents()
		{
			return default;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x119ACA0", Offset = "0x119ACA0", VA = "0x119ACA0")]
		public GetCognitoEventsResponse()
		{
		}
	}
}
