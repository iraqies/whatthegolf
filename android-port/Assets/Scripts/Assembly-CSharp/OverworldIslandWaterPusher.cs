using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A97")]
public class OverworldIslandWaterPusher : MonoBehaviour
{
	[Token(Token = "0x4003ADE")]
	[FieldOffset(Offset = "0x18")]
	public Transform PushTowards;

	[Token(Token = "0x4003ADF")]
	[FieldOffset(Offset = "0x20")]
	public float PushForce;

	[Token(Token = "0x4003AE0")]
	[FieldOffset(Offset = "0x24")]
	public LayerMask PushLayer;

	[Token(Token = "0x6003296")]
	[Address(RVA = "0x15BA530", Offset = "0x15BA530", VA = "0x15BA530")]
	private void OnTriggerStay2D(Collider2D other)
	{
	}

	[Token(Token = "0x6003297")]
	[Address(RVA = "0x15BA650", Offset = "0x15BA650", VA = "0x15BA650")]
	public OverworldIslandWaterPusher()
	{
	}
}
