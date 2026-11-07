using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A3A")]
public class OverworldFanButton : MonoBehaviour
{
	[Token(Token = "0x4003873")]
	[FieldOffset(Offset = "0x18")]
	public List<OverworldFan> connectedFans;

	[Token(Token = "0x4003874")]
	[FieldOffset(Offset = "0x20")]
	public bool onFanState;

	[Token(Token = "0x4003875")]
	[FieldOffset(Offset = "0x28")]
	public SpriteRenderer RendererButtonUp;

	[Token(Token = "0x4003876")]
	[FieldOffset(Offset = "0x30")]
	public Transform buttonTop;

	[Token(Token = "0x4003877")]
	[FieldOffset(Offset = "0x38")]
	public List<SpriteRenderer> sprites;

	[Token(Token = "0x4003878")]
	[FieldOffset(Offset = "0x40")]
	public InvisibleCullingObject culling;

	[Token(Token = "0x4003879")]
	[FieldOffset(Offset = "0x48")]
	public float buttonTopUpPositionY;

	[Token(Token = "0x400387A")]
	[FieldOffset(Offset = "0x4C")]
	public float buttonTopDownPositionY;

	[Token(Token = "0x400387B")]
	[FieldOffset(Offset = "0x50")]
	public AudioClipSettings downClip;

	[Token(Token = "0x400387C")]
	[FieldOffset(Offset = "0x58")]
	public AudioClipSettings upClip;

	[Token(Token = "0x400387D")]
	[FieldOffset(Offset = "0x60")]
	private bool visible;

	[Token(Token = "0x400387E")]
	[FieldOffset(Offset = "0x64")]
	private int count;

	[Token(Token = "0x400387F")]
	[FieldOffset(Offset = "0x68")]
	private BoxCollider2D col;

	[Token(Token = "0x4003880")]
	[FieldOffset(Offset = "0x70")]
	private List<OverworldFanButtonActivator> rigidsOnButton;

	[Token(Token = "0x4003881")]
	[FieldOffset(Offset = "0x78")]
	public OverworldFanButtonActivator defaultObject;

	[Token(Token = "0x60030B0")]
	[Address(RVA = "0x15B6680", Offset = "0x15B6680", VA = "0x15B6680")]
	private void SetFans(bool state)
	{
	}

	[Token(Token = "0x60030B1")]
	[Address(RVA = "0x15B67D4", Offset = "0x15B67D4", VA = "0x15B67D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60030B2")]
	[Address(RVA = "0x15B69D8", Offset = "0x15B69D8", VA = "0x15B69D8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60030B3")]
	[Address(RVA = "0x15B6B8C", Offset = "0x15B6B8C", VA = "0x15B6B8C")]
	private void PokeObjectsAndHopePhysicsSolvedIssues()
	{
	}

	[Token(Token = "0x60030B4")]
	[Address(RVA = "0x15B6FCC", Offset = "0x15B6FCC", VA = "0x15B6FCC")]
	public void AddAObject()
	{
	}

	[Token(Token = "0x60030B5")]
	[Address(RVA = "0x15B6E84", Offset = "0x15B6E84", VA = "0x15B6E84")]
	private void AddObject(OverworldFanButtonActivator buttonActivator)
	{
	}

	[Token(Token = "0x60030B6")]
	[Address(RVA = "0x15B7094", Offset = "0x15B7094", VA = "0x15B7094")]
	private void RemoveObject(OverworldFanButtonActivator buttonActivator)
	{
	}

	[Token(Token = "0x60030B7")]
	[Address(RVA = "0x15B7160", Offset = "0x15B7160", VA = "0x15B7160")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60030B8")]
	[Address(RVA = "0x15B726C", Offset = "0x15B726C", VA = "0x15B726C")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x60030B9")]
	[Address(RVA = "0x15B703C", Offset = "0x15B703C", VA = "0x15B703C")]
	private void SetButtonDown()
	{
	}

	[Token(Token = "0x60030BA")]
	[Address(RVA = "0x15B7338", Offset = "0x15B7338", VA = "0x15B7338")]
	private void OnTriggerExit2D(Collider2D collision)
	{
	}

	[Token(Token = "0x60030BB")]
	[Address(RVA = "0x15B6A70", Offset = "0x15B6A70", VA = "0x15B6A70")]
	private void SetButtonUp()
	{
	}

	[Token(Token = "0x60030BC")]
	[Address(RVA = "0x15B7404", Offset = "0x15B7404", VA = "0x15B7404")]
	public OverworldFanButton()
	{
	}

	[Token(Token = "0x60030BD")]
	[Address(RVA = "0x15B740C", Offset = "0x15B740C", VA = "0x15B740C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6958C", Offset = "0x6958C")]
	private void _003CAwake_003Eb__16_0()
	{
	}

	[Token(Token = "0x60030BE")]
	[Address(RVA = "0x15B7418", Offset = "0x15B7418", VA = "0x15B7418")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6959C", Offset = "0x6959C")]
	private void _003CAwake_003Eb__16_1()
	{
	}
}
