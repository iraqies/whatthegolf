using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B7B")]
public class WheelSkid : MonoBehaviour
{
	[Token(Token = "0x4004004")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Skidmarks skidmarksController;

	[Token(Token = "0x4004005")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LayerMask groundMask;

	[Token(Token = "0x4004006")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector2 skidMarkIntensityRange;

	[Token(Token = "0x4004007")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rb;

	[Token(Token = "0x4004008")]
	private const float SKID_FX_SPEED = 0f;

	[Token(Token = "0x4004009")]
	private const float MAX_SKID_INTENSITY = 0f;

	[Token(Token = "0x400400A")]
	private const float WHEEL_SLIP_MULTIPLIER = 5f;

	[Token(Token = "0x400400B")]
	[FieldOffset(Offset = "0x38")]
	private int lastSkid;

	[Token(Token = "0x6003766")]
	[Address(RVA = "0x175409C", Offset = "0x175409C", VA = "0x175409C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003767")]
	[Address(RVA = "0x17540F8", Offset = "0x17540F8", VA = "0x17540F8")]
	protected void LateUpdate()
	{
	}

	[Token(Token = "0x6003768")]
	[Address(RVA = "0x1754374", Offset = "0x1754374", VA = "0x1754374")]
	public WheelSkid()
	{
	}
}
