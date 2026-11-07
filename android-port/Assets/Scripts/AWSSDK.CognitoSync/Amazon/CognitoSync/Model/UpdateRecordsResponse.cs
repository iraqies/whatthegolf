using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000040")]
	public class UpdateRecordsResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x28")]
		private List<Record> _records;

		[Token(Token = "0x17000079")]
		public List<Record> Records
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x11ADE00", Offset = "0x11ADE00", VA = "0x11ADE00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x11ADE08", Offset = "0x11ADE08", VA = "0x11ADE08")]
			set
			{
			}
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x11ADE10", Offset = "0x11ADE10", VA = "0x11ADE10")]
		internal bool IsSetRecords()
		{
			return default;
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x11ADE68", Offset = "0x11ADE68", VA = "0x11ADE68")]
		public UpdateRecordsResponse()
		{
		}
	}
}
