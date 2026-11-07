using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001DE")]
public class RakeTrigger : MonoBehaviour
{
	[Token(Token = "0x40008C8")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask ActivatorLayers;

	[Token(Token = "0x40008C9")]
	[FieldOffset(Offset = "0x20")]
	public HingeJoint RakeHingeJoint;

	[Token(Token = "0x40008CA")]
	[FieldOffset(Offset = "0x28")]
	public List<Joint> PoleJoints;

	[Token(Token = "0x40008CB")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Handle;

	[Token(Token = "0x40008CC")]
	[FieldOffset(Offset = "0x38")]
	public Collider HandleCollider;

	[Token(Token = "0x40008CD")]
	[FieldOffset(Offset = "0x40")]
	public ClipSettingsCollection ActivateClip;

	[Token(Token = "0x40008CE")]
	[FieldOffset(Offset = "0x48")]
	public ClipSettingsCollection HitClip;

	[Token(Token = "0x40008CF")]
	[FieldOffset(Offset = "0x50")]
	private bool activated;

	[Token(Token = "0x600085D")]
	[Address(RVA = "0x163F2AC", Offset = "0x163F2AC", VA = "0x163F2AC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600085E")]
	[Address(RVA = "0x163F624", Offset = "0x163F624", VA = "0x163F624")]
	public RakeTrigger()
	{
	}
}
