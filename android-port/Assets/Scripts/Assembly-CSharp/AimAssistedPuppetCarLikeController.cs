using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200024D")]
public class AimAssistedPuppetCarLikeController : PuppetCarLikeController
{
	[Token(Token = "0x4000BBE")]
	[FieldOffset(Offset = "0x88")]
	public float angleThresholdToCorrect;

	[Token(Token = "0x4000BBF")]
	[FieldOffset(Offset = "0x90")]
	public Transform flagPosition;

	[Token(Token = "0x4000BC0")]
	[FieldOffset(Offset = "0x98")]
	private bool shotTowardsFlag;

	[Token(Token = "0x6000A51")]
	[Address(RVA = "0x140B790", Offset = "0x140B790", VA = "0x140B790", Slot = "6")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000A52")]
	[Address(RVA = "0x140B8C0", Offset = "0x140B8C0", VA = "0x140B8C0", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000A53")]
	[Address(RVA = "0x140BC20", Offset = "0x140BC20", VA = "0x140BC20")]
	public AimAssistedPuppetCarLikeController()
	{
	}
}
