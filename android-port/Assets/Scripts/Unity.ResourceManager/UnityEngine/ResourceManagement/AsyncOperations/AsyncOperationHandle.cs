using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	[Token(Token = "0x2000070")]
	public struct AsyncOperationHandle<TObject> : IEnumerator, IEquatable<AsyncOperationHandle<TObject>>
	{
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x0")]
		internal AsyncOperationBase<TObject> m_InternalOp;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x0")]
		private int m_Version;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x0")]
		private string m_LocationName;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x0")]
		private bool m_UnloadSceneOpExcludeReleaseCallback;

		[Token(Token = "0x170000A8")]
		internal string LocationName
		{
			[Token(Token = "0x60002E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E9")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		internal bool UnloadSceneOpExcludeReleaseCallback
		{
			[Token(Token = "0x60002EA")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002EB")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public string DebugName
		{
			[Token(Token = "0x60002F9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		internal AsyncOperationBase<TObject> InternalOp
		{
			[Token(Token = "0x6000300")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		public bool IsDone
		{
			[Token(Token = "0x6000301")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000AD")]
		public Exception OperationException
		{
			[Token(Token = "0x6000303")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		public float PercentComplete
		{
			[Token(Token = "0x6000304")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000AF")]
		internal int ReferenceCount
		{
			[Token(Token = "0x6000305")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000B0")]
		public TObject Result
		{
			[Token(Token = "0x6000307")]
			get
			{
				return (TObject)null;
			}
		}

		[Token(Token = "0x170000B1")]
		public AsyncOperationStatus Status
		{
			[Token(Token = "0x6000308")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000B2")]
		public Task<TObject> Task
		{
			[Token(Token = "0x6000309")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600030A")]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x1400000D")]
		public event Action<AsyncOperationHandle<TObject>> Completed
		{
			[Token(Token = "0x60002F5")]
			add
			{
			}
			[Token(Token = "0x60002F6")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event Action<AsyncOperationHandle> CompletedTypeless
		{
			[Token(Token = "0x60002F7")]
			add
			{
			}
			[Token(Token = "0x60002F8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event Action<AsyncOperationHandle> Destroyed
		{
			[Token(Token = "0x60002FB")]
			add
			{
			}
			[Token(Token = "0x60002FC")]
			remove
			{
			}
		}

		[Token(Token = "0x60002EC")]
		public static implicit operator AsyncOperationHandle(AsyncOperationHandle<TObject> obj)
		{
			return default;
		}

		[Token(Token = "0x60002ED")]
		internal AsyncOperationHandle(AsyncOperationBase<TObject> op)
		{
		}

		[Token(Token = "0x60002EE")]
		public DownloadStatus GetDownloadStatus()
		{
			return default;
		}

		[Token(Token = "0x60002EF")]
		internal DownloadStatus InternalGetDownloadStatus(HashSet<object> visited)
		{
			return default;
		}

		[Token(Token = "0x60002F0")]
		internal AsyncOperationHandle(IAsyncOperation op)
		{
		}

		[Token(Token = "0x60002F1")]
		internal AsyncOperationHandle(IAsyncOperation op, int version)
		{
		}

		[Token(Token = "0x60002F2")]
		internal AsyncOperationHandle(IAsyncOperation op, string locationName)
		{
		}

		[Token(Token = "0x60002F3")]
		internal AsyncOperationHandle(IAsyncOperation op, int version, string locationName)
		{
		}

		[Token(Token = "0x60002F4")]
		internal AsyncOperationHandle<TObject> Acquire()
		{
			return default;
		}

		[Token(Token = "0x60002FA")]
		public void GetDependencies(List<AsyncOperationHandle> deps)
		{
		}

		[Token(Token = "0x60002FD")]
		public bool Equals(AsyncOperationHandle<TObject> other)
		{
			return default;
		}

		[Token(Token = "0x60002FE")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x60002FF")]
		public TObject WaitForCompletion()
		{
			return (TObject)null;
		}

		[Token(Token = "0x6000302")]
		public bool IsValid()
		{
			return default;
		}

		[Token(Token = "0x6000306")]
		internal void Release()
		{
		}

		[Token(Token = "0x600030A")]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		private bool System_002ECollections_002EIEnumerator_002EMoveNext()
		{
			return default;
		}

		[Token(Token = "0x600030C")]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public struct AsyncOperationHandle : IEnumerator
	{
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x0")]
		private static bool m_IsWaitingForCompletion;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x0")]
		internal IAsyncOperation m_InternalOp;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x8")]
		private int m_Version;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x10")]
		private string m_LocationName;

		[Token(Token = "0x170000B4")]
		public static bool IsWaitingForCompletion
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x2A60B3C", Offset = "0x2A60B3C", VA = "0x2A60B3C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x2A60BA0", Offset = "0x2A60BA0", VA = "0x2A60BA0")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		internal string LocationName
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x2A60C10", Offset = "0x2A60C10", VA = "0x2A60C10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x2A60C18", Offset = "0x2A60C18", VA = "0x2A60C18")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public string DebugName
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x2A611A4", Offset = "0x2A611A4", VA = "0x2A611A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		private IAsyncOperation InternalOp
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x2A60EC8", Offset = "0x2A60EC8", VA = "0x2A60EC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		public bool IsDone
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x2A616A8", Offset = "0x2A616A8", VA = "0x2A616A8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000B9")]
		public Exception OperationException
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x2A61820", Offset = "0x2A61820", VA = "0x2A61820")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public float PercentComplete
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x2A618E0", Offset = "0x2A618E0", VA = "0x2A618E0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000BB")]
		internal int ReferenceCount
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x2A61B9C", Offset = "0x2A61B9C", VA = "0x2A61B9C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000BC")]
		public object Result
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x2A61D20", Offset = "0x2A61D20", VA = "0x2A61D20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public AsyncOperationStatus Status
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x2A61DDC", Offset = "0x2A61DDC", VA = "0x2A61DDC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000BE")]
		public Task<object> Task
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x2A61E9C", Offset = "0x2A61E9C", VA = "0x2A61E9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x2A61F5C", Offset = "0x2A61F5C", VA = "0x2A61F5C", Slot = "5")]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x14000010")]
		public event Action<AsyncOperationHandle> Completed
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x2A60FD8", Offset = "0x2A60FD8", VA = "0x2A60FD8")]
			add
			{
			}
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x2A610A8", Offset = "0x2A610A8", VA = "0x2A610A8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<AsyncOperationHandle> Destroyed
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x2A613FC", Offset = "0x2A613FC", VA = "0x2A613FC")]
			add
			{
			}
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x2A614CC", Offset = "0x2A614CC", VA = "0x2A614CC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x2A60C20", Offset = "0x2A60C20", VA = "0x2A60C20")]
		internal AsyncOperationHandle(IAsyncOperation op)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x2A60CF4", Offset = "0x2A60CF4", VA = "0x2A60CF4")]
		internal AsyncOperationHandle(IAsyncOperation op, int version)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x2A60D04", Offset = "0x2A60D04", VA = "0x2A60D04")]
		internal AsyncOperationHandle(IAsyncOperation op, string locationName)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x2A60DDC", Offset = "0x2A60DDC", VA = "0x2A60DDC")]
		internal AsyncOperationHandle(IAsyncOperation op, int version, string locationName)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x2A60DEC", Offset = "0x2A60DEC", VA = "0x2A60DEC")]
		internal AsyncOperationHandle Acquire()
		{
			return default;
		}

		[Token(Token = "0x6000318")]
		public AsyncOperationHandle<T> Convert<T>()
		{
			return default;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x2A61178", Offset = "0x2A61178", VA = "0x2A61178")]
		public bool Equals(AsyncOperationHandle other)
		{
			return default;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x2A6159C", Offset = "0x2A6159C", VA = "0x2A6159C")]
		public void GetDependencies(List<AsyncOperationHandle> deps)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x2A6166C", Offset = "0x2A6166C", VA = "0x2A6166C", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x2A61330", Offset = "0x2A61330", VA = "0x2A61330")]
		public bool IsValid()
		{
			return default;
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x2A619A0", Offset = "0x2A619A0", VA = "0x2A619A0")]
		public DownloadStatus GetDownloadStatus()
		{
			return default;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x2A61A2C", Offset = "0x2A61A2C", VA = "0x2A61A2C")]
		internal DownloadStatus InternalGetDownloadStatus(HashSet<object> visited)
		{
			return default;
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x2A61C5C", Offset = "0x2A61C5C", VA = "0x2A61C5C")]
		internal void Release()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x2A61F5C", Offset = "0x2A61F5C", VA = "0x2A61F5C", Slot = "5")]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x2A61F60", Offset = "0x2A61F60", VA = "0x2A61F60", Slot = "4")]
		private bool System_002ECollections_002EIEnumerator_002EMoveNext()
		{
			return default;
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x2A61F78", Offset = "0x2A61F78", VA = "0x2A61F78", Slot = "6")]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x2A61F7C", Offset = "0x2A61F7C", VA = "0x2A61F7C")]
		public object WaitForCompletion()
		{
			return null;
		}
	}
}
