using System;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008B3")]
public class Spit2D : MonoBehaviour
{
	[Token(Token = "0x4002FB9")]
	[FieldOffset(Offset = "0x18")]
	public Collider2D Collider;

	[Token(Token = "0x4002FBA")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody2D Rigidbody;

	[Token(Token = "0x4002FBB")]
	[FieldOffset(Offset = "0x28")]
	public Action OnHitGoal;

	[Token(Token = "0x4002FBC")]
	[FieldOffset(Offset = "0x30")]
	public Action OnMissGoal;

	[Token(Token = "0x4002FBD")]
	[FieldOffset(Offset = "0x38")]
	public LayerMask HitLayers;

	[Token(Token = "0x4002FBE")]
	[FieldOffset(Offset = "0x40")]
	public Action OnReset;

	[Token(Token = "0x4002FBF")]
	[FieldOffset(Offset = "0x48")]
	public ParticleSystem particleSystem;

	[Token(Token = "0x4002FC0")]
	[FieldOffset(Offset = "0x50")]
	public RandomAudioClips hitclips;

	[Token(Token = "0x4002FC1")]
	[FieldOffset(Offset = "0x58")]
	public Renderer MainSpitRenderer;

	[Token(Token = "0x4002FC2")]
	[FieldOffset(Offset = "0x60")]
	public bool Initialized;

	[Token(Token = "0x4002FC3")]
	[FieldOffset(Offset = "0x61")]
	private bool stuck;

	[Token(Token = "0x6002824")]
	[Address(RVA = "0x16D69A8", Offset = "0x16D69A8", VA = "0x16D69A8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002825")]
	[Address(RVA = "0x16D6AAC", Offset = "0x16D6AAC", VA = "0x16D6AAC")]
	private void HitSomething(Collider2D hit)
	{
	}

	[Token(Token = "0x6002826")]
	[Address(RVA = "0x16D6D4C", Offset = "0x16D6D4C", VA = "0x16D6D4C")]
	private void OnCollisionEnter2D(Collision2D col)
	{
	}

	[Token(Token = "0x6002827")]
	[Address(RVA = "0x16D6D84", Offset = "0x16D6D84", VA = "0x16D6D84")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6002828")]
	[Address(RVA = "0x16D6E34", Offset = "0x16D6E34", VA = "0x16D6E34")]
	public void EnteredPortal(PortalPackage package)
	{
	}

	[Token(Token = "0x6002829")]
	[Address(RVA = "0x16D6FE0", Offset = "0x16D6FE0", VA = "0x16D6FE0")]
	public Spit2D()
	{
	}
}
