using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200075A")]
public class Arrow : MonoBehaviour
{
	[Token(Token = "0x4002710")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip sfxShot;

	[Token(Token = "0x4002711")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip sfxShotSoftener;

	[Token(Token = "0x4002712")]
	[FieldOffset(Offset = "0x28")]
	public BallShooter shooter;

	[Token(Token = "0x4002713")]
	[FieldOffset(Offset = "0x30")]
	private SpriteRenderer sprite;

	[Token(Token = "0x4002714")]
	[FieldOffset(Offset = "0x38")]
	private Camera cam;

	[NonSerialized]
	[Token(Token = "0x4002715")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 aimDir;

	[Token(Token = "0x60021EE")]
	[Address(RVA = "0x1425CE0", Offset = "0x1425CE0", VA = "0x1425CE0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60021EF")]
	[Address(RVA = "0x1425D48", Offset = "0x1425D48", VA = "0x1425D48")]
	public void Reset()
	{
	}

	[Token(Token = "0x60021F0")]
	[Address(RVA = "0x1425D68", Offset = "0x1425D68", VA = "0x1425D68")]
	private void Update()
	{
	}

	[Token(Token = "0x60021F1")]
	[Address(RVA = "0x1425EBC", Offset = "0x1425EBC", VA = "0x1425EBC")]
	public Arrow()
	{
	}
}
