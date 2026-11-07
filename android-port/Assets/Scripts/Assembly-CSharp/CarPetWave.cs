using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D66")]
[Attribute(Name = "RequireComponent", RVA = "0x44938", Offset = "0x44938")]
public class CarPetWave : MonoBehaviour
{
	[Token(Token = "0x40048F8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int WorldSpaceOffset;

	[Token(Token = "0x40048F9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_Speed;

	[Token(Token = "0x40048FA")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float _texturescrolling;

	[Token(Token = "0x40048FB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector3 m_MoveAxis;

	[Token(Token = "0x40048FC")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private MeshRenderer m_MeshRenderer;

	[Token(Token = "0x40048FD")]
	[FieldOffset(Offset = "0x38")]
	private Vector4 m_Offset;

	[Token(Token = "0x40048FE")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody m_RigidBody;

	[Token(Token = "0x6003F13")]
	[Address(RVA = "0x188A294", Offset = "0x188A294", VA = "0x188A294")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003F14")]
	[Address(RVA = "0x188A2F0", Offset = "0x188A2F0", VA = "0x188A2F0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003F15")]
	[Address(RVA = "0x188A434", Offset = "0x188A434", VA = "0x188A434")]
	public void Setup(Vector3 m, float speed)
	{
	}

	[Token(Token = "0x6003F16")]
	[Address(RVA = "0x188A444", Offset = "0x188A444", VA = "0x188A444")]
	public void SetSpeed(float s)
	{
	}

	[Token(Token = "0x6003F17")]
	[Address(RVA = "0x188A44C", Offset = "0x188A44C", VA = "0x188A44C")]
	public CarPetWave()
	{
	}
}
