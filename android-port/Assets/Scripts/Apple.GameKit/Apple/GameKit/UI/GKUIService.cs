using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Apple.Core.Runtime;

namespace Apple.GameKit.UI
{
	public static class GKUIService
	{
		private static TaskCompletionSource<bool> _onShowDialogTCS;

		[PreserveSig]
		private static extern void GameKitWrapper_ShowDialog(int dialogViewState, SuccessCallback onSuccess);

		public static Task ShowDialog(GKGameCenterViewControllerState dialogViewState)
		{
			return null;
		}

		private static void OnShowDialogComplete()
		{
		}
	}
}
