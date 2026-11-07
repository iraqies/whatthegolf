using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D90")]
public class HiddenTreeSoccerPlayer : MonoBehaviour
{
	[Token(Token = "0x40049B9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animator _animator;

	[Token(Token = "0x40049BA")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<Rigidbody> _treeParts;

	[Token(Token = "0x40049BB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int SawPlayer;

	[Token(Token = "0x40049BC")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _goop;

	[Token(Token = "0x40049BD")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _face;

	[Token(Token = "0x40049BE")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject _goopToActivate;

	[Token(Token = "0x40049BF")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ParticleSystem _particles;

	[Token(Token = "0x40049C0")]
	[FieldOffset(Offset = "0x48")]
	private bool done;

	[Token(Token = "0x6003FC5")]
	[Address(RVA = "0x14C6BA8", Offset = "0x14C6BA8", VA = "0x14C6BA8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003FC6")]
	[Address(RVA = "0x14C6F2C", Offset = "0x14C6F2C", VA = "0x14C6F2C")]
	public HiddenTreeSoccerPlayer()
	{
	}
}
