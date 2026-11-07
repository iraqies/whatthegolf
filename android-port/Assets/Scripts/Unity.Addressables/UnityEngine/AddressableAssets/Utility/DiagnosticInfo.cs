using Il2CppDummyDll;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.Diagnostics;

namespace UnityEngine.AddressableAssets.Utility
{
	[Token(Token = "0x2000044")]
	internal class DiagnosticInfo
	{
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x10")]
		public string DisplayName;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x18")]
		public int ObjectId;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x20")]
		public int[] Dependencies;

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2A2E228", Offset = "0x2A2E228", VA = "0x2A2E228")]
		public DiagnosticEvent CreateEvent(string category, ResourceManager.DiagnosticEventType eventType, int frame, int val)
		{
			return default;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2A2E270", Offset = "0x2A2E270", VA = "0x2A2E270")]
		public DiagnosticInfo()
		{
		}
	}
}
