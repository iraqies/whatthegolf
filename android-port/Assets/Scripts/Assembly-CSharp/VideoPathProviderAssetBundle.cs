using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000084")]
public class VideoPathProviderAssetBundle : IVideoPathProvider
{
	[Serializable]
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D608", Offset = "0x3D608")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x8")]
		public static Func<string, string> _003C_003E9__8_0;

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1874A84", Offset = "0x1874A84", VA = "0x1874A84")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1874A8C", Offset = "0x1874A8C", VA = "0x1874A8C")]
		internal string _003CInit_003Eb__8_0(string x)
		{
			return null;
		}
	}

	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D618", Offset = "0x3D618")]
	private sealed class _003CInit_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x20")]
		public VideoPathProviderAssetBundle _003C_003E4__this;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x28")]
		private AssetBundleCreateRequest _003CassetBundleCreateRequest_003E5__2;

		[Token(Token = "0x1700005C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x1874E44", Offset = "0x1874E44", VA = "0x1874E44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700005D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x1874E8C", Offset = "0x1874E8C", VA = "0x1874E8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1874C20", Offset = "0x1874C20", VA = "0x1874C20")]
		[DebuggerHidden]
		public _003CInit_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1874C4C", Offset = "0x1874C4C", VA = "0x1874C4C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1874C50", Offset = "0x1874C50", VA = "0x1874C50", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1874E44", Offset = "0x1874E44", VA = "0x1874E44", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1874E4C", Offset = "0x1874E4C", VA = "0x1874E4C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1874E8C", Offset = "0x1874E8C", VA = "0x1874E8C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D628", Offset = "0x3D628")]
	private sealed class _003CGetVideoClipForPath_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x20")]
		public VideoClipResult result;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x28")]
		public VideoPathProviderAssetBundle _003C_003E4__this;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x30")]
		public string path;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x38")]
		private AssetBundleRequest _003CassetBundleRequest_003E5__2;

		[Token(Token = "0x1700005E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x1874BD0", Offset = "0x1874BD0", VA = "0x1874BD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700005F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x1874C18", Offset = "0x1874C18", VA = "0x1874C18", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1874AA8", Offset = "0x1874AA8", VA = "0x1874AA8")]
		[DebuggerHidden]
		public _003CGetVideoClipForPath_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1874AD4", Offset = "0x1874AD4", VA = "0x1874AD4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1874AD8", Offset = "0x1874AD8", VA = "0x1874AD8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1874BD0", Offset = "0x1874BD0", VA = "0x1874BD0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1874BD8", Offset = "0x1874BD8", VA = "0x1874BD8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1874C18", Offset = "0x1874C18", VA = "0x1874C18", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40001FA")]
	[FieldOffset(Offset = "0x10")]
	private AssetBundle bundle;

	[Token(Token = "0x40001FB")]
	[FieldOffset(Offset = "0x18")]
	private string[] assetNames;

	[Token(Token = "0x40001FC")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x49608", Offset = "0x49608")]
	private bool InitComplete__BackingField;

	[Token(Token = "0x40001FD")]
	[FieldOffset(Offset = "0x28")]
	private string assetBundleFilePath;

	[Token(Token = "0x1700005B")]
	public bool InitComplete
	{
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x174AE2C", Offset = "0x174AE2C", VA = "0x174AE2C", Slot = "5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5D854", Offset = "0x5D854")]
		get
		{
			return default;
		}
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x174AE34", Offset = "0x174AE34", VA = "0x174AE34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5D864", Offset = "0x5D864")]
		private set
		{
		}
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x174AE3C", Offset = "0x174AE3C", VA = "0x174AE3C")]
	public VideoPathProviderAssetBundle(string filePath)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x174AE68", Offset = "0x174AE68", VA = "0x174AE68", Slot = "10")]
	public virtual IEnumerator Init()
	{
		return null;
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x174AEDC", Offset = "0x174AEDC", VA = "0x174AEDC", Slot = "6")]
	public string GetVideoPath(string path)
	{
		return null;
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x174AF44", Offset = "0x174AF44", VA = "0x174AF44", Slot = "7")]
	public bool FileExists(string path)
	{
		return default;
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x174AFEC", Offset = "0x174AFEC", VA = "0x174AFEC", Slot = "8")]
	public IEnumerator GetVideoClipForPath(string path, VideoClipResult result)
	{
		return null;
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x174B074", Offset = "0x174B074", VA = "0x174B074", Slot = "9")]
	public void Cleanup()
	{
	}
}
