using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200003E")]
	public class ListTagsForResourceResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, string> _tags;

		[Token(Token = "0x1700006D")]
		public Dictionary<string, string> Tags
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x1091780", Offset = "0x1091780", VA = "0x1091780")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x1091788", Offset = "0x1091788", VA = "0x1091788")]
			set
			{
			}
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1091790", Offset = "0x1091790", VA = "0x1091790")]
		internal bool IsSetTags()
		{
			return default;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x10917EC", Offset = "0x10917EC", VA = "0x10917EC")]
		public ListTagsForResourceResponse()
		{
		}
	}
}
