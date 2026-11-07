using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007F3")]
public class PaperPlaneGravity : MonoBehaviour
{
	[Token(Token = "0x4002A9C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float gravity;

	[Token(Token = "0x4002A9D")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody golfBall;

	[Token(Token = "0x6002480")]
	[Address(RVA = "0x15D85D0", Offset = "0x15D85D0", VA = "0x15D85D0")]
	private void Start()
	{
	}

	[Token(Token = "0x6002481")]
	[Address(RVA = "0x15D866C", Offset = "0x15D866C", VA = "0x15D866C")]
	private void Update()
	{
	}

	[Token(Token = "0x6002482")]
	[Address(RVA = "0x15D86E8", Offset = "0x15D86E8", VA = "0x15D86E8")]
	public PaperPlaneGravity()
	{
	}
}
