using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SaloonPiano
{
	[Token(Token = "0x2001093")]
	public class NoteTarget : MonoBehaviour
	{
		[Token(Token = "0x400571F")]
		[FieldOffset(Offset = "0x18")]
		public LayerMask AcceptedLayers;

		[Token(Token = "0x4005720")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55AD0", Offset = "0x55AD0")]
		private Action m_OnHit;

		[Token(Token = "0x4005721")]
		[FieldOffset(Offset = "0x28")]
		public GameObject notHitRoot;

		[Token(Token = "0x4005722")]
		[FieldOffset(Offset = "0x30")]
		public GameObject notHitCorrectRoot;

		[Token(Token = "0x4005723")]
		[FieldOffset(Offset = "0x38")]
		public GameObject notHitWrongRoot;

		[Token(Token = "0x4005724")]
		[FieldOffset(Offset = "0x40")]
		public GameObject hitRoot;

		[Token(Token = "0x4005725")]
		[FieldOffset(Offset = "0x48")]
		public ParticleSystem hitParticleSystem;

		[Token(Token = "0x4005726")]
		[FieldOffset(Offset = "0x50")]
		private bool hasBeenHit;

		[Token(Token = "0x4005727")]
		[FieldOffset(Offset = "0x51")]
		private bool isWrong;

		[Token(Token = "0x1400007C")]
		public event Action OnHit
		{
			[Token(Token = "0x6004A43")]
			[Address(RVA = "0x158DFE4", Offset = "0x158DFE4", VA = "0x158DFE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F494", Offset = "0x6F494")]
			add
			{
			}
			[Token(Token = "0x6004A44")]
			[Address(RVA = "0x158E088", Offset = "0x158E088", VA = "0x158E088")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F4A4", Offset = "0x6F4A4")]
			remove
			{
			}
		}

		[Token(Token = "0x6004A45")]
		[Address(RVA = "0x158E12C", Offset = "0x158E12C", VA = "0x158E12C")]
		public void Initialize(bool isWrong)
		{
		}

		[Token(Token = "0x6004A46")]
		[Address(RVA = "0x158E178", Offset = "0x158E178", VA = "0x158E178")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6004A47")]
		[Address(RVA = "0x158E260", Offset = "0x158E260", VA = "0x158E260")]
		public NoteTarget()
		{
		}
	}
}
