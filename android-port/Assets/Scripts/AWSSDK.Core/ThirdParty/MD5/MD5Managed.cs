using System.Security.Cryptography;
using Il2CppDummyDll;

namespace ThirdParty.MD5
{
	[Token(Token = "0x2000015")]
	public class MD5Managed : HashAlgorithm
	{
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x28")]
		private byte[] _data;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x30")]
		private ABCDStruct _abcd;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x40")]
		private long _totalLength;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x48")]
		private int _dataSize;

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x123CC30", Offset = "0x123CC30", VA = "0x123CC30")]
		public MD5Managed()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x123CC64", Offset = "0x123CC64", VA = "0x123CC64", Slot = "18")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x123CCE8", Offset = "0x123CCE8", VA = "0x123CCE8")]
		public void TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x123CCF8", Offset = "0x123CCF8", VA = "0x123CCF8")]
		public new byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x123CD34", Offset = "0x123CD34", VA = "0x123CD34", Slot = "19")]
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x123CE4C", Offset = "0x123CE4C", VA = "0x123CE4C", Slot = "20")]
		protected override byte[] HashFinal()
		{
			return null;
		}
	}
}
