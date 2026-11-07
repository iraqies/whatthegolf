using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006B0")]
public class CarOpponentController : GolfBallController
{
	[Token(Token = "0x40022F1")]
	[FieldOffset(Offset = "0x218")]
	public Transform TargetContainer;

	[Token(Token = "0x40022F2")]
	[FieldOffset(Offset = "0x220")]
	public Vector2 DelayBetweenShots;

	[Token(Token = "0x40022F3")]
	[FieldOffset(Offset = "0x228")]
	public Vector2 HoldArrowDuration;

	[Token(Token = "0x40022F4")]
	[FieldOffset(Offset = "0x230")]
	public float EdgeCheckDistanceMod;

	[Token(Token = "0x40022F5")]
	[FieldOffset(Offset = "0x234")]
	public float EdgeCheckDownwardsDistance;

	[Token(Token = "0x40022F6")]
	[FieldOffset(Offset = "0x238")]
	private float holdArrow;

	[Token(Token = "0x40022F7")]
	[FieldOffset(Offset = "0x23C")]
	private float holdArrowStartDuration;

	[Token(Token = "0x40022F8")]
	[FieldOffset(Offset = "0x240")]
	private Rigidbody rigid;

	[Token(Token = "0x40022F9")]
	[FieldOffset(Offset = "0x248")]
	private bool forceShot;

	[Token(Token = "0x40022FA")]
	[FieldOffset(Offset = "0x24C")]
	private int target;

	[Token(Token = "0x40022FB")]
	[FieldOffset(Offset = "0x250")]
	private int targetChild;

	[Token(Token = "0x6001EC6")]
	[Address(RVA = "0x18899C4", Offset = "0x18899C4", VA = "0x18899C4", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001EC7")]
	[Address(RVA = "0x1889A34", Offset = "0x1889A34", VA = "0x1889A34")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001EC8")]
	[Address(RVA = "0x1889C98", Offset = "0x1889C98", VA = "0x1889C98", Slot = "11")]
	protected override bool IsStartingToAim()
	{
		return default;
	}

	[Token(Token = "0x6001EC9")]
	[Address(RVA = "0x1889D44", Offset = "0x1889D44", VA = "0x1889D44", Slot = "10")]
	protected override Vector2 GetInputPosition()
	{
		return default;
	}

	[Token(Token = "0x6001ECA")]
	[Address(RVA = "0x1889E84", Offset = "0x1889E84", VA = "0x1889E84", Slot = "8")]
	public override bool GetShootButton(bool onlyController = false, string shootButtonName = "Shoot")
	{
		return default;
	}

	[Token(Token = "0x6001ECB")]
	[Address(RVA = "0x1889E8C", Offset = "0x1889E8C", VA = "0x1889E8C", Slot = "7")]
	public override bool GetShootButtonDown(bool onlyController = false, string shootButtonName = "Shoot")
	{
		return default;
	}

	[Token(Token = "0x6001ECC")]
	[Address(RVA = "0x1889EF8", Offset = "0x1889EF8", VA = "0x1889EF8", Slot = "9")]
	public override bool GetShootButtonUp(bool onlyController = false, string shootButtonName = "Shoot")
	{
		return default;
	}

	[Token(Token = "0x6001ECD")]
	[Address(RVA = "0x1889F44", Offset = "0x1889F44", VA = "0x1889F44", Slot = "6")]
	internal override Vector3 GetFinalAimVector()
	{
		return default;
	}

	[Token(Token = "0x6001ECE")]
	[Address(RVA = "0x1889FA8", Offset = "0x1889FA8", VA = "0x1889FA8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001ECF")]
	[Address(RVA = "0x1889FE0", Offset = "0x1889FE0", VA = "0x1889FE0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001ED0")]
	[Address(RVA = "0x188A264", Offset = "0x188A264", VA = "0x188A264")]
	public CarOpponentController()
	{
	}
}
