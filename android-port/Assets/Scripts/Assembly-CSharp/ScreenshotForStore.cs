using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000522")]
public class ScreenshotForStore : MonoBehaviour
{
	[Token(Token = "0x2000523")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40264", Offset = "0x40264")]
	private sealed class _003CStart_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001A7F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001A80")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001A81")]
		[FieldOffset(Offset = "0x20")]
		public ScreenshotForStore _003C_003E4__this;

		[Token(Token = "0x17000298")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600177B")]
			[Address(RVA = "0x183F608", Offset = "0x183F608", VA = "0x183F608", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000299")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600177D")]
			[Address(RVA = "0x183F650", Offset = "0x183F650", VA = "0x183F650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001778")]
		[Address(RVA = "0x183F500", Offset = "0x183F500", VA = "0x183F500")]
		[DebuggerHidden]
		public _003CStart_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001779")]
		[Address(RVA = "0x183F52C", Offset = "0x183F52C", VA = "0x183F52C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600177A")]
		[Address(RVA = "0x183F530", Offset = "0x183F530", VA = "0x183F530", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600177B")]
		[Address(RVA = "0x183F608", Offset = "0x183F608", VA = "0x183F608", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600177C")]
		[Address(RVA = "0x183F610", Offset = "0x183F610", VA = "0x183F610", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600177D")]
		[Address(RVA = "0x183F650", Offset = "0x183F650", VA = "0x183F650", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000524")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40274", Offset = "0x40274")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001A82")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001A83")]
		[FieldOffset(Offset = "0x8")]
		public static Func<GameObject, bool> _003C_003E9__16_0;

		[Token(Token = "0x600177F")]
		[Address(RVA = "0x183F494", Offset = "0x183F494", VA = "0x183F494")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001780")]
		[Address(RVA = "0x183F49C", Offset = "0x183F49C", VA = "0x183F49C")]
		internal bool _003CGetRoots_003Eb__16_0(GameObject r)
		{
			return default;
		}
	}

	[Token(Token = "0x4001A72")]
	[FieldOffset(Offset = "0x18")]
	public string KeyToTake;

	[Token(Token = "0x4001A73")]
	[FieldOffset(Offset = "0x20")]
	public bool saveLayers;

	[Token(Token = "0x4001A74")]
	[FieldOffset(Offset = "0x21")]
	public bool useShadowPlaneForLayers;

	[Token(Token = "0x4001A75")]
	[FieldOffset(Offset = "0x24")]
	public float shadowPlaneHeight;

	[Token(Token = "0x4001A76")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4DA24", Offset = "0x4DA24")]
	public float shadowOpacity;

	[Token(Token = "0x4001A77")]
	[FieldOffset(Offset = "0x2C")]
	public bool useCustomDepthLayer;

	[Token(Token = "0x4001A78")]
	[FieldOffset(Offset = "0x30")]
	public GameObject depthLayer;

	[Token(Token = "0x4001A79")]
	[FieldOffset(Offset = "0x38")]
	public bool useClearBackground;

	[Token(Token = "0x4001A7A")]
	[FieldOffset(Offset = "0x3C")]
	public int layersOnRuntime;

	[Token(Token = "0x4001A7B")]
	[FieldOffset(Offset = "0x40")]
	private MeshRenderer m_ShadowPlaneRenderer;

	[Token(Token = "0x4001A7C")]
	[FieldOffset(Offset = "0x48")]
	private Material m_ShadowPlaneMaterial;

	[Token(Token = "0x4001A7D")]
	private const float kShadowPlaneScale = 1000f;

	[Token(Token = "0x4001A7E")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Shader m_ShadowPlaneShader;

	[Token(Token = "0x17000297")]
	private bool m_ShadowPlaneValid
	{
		[Token(Token = "0x6001771")]
		[Address(RVA = "0x167E280", Offset = "0x167E280", VA = "0x167E280")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6001772")]
	[Address(RVA = "0x167E2FC", Offset = "0x167E2FC", VA = "0x167E2FC")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6001773")]
	[Address(RVA = "0x167E370", Offset = "0x167E370", VA = "0x167E370")]
	private List<GameObject> GetRoots()
	{
		return null;
	}

	[Token(Token = "0x6001774")]
	[Address(RVA = "0x167E520", Offset = "0x167E520", VA = "0x167E520")]
	private void TakeScreenShot()
	{
	}

	[Token(Token = "0x6001775")]
	[Address(RVA = "0x167EF30", Offset = "0x167EF30", VA = "0x167EF30")]
	private void CreateShadowPlane()
	{
	}

	[Token(Token = "0x6001776")]
	[Address(RVA = "0x167F104", Offset = "0x167F104", VA = "0x167F104")]
	private void CleanupShadowPlane()
	{
	}

	[Token(Token = "0x6001777")]
	[Address(RVA = "0x167F190", Offset = "0x167F190", VA = "0x167F190")]
	public ScreenshotForStore()
	{
	}
}
