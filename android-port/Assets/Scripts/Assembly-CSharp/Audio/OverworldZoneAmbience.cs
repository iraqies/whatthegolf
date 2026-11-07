using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

namespace Audio
{
	[Token(Token = "0x2001395")]
	public class OverworldZoneAmbience : MonoBehaviour
	{
		[Token(Token = "0x400691E")]
		[FieldOffset(Offset = "0x18")]
		public bool requireBallShape;

		[Token(Token = "0x400691F")]
		[FieldOffset(Offset = "0x20")]
		public Transmogrif.BALLSHAPES[] requiredBallShapes;

		[Token(Token = "0x4006920")]
		[FieldOffset(Offset = "0x28")]
		public bool wontStopOnExit;

		[Token(Token = "0x4006921")]
		[FieldOffset(Offset = "0x30")]
		public ClipSettingsCollection oneshotOnZoneEnter;

		[Token(Token = "0x4006922")]
		[FieldOffset(Offset = "0x38")]
		public float oneshotCooldown;

		[Token(Token = "0x4006923")]
		[FieldOffset(Offset = "0x0")]
		public static Action<OverworldZoneAmbience> OnZoneEnter;

		[Token(Token = "0x4006924")]
		[FieldOffset(Offset = "0x8")]
		public static Action<OverworldZoneAmbience> OnZoneExit;

		[Token(Token = "0x4006925")]
		[FieldOffset(Offset = "0x40")]
		public AudioMixerSnapshot mixerSnapshot;

		[Token(Token = "0x4006926")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A5D0", Offset = "0x5A5D0")]
		private List<AmbientAudio> ambients__BackingField;

		[Token(Token = "0x4006927")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A5E0", Offset = "0x5A5E0")]
		private float nextOneshotTime__BackingField;

		[Token(Token = "0x17000A4F")]
		public List<AmbientAudio> ambients
		{
			[Token(Token = "0x6005B5C")]
			[Address(RVA = "0x15D408C", Offset = "0x15D408C", VA = "0x15D408C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x725D8", Offset = "0x725D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B5D")]
			[Address(RVA = "0x15D4094", Offset = "0x15D4094", VA = "0x15D4094")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x725E8", Offset = "0x725E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000A50")]
		public float nextOneshotTime
		{
			[Token(Token = "0x6005B5E")]
			[Address(RVA = "0x15D409C", Offset = "0x15D409C", VA = "0x15D409C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x725F8", Offset = "0x725F8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005B5F")]
			[Address(RVA = "0x15D40A4", Offset = "0x15D40A4", VA = "0x15D40A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72608", Offset = "0x72608")]
			set
			{
			}
		}

		[Token(Token = "0x6005B60")]
		[Address(RVA = "0x15D40AC", Offset = "0x15D40AC", VA = "0x15D40AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005B61")]
		[Address(RVA = "0x15D414C", Offset = "0x15D414C", VA = "0x15D414C")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6005B62")]
		[Address(RVA = "0x15D42AC", Offset = "0x15D42AC", VA = "0x15D42AC")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x6005B63")]
		[Address(RVA = "0x15D4374", Offset = "0x15D4374", VA = "0x15D4374")]
		public OverworldZoneAmbience()
		{
		}
	}
}
