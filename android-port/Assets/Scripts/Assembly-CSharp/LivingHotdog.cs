using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DA3")]
public class LivingHotdog : MonoBehaviour
{
	[Token(Token = "0x4004A52")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _living;

	[Token(Token = "0x4004A53")]
	[FieldOffset(Offset = "0x20")]
	private bool alive;

	[Token(Token = "0x4004A54")]
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	private bool _activateOnStart;

	[Token(Token = "0x4004A55")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Rigidbody _livingHotDogRigid;

	[Token(Token = "0x6004020")]
	[Address(RVA = "0x153698C", Offset = "0x153698C", VA = "0x153698C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6004021")]
	[Address(RVA = "0x1536B4C", Offset = "0x1536B4C", VA = "0x1536B4C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6004022")]
	[Address(RVA = "0x1536BE4", Offset = "0x1536BE4", VA = "0x1536BE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6004023")]
	[Address(RVA = "0x1536D40", Offset = "0x1536D40", VA = "0x1536D40")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6004024")]
	[Address(RVA = "0x1536D44", Offset = "0x1536D44", VA = "0x1536D44")]
	public LivingHotdog()
	{
	}
}
