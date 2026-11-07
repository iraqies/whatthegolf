using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio.Multiplayer;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000165")]
public class ProgressUICharacters : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000166")]
	public class ProgressAvatar
	{
		[Token(Token = "0x4000661")]
		[FieldOffset(Offset = "0x10")]
		public PlayerColors.AvatarIDs ID;

		[Token(Token = "0x4000662")]
		[FieldOffset(Offset = "0x18")]
		public GameObject GameObject;

		[Token(Token = "0x4000663")]
		[FieldOffset(Offset = "0x20")]
		public float MoveSpeed;

		[Token(Token = "0x4000664")]
		[FieldOffset(Offset = "0x28")]
		public Animator Animator;

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x182EE4C", Offset = "0x182EE4C", VA = "0x182EE4C")]
		public ProgressAvatar()
		{
		}
	}

	[Token(Token = "0x2000167")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DD50", Offset = "0x3DD50")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x4000665")]
		[FieldOffset(Offset = "0x10")]
		public MultiplayerConfiguration.PlayerInfo player;

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x182E1BC", Offset = "0x182E1BC", VA = "0x182E1BC")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x182E1C4", Offset = "0x182E1C4", VA = "0x182E1C4")]
		internal bool _003CSetCharacters_003Eb__0(ProgressAvatar a)
		{
			return default;
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x182E1FC", Offset = "0x182E1FC", VA = "0x182E1FC")]
		internal bool _003CSetCharacters_003Eb__1(ProgressAvatar a)
		{
			return default;
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x182E234", Offset = "0x182E234", VA = "0x182E234")]
		internal bool _003CSetCharacters_003Eb__2(ProgressAvatar a)
		{
			return default;
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x182E26C", Offset = "0x182E26C", VA = "0x182E26C")]
		internal bool _003CSetCharacters_003Eb__3(ProgressAvatar a)
		{
			return default;
		}
	}

	[Token(Token = "0x2000168")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DD60", Offset = "0x3DD60")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4000666")]
		[FieldOffset(Offset = "0x10")]
		public PlayerColors.AvatarIDs winID;

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x182E2A4", Offset = "0x182E2A4", VA = "0x182E2A4")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x182E2AC", Offset = "0x182E2AC", VA = "0x182E2AC")]
		internal bool _003CDoWinPose_003Eb__0(ProgressAvatar a)
		{
			return default;
		}
	}

	[Token(Token = "0x2000169")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DD70", Offset = "0x3DD70")]
	private sealed class _003CDoWinPose_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000667")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000668")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000669")]
		[FieldOffset(Offset = "0x20")]
		public PlayerColors.AvatarIDs winID;

		[Token(Token = "0x400066A")]
		[FieldOffset(Offset = "0x28")]
		public ProgressUICharacters _003C_003E4__this;

		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0x30")]
		private Animator _003Canimator_003E5__2;

		[Token(Token = "0x170000CF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x182E57C", Offset = "0x182E57C", VA = "0x182E57C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000D0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x182E5C4", Offset = "0x182E5C4", VA = "0x182E5C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x182E2E8", Offset = "0x182E2E8", VA = "0x182E2E8")]
		[DebuggerHidden]
		public _003CDoWinPose_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x182E314", Offset = "0x182E314", VA = "0x182E314", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x182E318", Offset = "0x182E318", VA = "0x182E318", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x182E57C", Offset = "0x182E57C", VA = "0x182E57C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x182E584", Offset = "0x182E584", VA = "0x182E584", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x182E5C4", Offset = "0x182E5C4", VA = "0x182E5C4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200016A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DD80", Offset = "0x3DD80")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x10")]
		public int done;

		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x18")]
		public Action _003C_003E9__0;

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x182E2D0", Offset = "0x182E2D0", VA = "0x182E2D0")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x182E2D8", Offset = "0x182E2D8", VA = "0x182E2D8")]
		internal void _003CMoveCharacters_003Eb__0()
		{
		}
	}

	[Token(Token = "0x200016B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DD90", Offset = "0x3DD90")]
	private sealed class _003CMoveCharacters_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400066E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400066F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000670")]
		[FieldOffset(Offset = "0x20")]
		public ProgressUICharacters _003C_003E4__this;

		[Token(Token = "0x4000671")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 to;

		[Token(Token = "0x4000672")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass15_0 _003C_003E8__1;

		[Token(Token = "0x170000D1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x182EDFC", Offset = "0x182EDFC", VA = "0x182EDFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000D2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x182EE44", Offset = "0x182EE44", VA = "0x182EE44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x182EA68", Offset = "0x182EA68", VA = "0x182EA68")]
		[DebuggerHidden]
		public _003CMoveCharacters_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x182EA94", Offset = "0x182EA94", VA = "0x182EA94", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x182EA98", Offset = "0x182EA98", VA = "0x182EA98", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x182EDFC", Offset = "0x182EDFC", VA = "0x182EDFC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x182EE04", Offset = "0x182EE04", VA = "0x182EE04", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x182EE44", Offset = "0x182EE44", VA = "0x182EE44", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200016C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DDA0", Offset = "0x3DDA0")]
	private sealed class _003CMoveCharacter_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000673")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000674")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000675")]
		[FieldOffset(Offset = "0x20")]
		public ProgressUICharacters _003C_003E4__this;

		[Token(Token = "0x4000676")]
		[FieldOffset(Offset = "0x28")]
		public ProgressAvatar avatar;

		[Token(Token = "0x4000677")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 to;

		[Token(Token = "0x4000678")]
		[FieldOffset(Offset = "0x40")]
		public Action onDone;

		[Token(Token = "0x4000679")]
		[FieldOffset(Offset = "0x48")]
		private float _003CstartMag_003E5__2;

		[Token(Token = "0x170000D3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x182EA18", Offset = "0x182EA18", VA = "0x182EA18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000D4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x182EA60", Offset = "0x182EA60", VA = "0x182EA60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x182E5CC", Offset = "0x182E5CC", VA = "0x182E5CC")]
		[DebuggerHidden]
		public _003CMoveCharacter_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x182E5F8", Offset = "0x182E5F8", VA = "0x182E5F8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x182E5FC", Offset = "0x182E5FC", VA = "0x182E5FC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x182EA18", Offset = "0x182EA18", VA = "0x182EA18", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x182EA20", Offset = "0x182EA20", VA = "0x182EA20", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x182EA60", Offset = "0x182EA60", VA = "0x182EA60", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x200016D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DDB0", Offset = "0x3DDB0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400067A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400067B")]
		[FieldOffset(Offset = "0x8")]
		public static Action<ProgressAvatar> _003C_003E9__17_0;

		[Token(Token = "0x400067C")]
		[FieldOffset(Offset = "0x10")]
		public static Action<ProgressAvatar> _003C_003E9__17_1;

		[Token(Token = "0x400067D")]
		[FieldOffset(Offset = "0x18")]
		public static Action<ProgressAvatar> _003C_003E9__17_2;

		[Token(Token = "0x400067E")]
		[FieldOffset(Offset = "0x20")]
		public static Action<ProgressAvatar> _003C_003E9__17_3;

		[Token(Token = "0x400067F")]
		[FieldOffset(Offset = "0x28")]
		public static Action<ProgressAvatar> _003C_003E9__17_4;

		[Token(Token = "0x4000680")]
		[FieldOffset(Offset = "0x30")]
		public static Action<ProgressAvatar> _003C_003E9__17_5;

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x182E0C4", Offset = "0x182E0C4", VA = "0x182E0C4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x182E0CC", Offset = "0x182E0CC", VA = "0x182E0CC")]
		internal void _003CResetCharacters_003Eb__17_0(ProgressAvatar a)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x182E0F4", Offset = "0x182E0F4", VA = "0x182E0F4")]
		internal void _003CResetCharacters_003Eb__17_1(ProgressAvatar a)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x182E11C", Offset = "0x182E11C", VA = "0x182E11C")]
		internal void _003CResetCharacters_003Eb__17_2(ProgressAvatar a)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x182E144", Offset = "0x182E144", VA = "0x182E144")]
		internal void _003CResetCharacters_003Eb__17_3(ProgressAvatar a)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x182E16C", Offset = "0x182E16C", VA = "0x182E16C")]
		internal void _003CResetCharacters_003Eb__17_4(ProgressAvatar a)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x182E194", Offset = "0x182E194", VA = "0x182E194")]
		internal void _003CResetCharacters_003Eb__17_5(ProgressAvatar a)
		{
		}
	}

	[Token(Token = "0x4000656")]
	[FieldOffset(Offset = "0x18")]
	public ProgressUICharacterAudio progressUIAudio;

	[Token(Token = "0x4000657")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve CharacterMoveCurve;

	[Token(Token = "0x4000658")]
	[FieldOffset(Offset = "0x28")]
	public List<ProgressAvatar> LeftCharacters;

	[Token(Token = "0x4000659")]
	[FieldOffset(Offset = "0x30")]
	public List<ProgressAvatar> RightCharacters;

	[Token(Token = "0x400065A")]
	[FieldOffset(Offset = "0x38")]
	public List<ProgressAvatar> TopCharacters;

	[Token(Token = "0x400065B")]
	[FieldOffset(Offset = "0x40")]
	public List<ProgressAvatar> BottomCharacters;

	[Token(Token = "0x400065C")]
	[FieldOffset(Offset = "0x48")]
	public List<ProgressAvatar> LeftCrownAvatar;

	[Token(Token = "0x400065D")]
	[FieldOffset(Offset = "0x50")]
	public List<ProgressAvatar> RightCrownAvatar;

	[Token(Token = "0x400065E")]
	[FieldOffset(Offset = "0x58")]
	private List<ProgressAvatar> activeCharacters;

	[Token(Token = "0x400065F")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<ProgressAvatar, Vector3> offsets;

	[Token(Token = "0x4000660")]
	[FieldOffset(Offset = "0x68")]
	private bool initialized;

	[Token(Token = "0x6000621")]
	[Address(RVA = "0x16236E4", Offset = "0x16236E4", VA = "0x16236E4")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000622")]
	[Address(RVA = "0x1624E0C", Offset = "0x1624E0C", VA = "0x1624E0C")]
	public void SetCharacters(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	[Token(Token = "0x6000623")]
	[Address(RVA = "0x1626A88", Offset = "0x1626A88", VA = "0x1626A88")]
	public IEnumerator DoWinPose(PlayerColors.AvatarIDs winID)
	{
		return null;
	}

	[Token(Token = "0x6000624")]
	[Address(RVA = "0x1626B04", Offset = "0x1626B04", VA = "0x1626B04")]
	public IEnumerator MoveCharacters(Vector3 to)
	{
		return null;
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0x1626B9C", Offset = "0x1626B9C", VA = "0x1626B9C")]
	private IEnumerator MoveCharacter(ProgressAvatar avatar, Vector3 to, Action onDone)
	{
		return null;
	}

	[Token(Token = "0x6000626")]
	[Address(RVA = "0x16263C0", Offset = "0x16263C0", VA = "0x16263C0")]
	public void ResetCharacters()
	{
	}

	[Token(Token = "0x6000627")]
	[Address(RVA = "0x1626C48", Offset = "0x1626C48", VA = "0x1626C48")]
	public ProgressUICharacters()
	{
	}

	[Token(Token = "0x6000628")]
	[Address(RVA = "0x1626C90", Offset = "0x1626C90", VA = "0x1626C90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5EB78", Offset = "0x5EB78")]
	private void _003CInitialize_003Eb__12_0(ProgressAvatar a)
	{
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0x1626D5C", Offset = "0x1626D5C", VA = "0x1626D5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5EB88", Offset = "0x5EB88")]
	private void _003CInitialize_003Eb__12_1(ProgressAvatar a)
	{
	}

	[Token(Token = "0x600062A")]
	[Address(RVA = "0x1626E28", Offset = "0x1626E28", VA = "0x1626E28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5EB98", Offset = "0x5EB98")]
	private void _003CInitialize_003Eb__12_2(ProgressAvatar a)
	{
	}

	[Token(Token = "0x600062B")]
	[Address(RVA = "0x1626EF4", Offset = "0x1626EF4", VA = "0x1626EF4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5EBA8", Offset = "0x5EBA8")]
	private void _003CInitialize_003Eb__12_3(ProgressAvatar a)
	{
	}
}
