using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200093E")]
public class FakeController : GolfBallController
{
	[Token(Token = "0x4003280")]
	[FieldOffset(Offset = "0x218")]
	public Transform Target;

	[Token(Token = "0x4003281")]
	[FieldOffset(Offset = "0x220")]
	public Vector2 DelayBetweenShots;

	[Token(Token = "0x4003282")]
	[FieldOffset(Offset = "0x228")]
	public Vector2 HoldArrowDuration;

	[Token(Token = "0x4003283")]
	[FieldOffset(Offset = "0x230")]
	public float TargetFollowSpeed;

	[Token(Token = "0x4003284")]
	[FieldOffset(Offset = "0x234")]
	public Vector2 PowerRange;

	[Token(Token = "0x4003285")]
	[FieldOffset(Offset = "0x23C")]
	private float delay;

	[Token(Token = "0x4003286")]
	[FieldOffset(Offset = "0x240")]
	private float holdArrow;

	[Token(Token = "0x4003287")]
	[FieldOffset(Offset = "0x244")]
	private float holdArrowStartDuration;

	[Token(Token = "0x4003288")]
	[FieldOffset(Offset = "0x248")]
	private Transform targetFollower;

	[Token(Token = "0x4003289")]
	[FieldOffset(Offset = "0x250")]
	private Vector3 randomTargetPosition;

	[Token(Token = "0x400328A")]
	[FieldOffset(Offset = "0x25C")]
	private float randomPower;

	[Token(Token = "0x6002AEE")]
	[Address(RVA = "0x145BC54", Offset = "0x145BC54", VA = "0x145BC54", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6002AEF")]
	[Address(RVA = "0x145BC8C", Offset = "0x145BC8C", VA = "0x145BC8C", Slot = "10")]
	protected override Vector2 GetInputPosition()
	{
		return default;
	}

	[Token(Token = "0x6002AF0")]
	[Address(RVA = "0x145BF9C", Offset = "0x145BF9C", VA = "0x145BF9C", Slot = "8")]
	public override bool GetShootButton(bool onlyController = false, string shootButtonName = "Shoot")
	{
		return default;
	}

	[Token(Token = "0x6002AF1")]
	[Address(RVA = "0x145BFA4", Offset = "0x145BFA4", VA = "0x145BFA4", Slot = "7")]
	public override bool GetShootButtonDown(bool onlyController = false, string shootButtonName = "Shoot")
	{
		return default;
	}

	[Token(Token = "0x6002AF2")]
	[Address(RVA = "0x145C054", Offset = "0x145C054", VA = "0x145C054", Slot = "9")]
	public override bool GetShootButtonUp(bool onlyController = false, string shootButtonName = "Shoot")
	{
		return default;
	}

	[Token(Token = "0x6002AF3")]
	[Address(RVA = "0x145C0A0", Offset = "0x145C0A0", VA = "0x145C0A0", Slot = "12")]
	protected override void CheckOutOfBounds(string tag)
	{
	}

	[Token(Token = "0x6002AF4")]
	[Address(RVA = "0x145C184", Offset = "0x145C184", VA = "0x145C184")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6002AF5")]
	[Address(RVA = "0x145C1D0", Offset = "0x145C1D0", VA = "0x145C1D0")]
	public FakeController()
	{
	}
}
