using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200136D")]
	public abstract class AudioEventListenerBase : MonoBehaviour
	{
		[Token(Token = "0x4006821")]
		[FieldOffset(Offset = "0x18")]
		public Component listenComponent;

		[Token(Token = "0x4006822")]
		[FieldOffset(Offset = "0x20")]
		public bool listen;

		[Token(Token = "0x4006823")]
		[FieldOffset(Offset = "0x21")]
		public bool findFirstTransmitterInParent;

		[Token(Token = "0x6005AC2")]
		[Address(RVA = "0x142D2B0", Offset = "0x142D2B0", VA = "0x142D2B0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6005AC3")]
		[Address(RVA = "0x142D540", Offset = "0x142D540", VA = "0x142D540", Slot = "5")]
		public virtual void Play()
		{
		}

		[Token(Token = "0x6005AC4")]
		[Address(RVA = "0x142D544", Offset = "0x142D544", VA = "0x142D544", Slot = "6")]
		public virtual void Play(Vector3 position)
		{
		}

		[Token(Token = "0x6005AC5")]
		[Address(RVA = "0x142D548", Offset = "0x142D548", VA = "0x142D548", Slot = "7")]
		public virtual void Play(Vector3 position, float volumeMultiplier = 1f, float pitchMultiplier = 1f)
		{
		}

		[Token(Token = "0x6005AC6")]
		[Address(RVA = "0x142D54C", Offset = "0x142D54C", VA = "0x142D54C")]
		protected AudioEventListenerBase()
		{
		}
	}
}
