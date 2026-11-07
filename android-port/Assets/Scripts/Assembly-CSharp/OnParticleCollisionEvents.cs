using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x200034F")]
public class OnParticleCollisionEvents : MonoBehaviour
{
	[Token(Token = "0x4001249")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent OnCollisionEnterEvent;

	[Token(Token = "0x400124A")]
	[FieldOffset(Offset = "0x20")]
	private RaycastHit _hit;

	[Token(Token = "0x400124B")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ParticleSystem PSystem;

	[Token(Token = "0x6000F5B")]
	[Address(RVA = "0x159A184", Offset = "0x159A184", VA = "0x159A184")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x6000F5C")]
	[Address(RVA = "0x159A3E8", Offset = "0x159A3E8", VA = "0x159A3E8")]
	public OnParticleCollisionEvents()
	{
	}
}
