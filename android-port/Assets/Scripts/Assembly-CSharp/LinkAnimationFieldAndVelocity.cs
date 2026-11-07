using Chronos;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x2000C03")]
public class LinkAnimationFieldAndVelocity : MonoBehaviour
{
	[Token(Token = "0x4004285")]
	[FieldOffset(Offset = "0x18")]
	public string FieldName;

	[Token(Token = "0x4004286")]
	[FieldOffset(Offset = "0x20")]
	public float Mod;

	[Token(Token = "0x4004287")]
	[FieldOffset(Offset = "0x28")]
	public Animator Animator;

	[Token(Token = "0x4004288")]
	[FieldOffset(Offset = "0x30")]
	public Rigidbody Rigidbody;

	[Token(Token = "0x4004289")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 oldPos;

	[Token(Token = "0x400428A")]
	[FieldOffset(Offset = "0x48")]
	private Timeline timeline;

	[Token(Token = "0x400428B")]
	[FieldOffset(Offset = "0x50")]
	private bool firstFrame;

	[Token(Token = "0x400428C")]
	[FieldOffset(Offset = "0x58")]
	private NavMeshAgent navmeshAgent;

	[Token(Token = "0x60039AC")]
	[Address(RVA = "0x1534130", Offset = "0x1534130", VA = "0x1534130")]
	private void Start()
	{
	}

	[Token(Token = "0x60039AD")]
	[Address(RVA = "0x15341B0", Offset = "0x15341B0", VA = "0x15341B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60039AE")]
	[Address(RVA = "0x1534480", Offset = "0x1534480", VA = "0x1534480")]
	public LinkAnimationFieldAndVelocity()
	{
	}
}
