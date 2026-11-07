using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x200005F")]
	internal class Marker<U>
	{
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x0")]
		private List<U> data;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x0")]
		private string nextToken;

		[Token(Token = "0x170000AE")]
		internal List<U> Data
		{
			[Token(Token = "0x6000364")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		internal string NextToken
		{
			[Token(Token = "0x6000365")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000363")]
		internal Marker(List<U> data, string nextToken)
		{
		}
	}
}
