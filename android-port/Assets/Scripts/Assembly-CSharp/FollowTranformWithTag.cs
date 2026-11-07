using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000347")]
public class FollowTranformWithTag : MonoBehaviour
{
	[Token(Token = "0x400121C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string followTag;

	[Token(Token = "0x400121D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UnityEvent OnFollowDestroyed;

	[Token(Token = "0x400121E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UnityEvent OnFollowFound;

	[Token(Token = "0x400121F")]
	[FieldOffset(Offset = "0x30")]
	private Transform follow;

	[Token(Token = "0x4001220")]
	[FieldOffset(Offset = "0x38")]
	private bool hasFollow;

	[Token(Token = "0x6000F36")]
	[Address(RVA = "0x1470250", Offset = "0x1470250", VA = "0x1470250")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000F37")]
	[Address(RVA = "0x1470414", Offset = "0x1470414", VA = "0x1470414")]
	public FollowTranformWithTag()
	{
	}
}
