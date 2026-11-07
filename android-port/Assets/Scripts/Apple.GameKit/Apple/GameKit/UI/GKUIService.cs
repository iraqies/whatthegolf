using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Apple.Core.Runtime;
using Il2CppDummyDll;

namespace Apple.GameKit.UI
{
	[Token(Token = "0x2000005")]
	public static class GKUIService
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static TaskCompletionSource<bool> _onShowDialogTCS;

		[PreserveSig]
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x12E9BE0", Offset = "0x12E9BE0", VA = "0x12E9BE0")]
		private static extern void GameKitWrapper_ShowDialog(int dialogViewState, SuccessCallback onSuccess);

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x12E9C0C", Offset = "0x12E9C0C", VA = "0x12E9C0C")]
		public static Task ShowDialog(GKGameCenterViewControllerState dialogViewState)
		{
			return null;
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x12E9B60", Offset = "0x12E9B60", VA = "0x12E9B60")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x32B1C", Offset = "0x32B1C")]
		private static void OnShowDialogComplete()
		{
		}
	}
}
