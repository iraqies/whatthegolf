using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace UnityAsyncAwaitUtil
{
	public class AsyncUtilTests : MonoBehaviour
	{
		private const string AssetBundleSampleUrl = "http://www.stevevermeulen.com/wp-content/uploads/2017/09/teapot.unity3d";

		private const string AssetBundleSampleAssetName = "Teapot";

		[SerializeField]
		private TestButtonHandler.Settings _buttonSettings;

		private TestButtonHandler _buttonHandler;

		public void Awake()
		{
		}

		public void OnGUI()
		{
		}

		private IEnumerator RunAsyncFromCoroutineTest()
		{
			return null;
		}

		private Task RunMultipleThreadsTestAsync()
		{
			return null;
		}

		private Task RunMultipleThreadsTestAsyncWait()
		{
			return null;
		}

		private void PrintCurrentThreadContext(string prefix = null)
		{
		}

		private Task RunAsyncFromCoroutineTest2()
		{
			return null;
		}

		private Task RunWwwAsync()
		{
			return null;
		}

		private Task RunOpenNotepadTestAsync()
		{
			return null;
		}

		private Task RunUnhandledExceptionTestAsync()
		{
			return null;
		}

		private Task RunTryCatchExceptionTestAsync()
		{
			return null;
		}

		private Task NestedRunAsync()
		{
			return null;
		}

		private Task WaitThenThrowException()
		{
			return null;
		}

		private Task RunAsyncOperationAsync()
		{
			return null;
		}

		private Task InstantiateAssetBundleAsync(string abUrl, string assetName)
		{
			return null;
		}

		private Task<byte[]> DownloadRawDataAsync(string url)
		{
			return null;
		}

		private Task RunIEnumeratorTryCatchExceptionAsync()
		{
			return null;
		}

		private Task RunIEnumeratorUnhandledExceptionAsync()
		{
			return null;
		}

		private IEnumerator WaitThenThrow()
		{
			return null;
		}

		private IEnumerator WaitThenThrowNested()
		{
			return null;
		}

		private Task RunIEnumeratorStringTestAsync()
		{
			return null;
		}

		private Task RunIEnumeratorUntypedStringTestAsync()
		{
			return null;
		}

		private Task RunIEnumeratorTestAsync()
		{
			return null;
		}

		private IEnumerator<string> WaitForString()
		{
			return null;
		}

		private IEnumerator WaitForStringUntyped()
		{
			return null;
		}

		private IEnumerator WaitABit()
		{
			return null;
		}

		private Task RunReturnValueTestAsync()
		{
			return null;
		}

		private Task<string> GetValueExampleAsync()
		{
			return null;
		}

		private Task RunAwaitSecondsTestAsync()
		{
			return null;
		}
	}
}
