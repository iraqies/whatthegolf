using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace Core
{
	[Token(Token = "0x200143F")]
	public class TryDownloadPackCommandAsync
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2001440")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x490AC", Offset = "0x490AC")]
		private struct _003CExecute_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4006DDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006DDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x4006DDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TryDownloadPackCommandAsync _003C_003E4__this;

			[Token(Token = "0x4006DDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<bool> _003C_003Eu__1;

			[Token(Token = "0x6005EB9")]
			[Address(RVA = "0x186E160", Offset = "0x186E160", VA = "0x186E160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6005EBA")]
			[Address(RVA = "0x186E374", Offset = "0x186E374", VA = "0x186E374", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2001441")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x490BC", Offset = "0x490BC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4006DDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4006DE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, bool> _003C_003E9__5_0;

			[Token(Token = "0x4006DE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<LevelData, bool> _003C_003E9__8_0;

			[Token(Token = "0x4006DE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<LevelData, bool> _003C_003E9__8_1;

			[Token(Token = "0x4006DE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<LevelData, IResourceLocation> _003C_003E9__8_2;

			[Token(Token = "0x6005EBC")]
			[Address(RVA = "0x186DB08", Offset = "0x186DB08", VA = "0x186DB08")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6005EBD")]
			[Address(RVA = "0x186DB10", Offset = "0x186DB10", VA = "0x186DB10")]
			internal bool _003CTryDownload_003Eb__5_0(string rn)
			{
				return default;
			}

			[Token(Token = "0x6005EBE")]
			[Address(RVA = "0x186DB8C", Offset = "0x186DB8C", VA = "0x186DB8C")]
			internal bool _003CLoadSceneLocations_003Eb__8_0(LevelData ld)
			{
				return default;
			}

			[Token(Token = "0x6005EBF")]
			[Address(RVA = "0x186DBBC", Offset = "0x186DBBC", VA = "0x186DBBC")]
			internal bool _003CLoadSceneLocations_003Eb__8_1(LevelData ld)
			{
				return default;
			}

			[Token(Token = "0x6005EC0")]
			[Address(RVA = "0x186DBE8", Offset = "0x186DBE8", VA = "0x186DBE8")]
			internal IResourceLocation _003CLoadSceneLocations_003Eb__8_2(LevelData ld)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2001442")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x490CC", Offset = "0x490CC")]
		private struct _003CTryDownload_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4006DE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006DE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x4006DE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TryDownloadPackCommandAsync _003C_003E4__this;

			[Token(Token = "0x4006DE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<string> _003CresourceNames_003E5__2;

			[Token(Token = "0x4006DE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<bool> _003C_003Eu__1;

			[Token(Token = "0x4006DE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x6005EC1")]
			[Address(RVA = "0x186F084", Offset = "0x186F084", VA = "0x186F084", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6005EC2")]
			[Address(RVA = "0x186F73C", Offset = "0x186F73C", VA = "0x186F73C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2001443")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x490DC", Offset = "0x490DC")]
		private struct _003CDownloadResources_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4006DEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006DEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x4006DEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<string> resourceNames;

			[Token(Token = "0x4006DED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<ODRDownloadResult> _003C_003Eu__1;

			[Token(Token = "0x4006DEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x6005EC3")]
			[Address(RVA = "0x186DC0C", Offset = "0x186DC0C", VA = "0x186DC0C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6005EC4")]
			[Address(RVA = "0x186E104", Offset = "0x186E104", VA = "0x186E104", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2001444")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x490EC", Offset = "0x490EC")]
		private struct _003CLoadSceneLocations_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4006DEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006DF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4006DF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TryDownloadPackCommandAsync _003C_003E4__this;

			[Token(Token = "0x4006DF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<LevelData> _003ClevelDatas_003E5__2;

			[Token(Token = "0x4006DF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AsyncOperationHandle _003CdependencyHandle_003E5__3;

			[Token(Token = "0x4006DF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<LevelData>.Enumerator _003C_003E7__wrap3;

			[Token(Token = "0x4006DF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private LevelData _003ClevelData_003E5__5;

			[Token(Token = "0x4006DF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private AsyncOperationHandle<IList<IResourceLocation>> _003CasyncHandle_003E5__6;

			[Token(Token = "0x4006DF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private object _003C_003Eu__1;

			[Token(Token = "0x6005EC5")]
			[Address(RVA = "0x186E3D0", Offset = "0x186E3D0", VA = "0x186E3D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6005EC6")]
			[Address(RVA = "0x186F078", Offset = "0x186F078", VA = "0x186F078", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4006DDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ContentPack _contentPack;

		[Token(Token = "0x17000AC1")]
		private bool IsOdrContent
		{
			[Token(Token = "0x6005EB2")]
			[Address(RVA = "0x172F7F4", Offset = "0x172F7F4", VA = "0x172F7F4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005EB3")]
		[Address(RVA = "0x172F810", Offset = "0x172F810", VA = "0x172F810")]
		public TryDownloadPackCommandAsync(ContentPack contentPack)
		{
		}

		[Token(Token = "0x6005EB4")]
		[Address(RVA = "0x172F83C", Offset = "0x172F83C", VA = "0x172F83C")]
		public Task<bool> Execute()
		{
			return null;
		}

		[Token(Token = "0x6005EB5")]
		[Address(RVA = "0x172F948", Offset = "0x172F948", VA = "0x172F948")]
		private Task<bool> TryDownload()
		{
			return null;
		}

		[Token(Token = "0x6005EB6")]
		[Address(RVA = "0x172FA54", Offset = "0x172FA54", VA = "0x172FA54")]
		private List<string> ResourceNames(string resourceName)
		{
			return null;
		}

		[Token(Token = "0x6005EB7")]
		[Address(RVA = "0x172FBFC", Offset = "0x172FBFC", VA = "0x172FBFC")]
		private static Task<bool> DownloadResources(List<string> resourceNames)
		{
			return null;
		}

		[Token(Token = "0x6005EB8")]
		[Address(RVA = "0x172FD0C", Offset = "0x172FD0C", VA = "0x172FD0C")]
		private Task LoadSceneLocations()
		{
			return null;
		}
	}
}
