using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.iOS;

[Token(Token = "0x20003A4")]
public class ODRDownloadManager
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20003A5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F6EC", Offset = "0x3F6EC")]
	private struct _003CDownloadBundles_003Ed__19 : IAsyncStateMachine
	{
		[Token(Token = "0x4001427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<ODRDownloadResult> _003C_003Et__builder;

		[Token(Token = "0x4001429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> resourceNames;

		[Token(Token = "0x400142A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ODRDownloadManager _003C_003E4__this;

		[Token(Token = "0x400142B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool showProgressBar;

		[Token(Token = "0x400142C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int _003Cindex_003E5__2;

		[Token(Token = "0x400142D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<ODRDownloadResult> _003C_003Eu__1;

		[Token(Token = "0x6001156")]
		[Address(RVA = "0x1809BDC", Offset = "0x1809BDC", VA = "0x1809BDC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6001157")]
		[Address(RVA = "0x1809F78", Offset = "0x1809F78", VA = "0x1809F78", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20003A6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F6FC", Offset = "0x3F6FC")]
	private struct _003CDownloadBundle_003Ed__20 : IAsyncStateMachine
	{
		[Token(Token = "0x400142E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400142F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<ODRDownloadResult> _003C_003Et__builder;

		[Token(Token = "0x4001430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ODRDownloadManager _003C_003E4__this;

		[Token(Token = "0x4001431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string resourceName;

		[Token(Token = "0x4001432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool showProgressBar;

		[Token(Token = "0x4001433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int downloadNumber;

		[Token(Token = "0x4001434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int downloadCount;

		[Token(Token = "0x4001435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string _003CbuildVersionString_003E5__2;

		[Token(Token = "0x4001436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OnDemandResourcesRequest _003ConDemandResourcesRequest_003E5__3;

		[Token(Token = "0x4001437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6001158")]
		[Address(RVA = "0x1808EE8", Offset = "0x1808EE8", VA = "0x1808EE8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6001159")]
		[Address(RVA = "0x1809B80", Offset = "0x1809B80", VA = "0x1809B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20003A7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F70C", Offset = "0x3F70C")]
	private struct _003CAwaitDownload_003Ed__22 : IAsyncStateMachine
	{
		[Token(Token = "0x4001438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400143A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool showProgressBar;

		[Token(Token = "0x400143B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OnDemandResourcesRequest onDemandResourcesRequest;

		[Token(Token = "0x400143C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ODRDownloadManager _003C_003E4__this;

		[Token(Token = "0x400143D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int downloadCount;

		[Token(Token = "0x400143E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int downloadNumber;

		[Token(Token = "0x400143F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private object _003C_003Eu__1;

		[Token(Token = "0x4001440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AsyncOperationHandle<GameObject> _003CviewHandle_003E5__2;

		[Token(Token = "0x4001441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TaskAwaiter<GameObject> _003C_003Eu__2;

		[Token(Token = "0x600115A")]
		[Address(RVA = "0x180872C", Offset = "0x180872C", VA = "0x180872C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600115B")]
		[Address(RVA = "0x1808EDC", Offset = "0x1808EDC", VA = "0x1808EDC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4001421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ODRDownloadManager _instance;

	[Token(Token = "0x4001422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<string> downloadsInProgress;

	[Token(Token = "0x4001423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ODRVersionManager _versionManager;

	[Token(Token = "0x4001424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ODRDownloadView view;

	[Token(Token = "0x4001425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool cancelled;

	[Token(Token = "0x4001426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<uint, uint> replacementStateMap;

	[Token(Token = "0x1700020A")]
	public static ODRDownloadManager Instance
	{
		[Token(Token = "0x6001147")]
		[Address(RVA = "0x158FEB8", Offset = "0x158FEB8", VA = "0x158FEB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700020B")]
	public static string CachePath
	{
		[Token(Token = "0x6001148")]
		[Address(RVA = "0x1590060", Offset = "0x1590060", VA = "0x1590060")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700020C")]
	private ODRVersionManager VersionManager
	{
		[Token(Token = "0x600114A")]
		[Address(RVA = "0x15901F8", Offset = "0x15901F8", VA = "0x15901F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001149")]
	[Address(RVA = "0x15900E8", Offset = "0x15900E8", VA = "0x15900E8")]
	private static string CachedResourcePath(string resourceName)
	{
		return null;
	}

	[Token(Token = "0x600114B")]
	[Address(RVA = "0x1590268", Offset = "0x1590268", VA = "0x1590268")]
	public bool HasBeenDownloaded(string resourceName)
	{
		return default;
	}

	[Token(Token = "0x600114C")]
	[Address(RVA = "0x15903B4", Offset = "0x15903B4", VA = "0x15903B4")]
	private bool IsSameVersion(string resourceName)
	{
		return default;
	}

	[Token(Token = "0x600114D")]
	[Address(RVA = "0x15904E0", Offset = "0x15904E0", VA = "0x15904E0")]
	public Task<ODRDownloadResult> DownloadBundles(List<string> resourceNames, bool showProgressBar = false)
	{
		return null;
	}

	[Token(Token = "0x600114E")]
	[Address(RVA = "0x1590600", Offset = "0x1590600", VA = "0x1590600")]
	public Task<ODRDownloadResult> DownloadBundle(string resourceName, bool showProgressBar = false, int downloadNumber = 1, int downloadCount = 1)
	{
		return null;
	}

	[Token(Token = "0x600114F")]
	[Address(RVA = "0x159073C", Offset = "0x159073C", VA = "0x159073C")]
	public static void DeleteGroup(string resourceName)
	{
	}

	[Token(Token = "0x6001150")]
	[Address(RVA = "0x15907BC", Offset = "0x15907BC", VA = "0x15907BC")]
	private Task AwaitDownload(OnDemandResourcesRequest onDemandResourcesRequest, bool showProgressBar, int downloadNumber, int downloadCount)
	{
		return null;
	}

	[Token(Token = "0x6001151")]
	[Address(RVA = "0x15908C8", Offset = "0x15908C8", VA = "0x15908C8")]
	private void OnDownloadCancelled()
	{
	}

	[Token(Token = "0x6001152")]
	[Address(RVA = "0x15908D4", Offset = "0x15908D4", VA = "0x15908D4")]
	private void CacheFile(string resourceName, string resourcePath, string buildVersionString, OnDemandResourcesRequest onDemandResourcesRequest)
	{
	}

	[Token(Token = "0x6001153")]
	[Address(RVA = "0x1590CA4", Offset = "0x1590CA4", VA = "0x1590CA4")]
	public uint ReplaceStateIfUnavailable(uint wwiseState)
	{
		return default;
	}

	[Token(Token = "0x6001154")]
	[Address(RVA = "0x158FFE0", Offset = "0x158FFE0", VA = "0x158FFE0")]
	public ODRDownloadManager()
	{
	}
}
