using Audio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000331")]
public class AddRandomForceToRigid : MonoBehaviour
{
	[Token(Token = "0x40011A8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Rigidbody Rigidbody;

	[Token(Token = "0x40011A9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ParticleSystem Particles;

	[Token(Token = "0x40011AA")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float forceMultiplier;

	[Token(Token = "0x40011AB")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Animator Animator;

	[Token(Token = "0x40011AC")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AudioEventAsset sfxEventOnCollapse;

	[Token(Token = "0x40011AD")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool CountTicks;

	[Token(Token = "0x40011AE")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UnityEvent BeforeCollapse;

	[Token(Token = "0x40011AF")]
	[FieldOffset(Offset = "0x50")]
	private bool hasCollapsed;

	[Token(Token = "0x6000EBB")]
	[Address(RVA = "0x1407C74", Offset = "0x1407C74", VA = "0x1407C74")]
	public void AddForceToAllOther()
	{
	}

	[Token(Token = "0x6000EBC")]
	[Address(RVA = "0x1407D6C", Offset = "0x1407D6C", VA = "0x1407D6C")]
	public void Collapse(Transform center)
	{
	}

	[Token(Token = "0x6000EBD")]
	[Address(RVA = "0x1407EFC", Offset = "0x1407EFC", VA = "0x1407EFC")]
	public AddRandomForceToRigid()
	{
	}
}
