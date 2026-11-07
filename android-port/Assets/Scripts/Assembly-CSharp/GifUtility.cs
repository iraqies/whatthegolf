using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Moments;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000BF2")]
public class GifUtility : MonoBehaviour
{
	[Token(Token = "0x2000BF3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43EB8", Offset = "0x43EB8")]
	private sealed class _003CCombineGifsWhenReady_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400423D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400423E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400423F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<string, List<RenderTexture>> allFrames;

		[Token(Token = "0x4004240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string levelName;

		[Token(Token = "0x4004241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onDone;

		[Token(Token = "0x4004242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GifUtility _003C_003E4__this;

		[Token(Token = "0x4004243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int numberOfStrokes;

		[Token(Token = "0x4004244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<RenderTexture>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x4004245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RenderTexture _003Ct_003E5__3;

		[Token(Token = "0x4004246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTexture _003Ctemp_003E5__4;

		[Token(Token = "0x170005FA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003961")]
			[Address(RVA = "0x17B3F04", Offset = "0x17B3F04", VA = "0x17B3F04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005FB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003963")]
			[Address(RVA = "0x17B3F4C", Offset = "0x17B3F4C", VA = "0x17B3F4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600395D")]
		[Address(RVA = "0x17B3780", Offset = "0x17B3780", VA = "0x17B3780")]
		[DebuggerHidden]
		public _003CCombineGifsWhenReady_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600395E")]
		[Address(RVA = "0x17B37AC", Offset = "0x17B37AC", VA = "0x17B37AC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600395F")]
		[Address(RVA = "0x17B3880", Offset = "0x17B3880", VA = "0x17B3880", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003960")]
		[Address(RVA = "0x17B3824", Offset = "0x17B3824", VA = "0x17B3824")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6003961")]
		[Address(RVA = "0x17B3F04", Offset = "0x17B3F04", VA = "0x17B3F04", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003962")]
		[Address(RVA = "0x17B3F0C", Offset = "0x17B3F0C", VA = "0x17B3F0C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003963")]
		[Address(RVA = "0x17B3F4C", Offset = "0x17B3F4C", VA = "0x17B3F4C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400422D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int GifHeight;

	[Token(Token = "0x400422E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int GifWidth;

	[Token(Token = "0x400422F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int FramesPerSecond;

	[Token(Token = "0x4004230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int Quality;

	[Token(Token = "0x4004231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool CaptureGifs;

	[Token(Token = "0x4004232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI scoreText;

	[Token(Token = "0x4004233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Camera scoreCamera;

	[Token(Token = "0x4004234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Material blitMaterial;

	[Token(Token = "0x4004235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Moments.Recorder finalRecorder;

	[Token(Token = "0x4004236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int gifWidth;

	[Token(Token = "0x4004237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private int gifHeight;

	[Token(Token = "0x4004238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int framesPerSecond;

	[Token(Token = "0x4004239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private int quality;

	[Token(Token = "0x400423A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Action OnGifSaved;

	[Token(Token = "0x400423B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Action<float> OnGifSaveProgress;

	[Token(Token = "0x400423C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Action OnGifBatchCompleted;

	[Token(Token = "0x6003952")]
	[Address(RVA = "0x1489008", Offset = "0x1489008", VA = "0x1489008")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003953")]
	[Address(RVA = "0x1489118", Offset = "0x1489118", VA = "0x1489118")]
	private void Start()
	{
	}

	[Token(Token = "0x6003954")]
	[Address(RVA = "0x14893A8", Offset = "0x14893A8", VA = "0x14893A8")]
	private void OnBatchCompleted()
	{
	}

	[Token(Token = "0x6003955")]
	[Address(RVA = "0x14893BC", Offset = "0x14893BC", VA = "0x14893BC")]
	private void OnFileSaveProgress(int i, float p)
	{
	}

	[Token(Token = "0x6003956")]
	[Address(RVA = "0x148942C", Offset = "0x148942C", VA = "0x148942C")]
	private void OnFileSaved(int i, string s)
	{
	}

	[Token(Token = "0x6003957")]
	[Address(RVA = "0x1489440", Offset = "0x1489440", VA = "0x1489440")]
	public IEnumerator CombineGifsWhenReady(string levelName, int numberOfStrokes, Dictionary<string, List<RenderTexture>> allFrames, [Optional] Action onDone)
	{
		return null;
	}

	[Token(Token = "0x6003958")]
	[Address(RVA = "0x14894DC", Offset = "0x14894DC", VA = "0x14894DC")]
	public void AllLevelsCompleted()
	{
	}

	[Token(Token = "0x6003959")]
	[Address(RVA = "0x14894F8", Offset = "0x14894F8", VA = "0x14894F8")]
	public void Abort()
	{
	}

	[Token(Token = "0x600395A")]
	[Address(RVA = "0x148959C", Offset = "0x148959C", VA = "0x148959C")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600395B")]
	[Address(RVA = "0x1489640", Offset = "0x1489640", VA = "0x1489640")]
	public GifUtility()
	{
	}
}
