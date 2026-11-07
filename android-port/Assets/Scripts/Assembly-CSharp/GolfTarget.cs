using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006F7")]
public class GolfTarget : MonoBehaviour
{
	[Token(Token = "0x20006F8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x41200", Offset = "0x41200")]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x4002493")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 startScale;

		[Token(Token = "0x4002494")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 endScale;

		[Token(Token = "0x4002495")]
		[FieldOffset(Offset = "0x28")]
		public GolfTarget _003C_003E4__this;

		[Token(Token = "0x6002029")]
		[Address(RVA = "0x17B6004", Offset = "0x17B6004", VA = "0x17B6004")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600202A")]
		[Address(RVA = "0x17B600C", Offset = "0x17B600C", VA = "0x17B600C")]
		internal void _003COnCollisionEnter_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x400248F")]
	[FieldOffset(Offset = "0x18")]
	public List<AudioClip> HitClips;

	[Token(Token = "0x4002490")]
	[FieldOffset(Offset = "0x20")]
	public bool isCompleted;

	[Token(Token = "0x4002491")]
	[FieldOffset(Offset = "0x24")]
	public LayerMask AcceptedLayers;

	[Token(Token = "0x4002492")]
	[FieldOffset(Offset = "0x28")]
	public IncrementLevelMusicRTPC IncrementRTPC;

	[Token(Token = "0x6002026")]
	[Address(RVA = "0x14A4728", Offset = "0x14A4728", VA = "0x14A4728")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6002027")]
	[Address(RVA = "0x14A495C", Offset = "0x14A495C", VA = "0x14A495C")]
	public GolfTarget()
	{
	}

	[Token(Token = "0x6002028")]
	[Address(RVA = "0x14A4964", Offset = "0x14A4964", VA = "0x14A4964")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x658C8", Offset = "0x658C8")]
	private void _003COnCollisionEnter_003Eb__4_1()
	{
	}
}
