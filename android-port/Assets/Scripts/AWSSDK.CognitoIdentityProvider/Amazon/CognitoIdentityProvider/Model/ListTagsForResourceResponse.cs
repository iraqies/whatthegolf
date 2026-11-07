using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000E5")]
	public class ListTagsForResourceResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, string> _tags;

		[Token(Token = "0x170001AF")]
		public Dictionary<string, string> Tags
		{
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x1133F04", Offset = "0x1133F04", VA = "0x1133F04")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x1133F0C", Offset = "0x1133F0C", VA = "0x1133F0C")]
			set
			{
			}
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x1133F14", Offset = "0x1133F14", VA = "0x1133F14")]
		internal bool IsSetTags()
		{
			return default;
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x1133F70", Offset = "0x1133F70", VA = "0x1133F70")]
		public ListTagsForResourceResponse()
		{
		}
	}
}
