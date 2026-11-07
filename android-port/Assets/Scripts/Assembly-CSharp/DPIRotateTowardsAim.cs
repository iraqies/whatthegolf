using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F0E")]
public class DPIRotateTowardsAim : BaseDailyPrizeInteractions
{
	[Token(Token = "0x4005137")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Rigidbody _rb;

	[Token(Token = "0x4005138")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool useLocalUp;

	[Token(Token = "0x4005139")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float LookInAimDirectionSpeed;

	[Token(Token = "0x6004661")]
	[Address(RVA = "0x18C8398", Offset = "0x18C8398", VA = "0x18C8398", Slot = "6")]
	public override void OnAimNotWrapped(Vector3 b)
	{
	}

	[Token(Token = "0x6004662")]
	[Address(RVA = "0x18C8558", Offset = "0x18C8558", VA = "0x18C8558")]
	public DPIRotateTowardsAim()
	{
	}
}
