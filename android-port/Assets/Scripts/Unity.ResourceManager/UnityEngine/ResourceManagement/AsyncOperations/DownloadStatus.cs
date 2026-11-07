using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	[Token(Token = "0x2000073")]
	public struct DownloadStatus
	{
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x0")]
		public long TotalBytes;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x8")]
		public long DownloadedBytes;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x10")]
		public bool IsDone;

		[Token(Token = "0x170000C0")]
		public float Percent
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x2A660C4", Offset = "0x2A660C4", VA = "0x2A660C4")]
			get
			{
				return default;
			}
		}
	}
}
