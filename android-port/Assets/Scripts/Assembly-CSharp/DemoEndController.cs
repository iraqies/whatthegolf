using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000059")]
public class DemoEndController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200005A")]
	public class VideoOrder
	{
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x10")]
		public DemoEndLoader.EDemoEnded endType;

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x18")]
		public List<string> videoPaths;

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x179B5BC", Offset = "0x179B5BC", VA = "0x179B5BC")]
		public VideoOrder()
		{
		}
	}

	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D490", Offset = "0x3D490")]
	private sealed class _003CStart_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x20")]
		public DemoEndController _003C_003E4__this;

		[Token(Token = "0x17000040")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x179B56C", Offset = "0x179B56C", VA = "0x179B56C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000041")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x179B5B4", Offset = "0x179B5B4", VA = "0x179B5B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x179B478", Offset = "0x179B478", VA = "0x179B478")]
		[DebuggerHidden]
		public _003CStart_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x179B4A4", Offset = "0x179B4A4", VA = "0x179B4A4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x179B4A8", Offset = "0x179B4A8", VA = "0x179B4A8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x179B56C", Offset = "0x179B56C", VA = "0x179B56C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x179B574", Offset = "0x179B574", VA = "0x179B574", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x179B5B4", Offset = "0x179B5B4", VA = "0x179B5B4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D4A0", Offset = "0x3D4A0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x8")]
		public static Func<VideoOrder, bool> _003C_003E9__7_0;

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x179B40C", Offset = "0x179B40C", VA = "0x179B40C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x179B414", Offset = "0x179B414", VA = "0x179B414")]
		internal bool _003CShowVideo_003Eb__7_0(VideoOrder d)
		{
			return default;
		}
	}

	[Token(Token = "0x4000176")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Camera _cameraToUse;

	[Token(Token = "0x4000177")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<VideoOrder> _videoDefs;

	[Token(Token = "0x4000178")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private VideoContainer _videoContainer;

	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private DemoEndMenu _menuContainer;

	[Token(Token = "0x400017A")]
	[FieldOffset(Offset = "0x38")]
	private List<string> _remainingVideoPaths;

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x18D9F80", Offset = "0x18D9F80", VA = "0x18D9F80")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x18D9FF4", Offset = "0x18D9FF4", VA = "0x18D9FF4")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x5D404", Offset = "0x5D404")]
	public void ShowVideo()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x18DA1AC", Offset = "0x18DA1AC", VA = "0x18DA1AC")]
	private void ContinueToNextVideoOrClosePlayer()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x18DA388", Offset = "0x18DA388", VA = "0x18DA388")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x5D43C", Offset = "0x5D43C")]
	public void HideVideo()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x18DA33C", Offset = "0x18DA33C", VA = "0x18DA33C")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x5D474", Offset = "0x5D474")]
	public void ShowMenu()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x18DA17C", Offset = "0x18DA17C", VA = "0x18DA17C")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x5D4AC", Offset = "0x5D4AC")]
	public void HideMenu()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x18DA3F4", Offset = "0x18DA3F4", VA = "0x18DA3F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x18DA4A8", Offset = "0x18DA4A8", VA = "0x18DA4A8")]
	public DemoEndController()
	{
	}
}
