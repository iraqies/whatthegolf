using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000415")]
public class ParChallenge : Challenge
{
	[Serializable]
	[Token(Token = "0x2000416")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F9DC", Offset = "0x3F9DC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400165F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001660")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__24_0;

		[Token(Token = "0x6001340")]
		[Address(RVA = "0x182253C", Offset = "0x182253C", VA = "0x182253C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001341")]
		[Address(RVA = "0x1822544", Offset = "0x1822544", VA = "0x1822544")]
		internal void _003COnShoot_003Eb__24_0(float v)
		{
		}
	}

	[Token(Token = "0x400164B")]
	[FieldOffset(Offset = "0xA4")]
	public int ScoreToBeat;

	[Token(Token = "0x400164C")]
	[FieldOffset(Offset = "0xA8")]
	public Rigidbody controllerRigid;

	[Token(Token = "0x400164D")]
	[FieldOffset(Offset = "0xB0")]
	public GolfBallController SpecificController;

	[Token(Token = "0x400164E")]
	[FieldOffset(Offset = "0xB8")]
	public bool FindAdditionalControllers;

	[Token(Token = "0x400164F")]
	[FieldOffset(Offset = "0xB9")]
	public bool BlockShootingAfterLastShot;

	[Token(Token = "0x4001650")]
	[FieldOffset(Offset = "0xBA")]
	public bool AutoFail;

	[Token(Token = "0x4001651")]
	[FieldOffset(Offset = "0xBC")]
	public float AutoFailThreshold;

	[Token(Token = "0x4001652")]
	[FieldOffset(Offset = "0xC0")]
	public float AutoFailTimer;

	[Token(Token = "0x4001653")]
	[FieldOffset(Offset = "0xC4")]
	public bool DoDelayedFailOnAllShotsUsed;

	[Token(Token = "0x4001654")]
	[FieldOffset(Offset = "0xC8")]
	public float Delay;

	[Token(Token = "0x4001655")]
	[FieldOffset(Offset = "0xCC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D61C", Offset = "0x4D61C")]
	private bool IsLastShotOrPast__BackingField;

	[Token(Token = "0x4001656")]
	[FieldOffset(Offset = "0xD0")]
	private AutoFailBase m_customAutoFail;

	[Token(Token = "0x4001657")]
	[FieldOffset(Offset = "0xD8")]
	private GolfBallController controller;

	[Token(Token = "0x4001658")]
	[FieldOffset(Offset = "0xE0")]
	private GolfBallController[] additionalControllers;

	[Token(Token = "0x4001659")]
	[FieldOffset(Offset = "0xE8")]
	private bool checkVelocity;

	[Token(Token = "0x400165A")]
	[FieldOffset(Offset = "0xEC")]
	private float m_failTimer;

	[Token(Token = "0x400165B")]
	[FieldOffset(Offset = "0xF0")]
	private float m_startFailCheckTime;

	[Token(Token = "0x400165C")]
	[FieldOffset(Offset = "0xF4")]
	private int strokeCount;

	[Token(Token = "0x400165D")]
	[FieldOffset(Offset = "0xF8")]
	private Vector3 _lastPosition;

	[Token(Token = "0x400165E")]
	[FieldOffset(Offset = "0x104")]
	private Vector3 _movementDelta;

	[Token(Token = "0x1700022B")]
	public bool IsLastShotOrPast
	{
		[Token(Token = "0x6001334")]
		[Address(RVA = "0x15D958C", Offset = "0x15D958C", VA = "0x15D958C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61E3C", Offset = "0x61E3C")]
		get
		{
			return default;
		}
		[Token(Token = "0x6001335")]
		[Address(RVA = "0x15D9594", Offset = "0x15D9594", VA = "0x15D9594")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61E4C", Offset = "0x61E4C")]
		private set
		{
		}
	}

	[Token(Token = "0x6001336")]
	[Address(RVA = "0x15D959C", Offset = "0x15D959C", VA = "0x15D959C", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x6001337")]
	[Address(RVA = "0x15D99C4", Offset = "0x15D99C4", VA = "0x15D99C4", Slot = "5")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x6001338")]
	[Address(RVA = "0x15D9B08", Offset = "0x15D9B08", VA = "0x15D9B08", Slot = "6")]
	public override string GetWinMessageID()
	{
		return null;
	}

	[Token(Token = "0x6001339")]
	[Address(RVA = "0x15D9B6C", Offset = "0x15D9B6C", VA = "0x15D9B6C")]
	private void OnShoot(GolfBallController controller, int strokes)
	{
	}

	[Token(Token = "0x600133A")]
	[Address(RVA = "0x15D9FE8", Offset = "0x15D9FE8", VA = "0x15D9FE8", Slot = "9")]
	protected override void ChallengeUpdate()
	{
	}

	[Token(Token = "0x600133B")]
	[Address(RVA = "0x15DA1F0", Offset = "0x15DA1F0", VA = "0x15DA1F0")]
	private void MovementFailCheck(Vector3 movement)
	{
	}

	[Token(Token = "0x600133C")]
	[Address(RVA = "0x15DA270", Offset = "0x15DA270", VA = "0x15DA270", Slot = "10")]
	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	[Token(Token = "0x600133D")]
	[Address(RVA = "0x15DA318", Offset = "0x15DA318", VA = "0x15DA318")]
	public ParChallenge()
	{
	}

	[Token(Token = "0x600133E")]
	[Address(RVA = "0x15DA338", Offset = "0x15DA338", VA = "0x15DA338")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61E5C", Offset = "0x61E5C")]
	private void _003COnShoot_003Eb__24_1()
	{
	}
}
