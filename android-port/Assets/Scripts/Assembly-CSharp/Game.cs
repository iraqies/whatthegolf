using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000772")]
public class Game : MonoBehaviour
{
	[Token(Token = "0x2000773")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41460", Offset = "0x41460")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x400276E")]
		[FieldOffset(Offset = "0x10")]
		public bool isTransitionDone;

		[Token(Token = "0x400276F")]
		[FieldOffset(Offset = "0x11")]
		public bool isPlaying;

		[Token(Token = "0x4002770")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 endBallPosition;

		[Token(Token = "0x4002771")]
		[FieldOffset(Offset = "0x20")]
		public bool isWon;

		[Token(Token = "0x4002772")]
		[FieldOffset(Offset = "0x21")]
		public bool isTransitionCover;

		[Token(Token = "0x4002773")]
		[FieldOffset(Offset = "0x28")]
		public Action<Vector3> _003C_003E9__5;

		[Token(Token = "0x600224B")]
		[Address(RVA = "0x17AB120", Offset = "0x17AB120", VA = "0x17AB120")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x600224C")]
		[Address(RVA = "0x17AB128", Offset = "0x17AB128", VA = "0x17AB128")]
		internal void _003CStart_003Eb__1()
		{
		}

		[Token(Token = "0x600224D")]
		[Address(RVA = "0x17AB134", Offset = "0x17AB134", VA = "0x17AB134")]
		internal void _003CStart_003Eb__5(Vector3 pos)
		{
		}

		[Token(Token = "0x600224E")]
		[Address(RVA = "0x17AB14C", Offset = "0x17AB14C", VA = "0x17AB14C")]
		internal void _003CStart_003Eb__2()
		{
		}
	}

	[Token(Token = "0x2000774")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41470", Offset = "0x41470")]
	private sealed class _003C_003Ec__DisplayClass16_1
	{
		[Token(Token = "0x4002774")]
		[FieldOffset(Offset = "0x10")]
		public Killable k;

		[Token(Token = "0x4002775")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x600224F")]
		[Address(RVA = "0x17AB158", Offset = "0x17AB158", VA = "0x17AB158")]
		public _003C_003Ec__DisplayClass16_1()
		{
		}

		[Token(Token = "0x6002250")]
		[Address(RVA = "0x17AB160", Offset = "0x17AB160", VA = "0x17AB160")]
		internal void _003CStart_003Eb__4()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000775")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41480", Offset = "0x41480")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002776")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002777")]
		[FieldOffset(Offset = "0x8")]
		public static Func<HoleInOneLevel, int> _003C_003E9__16_0;

		[Token(Token = "0x6002252")]
		[Address(RVA = "0x17AB0EC", Offset = "0x17AB0EC", VA = "0x17AB0EC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002253")]
		[Address(RVA = "0x17AB0F4", Offset = "0x17AB0F4", VA = "0x17AB0F4")]
		internal int _003CStart_003Eb__16_0(HoleInOneLevel l)
		{
			return default;
		}
	}

	[Token(Token = "0x2000776")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41490", Offset = "0x41490")]
	private sealed class _003CStart_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002778")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002779")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400277A")]
		[FieldOffset(Offset = "0x20")]
		public Game _003C_003E4__this;

		[Token(Token = "0x400277B")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

		[Token(Token = "0x400277C")]
		[FieldOffset(Offset = "0x30")]
		private bool _003CwonLastLevel_003E5__2;

		[Token(Token = "0x400277D")]
		[FieldOffset(Offset = "0x34")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x400277E")]
		[FieldOffset(Offset = "0x38")]
		private int _003Cc_003E5__4;

		[Token(Token = "0x400277F")]
		[FieldOffset(Offset = "0x40")]
		private HoleInOneLevel _003ClevelInfo_003E5__5;

		[Token(Token = "0x4002780")]
		[FieldOffset(Offset = "0x48")]
		private HoleInOneLevel _003CcurrentLevelInstance_003E5__6;

		[Token(Token = "0x4002781")]
		[FieldOffset(Offset = "0x50")]
		private BallShooter _003Cshooter_003E5__7;

		[Token(Token = "0x4002782")]
		[FieldOffset(Offset = "0x58")]
		private float _003CballFlyTime_003E5__8;

		[Token(Token = "0x4002783")]
		[FieldOffset(Offset = "0x60")]
		private SpeechbubbleList _003CpreTextInLevel_003E5__9;

		[Token(Token = "0x170003C9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002257")]
			[Address(RVA = "0x17AC41C", Offset = "0x17AC41C", VA = "0x17AC41C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003CA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002259")]
			[Address(RVA = "0x17AC464", Offset = "0x17AC464", VA = "0x17AC464", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002254")]
		[Address(RVA = "0x17AB1AC", Offset = "0x17AB1AC", VA = "0x17AB1AC")]
		[DebuggerHidden]
		public _003CStart_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002255")]
		[Address(RVA = "0x17AB1D8", Offset = "0x17AB1D8", VA = "0x17AB1D8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002256")]
		[Address(RVA = "0x17AB1DC", Offset = "0x17AB1DC", VA = "0x17AB1DC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002257")]
		[Address(RVA = "0x17AC41C", Offset = "0x17AC41C", VA = "0x17AC41C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002258")]
		[Address(RVA = "0x17AC424", Offset = "0x17AC424", VA = "0x17AC424", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002259")]
		[Address(RVA = "0x17AC464", Offset = "0x17AC464", VA = "0x17AC464", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002761")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer retryRender;

	[Token(Token = "0x4002762")]
	[FieldOffset(Offset = "0x20")]
	public HoleInOneTransition transition;

	[Token(Token = "0x4002763")]
	[FieldOffset(Offset = "0x28")]
	public EffectsInOne effects;

	[Token(Token = "0x4002764")]
	[FieldOffset(Offset = "0x30")]
	public float retryTimeoutThreshold;

	[Token(Token = "0x4002765")]
	[FieldOffset(Offset = "0x38")]
	public ToggleControllerBasedOnAnotherController controllerToggler;

	[Token(Token = "0x4002766")]
	[FieldOffset(Offset = "0x40")]
	public SpeechBubbleUI speechBubble;

	[Token(Token = "0x4002767")]
	[FieldOffset(Offset = "0x48")]
	public Animator faceAnim;

	[Token(Token = "0x4002768")]
	[FieldOffset(Offset = "0x50")]
	public LevelDotsUI levelDotsUI;

	[Token(Token = "0x4002769")]
	[FieldOffset(Offset = "0x58")]
	public List<LevelMusicSettings> computerMusic;

	[Token(Token = "0x400276A")]
	[FieldOffset(Offset = "0x0")]
	public static int strokes;

	[Token(Token = "0x400276B")]
	[FieldOffset(Offset = "0x60")]
	private HoleInOneLevel[] levels;

	[Token(Token = "0x400276C")]
	[FieldOffset(Offset = "0x68")]
	private float nextLostSpeechBubbleTime;

	[Token(Token = "0x400276D")]
	[FieldOffset(Offset = "0x6C")]
	private float lostSpeechBubbleInterval;

	[Token(Token = "0x6002244")]
	[Address(RVA = "0x14772A4", Offset = "0x14772A4", VA = "0x14772A4")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x65DD0", Offset = "0x65DD0")]
	private static void Init()
	{
	}

	[Token(Token = "0x6002245")]
	[Address(RVA = "0x14772F0", Offset = "0x14772F0", VA = "0x14772F0")]
	private void PlayMusic(int musicIndex)
	{
	}

	[Token(Token = "0x6002246")]
	[Address(RVA = "0x1477414", Offset = "0x1477414", VA = "0x1477414")]
	private void ShowSpeechBubble(string text)
	{
	}

	[Token(Token = "0x6002247")]
	[Address(RVA = "0x14774EC", Offset = "0x14774EC", VA = "0x14774EC")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6002248")]
	[Address(RVA = "0x1477560", Offset = "0x1477560", VA = "0x1477560")]
	private void ResetLostSpeechBubbleTimeout()
	{
	}

	[Token(Token = "0x6002249")]
	[Address(RVA = "0x14775B0", Offset = "0x14775B0", VA = "0x14775B0")]
	public Game()
	{
	}

	[Token(Token = "0x600224A")]
	[Address(RVA = "0x14775C8", Offset = "0x14775C8", VA = "0x14775C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65DE4", Offset = "0x65DE4")]
	private void _003CStart_003Eb__16_3(Vector2 obj)
	{
	}
}
