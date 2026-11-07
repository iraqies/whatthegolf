using Audio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E01")]
public class AmongUsCrewmateImposter : MonoBehaviour
{
	[Token(Token = "0x4004C34")]
	[FieldOffset(Offset = "0x18")]
	public GameObject HatItem;

	[Token(Token = "0x4004C35")]
	[FieldOffset(Offset = "0x20")]
	public ClipSettingsCollection gruntClipCollection;

	[Token(Token = "0x4004C36")]
	[FieldOffset(Offset = "0x28")]
	public ClipSettingsCollection impactClipCollection;

	[Token(Token = "0x4004C37")]
	[FieldOffset(Offset = "0x30")]
	private Transform position;

	[Token(Token = "0x4004C38")]
	[FieldOffset(Offset = "0x38")]
	public UnityEvent OnHit;

	[Token(Token = "0x4004C39")]
	[FieldOffset(Offset = "0x40")]
	private Animator animator;

	[Token(Token = "0x4004C3A")]
	[FieldOffset(Offset = "0x48")]
	private bool isHit;

	[Token(Token = "0x60041E4")]
	[Address(RVA = "0x140F06C", Offset = "0x140F06C", VA = "0x140F06C")]
	private void Start()
	{
	}

	[Token(Token = "0x60041E5")]
	[Address(RVA = "0x140F1CC", Offset = "0x140F1CC", VA = "0x140F1CC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60041E6")]
	[Address(RVA = "0x140F138", Offset = "0x140F138", VA = "0x140F138")]
	private void DefaultSetPos()
	{
	}

	[Token(Token = "0x60041E7")]
	[Address(RVA = "0x140F4B4", Offset = "0x140F4B4", VA = "0x140F4B4")]
	private void Play()
	{
	}

	[Token(Token = "0x60041E8")]
	[Address(RVA = "0x140F5A0", Offset = "0x140F5A0", VA = "0x140F5A0")]
	public AmongUsCrewmateImposter()
	{
	}
}
