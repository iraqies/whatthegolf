using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200092B")]
public class StrokeCounter : MonoBehaviour
{
	[Token(Token = "0x200092C")]
	public class Stroke
	{
		[Token(Token = "0x400321D")]
		[FieldOffset(Offset = "0x10")]
		public RectTransform StrokeRect;

		[Token(Token = "0x400321E")]
		[FieldOffset(Offset = "0x18")]
		public Image Image;

		[Token(Token = "0x400321F")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI Text;

		[Token(Token = "0x4003220")]
		[FieldOffset(Offset = "0x28")]
		public float AppearTimer;

		[Token(Token = "0x4003221")]
		[FieldOffset(Offset = "0x2C")]
		public bool Disappearing;

		[Token(Token = "0x4003222")]
		[FieldOffset(Offset = "0x2D")]
		public bool AppearSoundHasPlayed;

		[Token(Token = "0x17000463")]
		public int CurrentIndex
		{
			[Token(Token = "0x6002A92")]
			[Address(RVA = "0x185B530", Offset = "0x185B530", VA = "0x185B530")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6002A93")]
		[Address(RVA = "0x185B588", Offset = "0x185B588", VA = "0x185B588")]
		public void Reset()
		{
		}

		[Token(Token = "0x6002A94")]
		[Address(RVA = "0x185B638", Offset = "0x185B638", VA = "0x185B638")]
		public Stroke()
		{
		}
	}

	[Token(Token = "0x200092D")]
	public class PlayerStrokeData
	{
		[Token(Token = "0x4003223")]
		[FieldOffset(Offset = "0x10")]
		public List<Stroke> CurrentStrokes;

		[Token(Token = "0x4003224")]
		[FieldOffset(Offset = "0x18")]
		public Queue<Stroke> AvailableStrokeTransforms;

		[Token(Token = "0x4003225")]
		[FieldOffset(Offset = "0x20")]
		public Stroke LastStroke;

		[Token(Token = "0x4003226")]
		[FieldOffset(Offset = "0x28")]
		public bool PlayerActive;

		[Token(Token = "0x4003227")]
		[FieldOffset(Offset = "0x2C")]
		public int TotalStrokes;

		[Token(Token = "0x4003228")]
		[FieldOffset(Offset = "0x30")]
		public int InitialStrokes;

		[Token(Token = "0x4003229")]
		[FieldOffset(Offset = "0x34")]
		public bool HasInitialStrokes;

		[Token(Token = "0x6002A95")]
		[Address(RVA = "0x185B468", Offset = "0x185B468", VA = "0x185B468")]
		public PlayerStrokeData()
		{
		}
	}

	[Token(Token = "0x200092E")]
	public enum CounterTypes
	{
		[Token(Token = "0x400322B")]
		CardsAppearing = 0,
		[Token(Token = "0x400322C")]
		CardsDisappearing = 1
	}

	[Token(Token = "0x200092F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x420A8", Offset = "0x420A8")]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		[Token(Token = "0x400322D")]
		[FieldOffset(Offset = "0x10")]
		public int i;

		[Token(Token = "0x6002A96")]
		[Address(RVA = "0x185B43C", Offset = "0x185B43C", VA = "0x185B43C")]
		public _003C_003Ec__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6002A97")]
		[Address(RVA = "0x185B444", Offset = "0x185B444", VA = "0x185B444")]
		internal bool _003CInstance_OnLevelLoaded_003Eb__0(GolfBallController con)
		{
			return default;
		}
	}

	[Token(Token = "0x4003201")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform strokeAppearPosition;

	[Token(Token = "0x4003202")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2 cardPositionOffset;

	[Token(Token = "0x4003203")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject playerStrokesContainer;

	[Token(Token = "0x4003204")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float positionChangeSpeed;

	[Token(Token = "0x4003205")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float appearSpeed;

	[Token(Token = "0x4003206")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float scaleChangeForCurrent;

	[Token(Token = "0x4003207")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AnimationCurve appearCurve;

	[Token(Token = "0x4003208")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform container;

	[Token(Token = "0x4003209")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<Color> PlayerColors;

	[Token(Token = "0x400320A")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private List<AudioClip> appearClips;

	[Token(Token = "0x400320B")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float appearVolume;

	[Token(Token = "0x400320C")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float appearDelay;

	[Token(Token = "0x400320D")]
	[FieldOffset(Offset = "0x68")]
	public float scaleMod;

	[Token(Token = "0x400320E")]
	[FieldOffset(Offset = "0x6C")]
	public CounterTypes CounterType;

	[Token(Token = "0x400320F")]
	[FieldOffset(Offset = "0x70")]
	public bool UseExternalCountActivator;

	[Token(Token = "0x4003210")]
	[FieldOffset(Offset = "0x74")]
	public float SafeAreaMod;

	[Token(Token = "0x4003211")]
	[FieldOffset(Offset = "0x78")]
	public RectTransform LeaderCrown;

	[Token(Token = "0x4003212")]
	[FieldOffset(Offset = "0x80")]
	private Animator leaderCrownAnimator;

	[Token(Token = "0x4003213")]
	[FieldOffset(Offset = "0x88")]
	public Action<int, int> OnStrokeUpdated;

	[Token(Token = "0x4003214")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<int, PlayerStrokeData> playerData;

	[Token(Token = "0x4003215")]
	[FieldOffset(Offset = "0x98")]
	private Transform[] playerContainers;

	[Token(Token = "0x4003216")]
	[FieldOffset(Offset = "0xA0")]
	private List<Stroke> toBeRemoved;

	[Token(Token = "0x4003217")]
	[FieldOffset(Offset = "0xA8")]
	private List<GolfBallController> subscribedControllers;

	[Token(Token = "0x4003218")]
	[FieldOffset(Offset = "0xB0")]
	private readonly int MAXPLAYERS;

	[Token(Token = "0x4003219")]
	[FieldOffset(Offset = "0xB4")]
	private Vector3 baseOffsetMax;

	[Token(Token = "0x400321A")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 crownTargetPosition;

	[Token(Token = "0x400321B")]
	[FieldOffset(Offset = "0xCC")]
	private Vector2 crownTargetPivot;

	[Token(Token = "0x400321C")]
	[FieldOffset(Offset = "0xD4")]
	private Vector3 crownVelRef;

	[Token(Token = "0x6002A7D")]
	[Address(RVA = "0x16E376C", Offset = "0x16E376C", VA = "0x16E376C")]
	public void Awake()
	{
	}

	[Token(Token = "0x6002A7E")]
	[Address(RVA = "0x16E3D10", Offset = "0x16E3D10", VA = "0x16E3D10")]
	public void Init()
	{
	}

	[Token(Token = "0x6002A7F")]
	[Address(RVA = "0x16E45D8", Offset = "0x16E45D8", VA = "0x16E45D8")]
	private void Instance_OnLevelWillUnload()
	{
	}

	[Token(Token = "0x6002A80")]
	[Address(RVA = "0x16E4724", Offset = "0x16E4724", VA = "0x16E4724")]
	public void SetInitialStrokes(bool hasInitialStrokes, int strokes, int playerIndex)
	{
	}

	[Token(Token = "0x6002A81")]
	[Address(RVA = "0x16E4D44", Offset = "0x16E4D44", VA = "0x16E4D44")]
	public void MoveCrownToPlayer(int playerIndex)
	{
	}

	[Token(Token = "0x6002A82")]
	[Address(RVA = "0x16E4E44", Offset = "0x16E4E44", VA = "0x16E4E44")]
	public void MoveToMiddle()
	{
	}

	[Token(Token = "0x6002A83")]
	[Address(RVA = "0x16E3E94", Offset = "0x16E3E94", VA = "0x16E3E94")]
	public void Instance_OnLevelLoaded(LevelData data)
	{
	}

	[Token(Token = "0x6002A84")]
	[Address(RVA = "0x16E4F28", Offset = "0x16E4F28", VA = "0x16E4F28")]
	public void SubscribePlayerToStrokeCounter(GolfBallController controller, Color color)
	{
	}

	[Token(Token = "0x6002A85")]
	[Address(RVA = "0x16E4FCC", Offset = "0x16E4FCC", VA = "0x16E4FCC")]
	public void SubscribePlayerToStrokeCounter(GolfBallController controller)
	{
	}

	[Token(Token = "0x6002A86")]
	[Address(RVA = "0x16E50EC", Offset = "0x16E50EC", VA = "0x16E50EC")]
	private void Instance_OnGolfStroke(GolfBallController shooter, int strokes)
	{
	}

	[Token(Token = "0x6002A87")]
	[Address(RVA = "0x16E525C", Offset = "0x16E525C", VA = "0x16E525C")]
	public void CountStroke(int strokes)
	{
	}

	[Token(Token = "0x6002A88")]
	[Address(RVA = "0x16E5168", Offset = "0x16E5168", VA = "0x16E5168")]
	public void CountStroke(int playerIndex, int strokes)
	{
	}

	[Token(Token = "0x6002A89")]
	[Address(RVA = "0x16E5268", Offset = "0x16E5268", VA = "0x16E5268")]
	public void RegisterShot(int playerIndex, int strokes)
	{
	}

	[Token(Token = "0x6002A8A")]
	[Address(RVA = "0x16E57A4", Offset = "0x16E57A4", VA = "0x16E57A4")]
	public void RemoveCurrentStroke(int playerIndex)
	{
	}

	[Token(Token = "0x6002A8B")]
	[Address(RVA = "0x16E58D0", Offset = "0x16E58D0", VA = "0x16E58D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6002A8C")]
	[Address(RVA = "0x16E6654", Offset = "0x16E6654", VA = "0x16E6654")]
	public void TogglePlayer(int player, bool state, int order = -1)
	{
	}

	[Token(Token = "0x6002A8D")]
	[Address(RVA = "0x16E672C", Offset = "0x16E672C", VA = "0x16E672C")]
	public void Reset(int resetToThis = 0)
	{
	}

	[Token(Token = "0x6002A8E")]
	[Address(RVA = "0x16E6880", Offset = "0x16E6880", VA = "0x16E6880")]
	public void ToggleLeaderCrown(bool state)
	{
	}

	[Token(Token = "0x6002A8F")]
	[Address(RVA = "0x16E4824", Offset = "0x16E4824", VA = "0x16E4824")]
	public void ResetForPlayer(int playerIndex, int resetToThis)
	{
	}

	[Token(Token = "0x6002A90")]
	[Address(RVA = "0x16E68BC", Offset = "0x16E68BC", VA = "0x16E68BC")]
	public StrokeCounter()
	{
	}

	[Token(Token = "0x6002A91")]
	[Address(RVA = "0x16E696C", Offset = "0x16E696C", VA = "0x16E696C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67850", Offset = "0x67850")]
	private void _003CRegisterShot_003Eb__43_0(AudioSource s)
	{
	}
}
