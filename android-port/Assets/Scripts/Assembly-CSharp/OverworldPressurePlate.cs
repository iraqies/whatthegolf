using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000DC3")]
public class OverworldPressurePlate : MonoBehaviour
{
	[Token(Token = "0x4004B08")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer RendererButtonUp;

	[Token(Token = "0x4004B09")]
	[FieldOffset(Offset = "0x20")]
	public Transform buttonTop;

	[Token(Token = "0x4004B0A")]
	[FieldOffset(Offset = "0x28")]
	public List<SpriteRenderer> sprites;

	[Token(Token = "0x4004B0B")]
	[FieldOffset(Offset = "0x30")]
	public InvisibleCullingObject culling;

	[Token(Token = "0x4004B0C")]
	[FieldOffset(Offset = "0x38")]
	public float buttonTopUpPositionY;

	[Token(Token = "0x4004B0D")]
	[FieldOffset(Offset = "0x3C")]
	public float buttonTopDownPositionY;

	[Token(Token = "0x4004B0E")]
	[FieldOffset(Offset = "0x40")]
	public UnityEvent OnPress;

	[Token(Token = "0x4004B0F")]
	[FieldOffset(Offset = "0x48")]
	public UnityEvent OnRelease;

	[Token(Token = "0x4004B10")]
	[FieldOffset(Offset = "0x50")]
	public AudioClipSettings downClip;

	[Token(Token = "0x4004B11")]
	[FieldOffset(Offset = "0x58")]
	public AudioClipSettings upClip;

	[Token(Token = "0x4004B12")]
	[FieldOffset(Offset = "0x60")]
	private bool visible;

	[Token(Token = "0x4004B13")]
	[FieldOffset(Offset = "0x64")]
	private int count;

	[Token(Token = "0x4004B14")]
	[FieldOffset(Offset = "0x68")]
	private BoxCollider2D col;

	[Token(Token = "0x4004B15")]
	[FieldOffset(Offset = "0x70")]
	private List<OverworldFanButtonActivator> rigidsOnButton;

	[Token(Token = "0x60040D2")]
	[Address(RVA = "0x15C9E58", Offset = "0x15C9E58", VA = "0x15C9E58")]
	private void Awake()
	{
	}

	[Token(Token = "0x60040D3")]
	[Address(RVA = "0x15CA05C", Offset = "0x15CA05C", VA = "0x15CA05C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60040D4")]
	[Address(RVA = "0x15CA1F8", Offset = "0x15CA1F8", VA = "0x15CA1F8")]
	private void PokeObjectsAndHopePhysicsSolvedIssues()
	{
	}

	[Token(Token = "0x60040D5")]
	[Address(RVA = "0x15CA4F0", Offset = "0x15CA4F0", VA = "0x15CA4F0")]
	private void AddObject(OverworldFanButtonActivator buttonActivator)
	{
	}

	[Token(Token = "0x60040D6")]
	[Address(RVA = "0x15CA660", Offset = "0x15CA660", VA = "0x15CA660")]
	private void RemoveObject(OverworldFanButtonActivator buttonActivator)
	{
	}

	[Token(Token = "0x60040D7")]
	[Address(RVA = "0x15CA72C", Offset = "0x15CA72C", VA = "0x15CA72C")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x60040D8")]
	[Address(RVA = "0x15CA604", Offset = "0x15CA604", VA = "0x15CA604")]
	private void SetButtonDown()
	{
	}

	[Token(Token = "0x60040D9")]
	[Address(RVA = "0x15CA7F8", Offset = "0x15CA7F8", VA = "0x15CA7F8")]
	private void OnTriggerExit2D(Collider2D collision)
	{
	}

	[Token(Token = "0x60040DA")]
	[Address(RVA = "0x15CA0E0", Offset = "0x15CA0E0", VA = "0x15CA0E0")]
	private void SetButtonUp()
	{
	}

	[Token(Token = "0x60040DB")]
	[Address(RVA = "0x15CA8C4", Offset = "0x15CA8C4", VA = "0x15CA8C4")]
	public OverworldPressurePlate()
	{
	}

	[Token(Token = "0x60040DC")]
	[Address(RVA = "0x15CA8CC", Offset = "0x15CA8CC", VA = "0x15CA8CC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D054", Offset = "0x6D054")]
	private void _003CAwake_003Eb__14_0()
	{
	}

	[Token(Token = "0x60040DD")]
	[Address(RVA = "0x15CA8D8", Offset = "0x15CA8D8", VA = "0x15CA8D8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D064", Offset = "0x6D064")]
	private void _003CAwake_003Eb__14_1()
	{
	}
}
