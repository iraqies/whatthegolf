using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000885")]
public class Replayer : MonoBehaviour
{
	[Token(Token = "0x4002EAF")]
	[FieldOffset(Offset = "0x18")]
	public bool TimeLineOver;

	[Token(Token = "0x4002EB0")]
	[FieldOffset(Offset = "0x20")]
	public List<Recorder.Snapshot> Snapshots;

	[Token(Token = "0x6002754")]
	[Address(RVA = "0x1649EF8", Offset = "0x1649EF8", VA = "0x1649EF8")]
	private void Start()
	{
	}

	[Token(Token = "0x6002755")]
	[Address(RVA = "0x1649FEC", Offset = "0x1649FEC", VA = "0x1649FEC")]
	private void Update()
	{
	}

	[Token(Token = "0x6002756")]
	[Address(RVA = "0x164A0F8", Offset = "0x164A0F8", VA = "0x164A0F8")]
	public void Reset()
	{
	}

	[Token(Token = "0x6002757")]
	[Address(RVA = "0x164A0FC", Offset = "0x164A0FC", VA = "0x164A0FC")]
	public Replayer()
	{
	}
}
