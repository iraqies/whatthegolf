using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002C5")]
public class ProjectorController : MonoBehaviour
{
	[Token(Token = "0x4000F29")]
	[FieldOffset(Offset = "0x18")]
	public GameObject projectorImage;

	[Token(Token = "0x4000F2A")]
	[FieldOffset(Offset = "0x20")]
	private Animator projectorAnimator;

	[Token(Token = "0x4000F2B")]
	[FieldOffset(Offset = "0x28")]
	private bool isFadingIn;

	[Token(Token = "0x6000CB8")]
	[Address(RVA = "0x162789C", Offset = "0x162789C", VA = "0x162789C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000CB9")]
	[Address(RVA = "0x16278F8", Offset = "0x16278F8", VA = "0x16278F8")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6000CBA")]
	[Address(RVA = "0x16279A0", Offset = "0x16279A0", VA = "0x16279A0")]
	public ProjectorController()
	{
	}
}
