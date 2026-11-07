using System.IO;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001DE")]
	public class NonDisposingWrapperStream : WrapperStream
	{
		[Token(Token = "0x6000EB8")]
		[Address(RVA = "0x12432E0", Offset = "0x12432E0", VA = "0x12432E0")]
		public NonDisposingWrapperStream(Stream baseStream)
		{
		}

		[Token(Token = "0x6000EB9")]
		[Address(RVA = "0x12432E8", Offset = "0x12432E8", VA = "0x12432E8", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}
	}
}
