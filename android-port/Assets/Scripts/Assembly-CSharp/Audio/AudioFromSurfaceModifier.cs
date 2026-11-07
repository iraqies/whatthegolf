using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001382")]
	public class AudioFromSurfaceModifier : MonoBehaviour
	{
		[Token(Token = "0x40068A9")]
		[FieldOffset(Offset = "0x18")]
		public bool TouchingAnySurface;

		[Token(Token = "0x40068AA")]
		[FieldOffset(Offset = "0x20")]
		public string CurrentGround;

		[Token(Token = "0x40068AB")]
		[FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x40068AC")]
		[FieldOffset(Offset = "0x30")]
		public AudioSource audioSource;

		[Token(Token = "0x40068AD")]
		[FieldOffset(Offset = "0x38")]
		public float volumeWhenoff;

		[Token(Token = "0x40068AE")]
		[FieldOffset(Offset = "0x40")]
		public List<Vector3> directions;

		[Token(Token = "0x40068AF")]
		[FieldOffset(Offset = "0x48")]
		public bool localAxis;

		[Token(Token = "0x40068B0")]
		[FieldOffset(Offset = "0x4C")]
		public LayerMask layerMask;

		[Token(Token = "0x40068B1")]
		[FieldOffset(Offset = "0x50")]
		public float distanceToGroundThreshold;

		[Token(Token = "0x40068B2")]
		[FieldOffset(Offset = "0x54")]
		public float decayVolumePerSecond;

		[Token(Token = "0x40068B3")]
		[FieldOffset(Offset = "0x58")]
		public bool use2DRaycast;

		[Token(Token = "0x40068B4")]
		[FieldOffset(Offset = "0x59")]
		public bool muteOnTouching;

		[Token(Token = "0x40068B5")]
		[FieldOffset(Offset = "0x5C")]
		public int raycastFrequency;

		[Token(Token = "0x40068B6")]
		[FieldOffset(Offset = "0x60")]
		private float nextRayCast;

		[Token(Token = "0x40068B7")]
		[FieldOffset(Offset = "0x64")]
		private float cooldown;

		[Token(Token = "0x40068B8")]
		[FieldOffset(Offset = "0x68")]
		private AudioMaterial currentGroundMaterial;

		[Token(Token = "0x40068B9")]
		[FieldOffset(Offset = "0x70")]
		private GameObject currentGround;

		[Token(Token = "0x40068BA")]
		[FieldOffset(Offset = "0x78")]
		public Action<AudioMaterial> onSurfaceChanged;

		[Token(Token = "0x40068BB")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A5A0", Offset = "0x5A5A0")]
		private bool CanMute__BackingField;

		[Token(Token = "0x17000A4D")]
		public bool CanMute
		{
			[Token(Token = "0x6005B1A")]
			[Address(RVA = "0x142D8AC", Offset = "0x142D8AC", VA = "0x142D8AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72588", Offset = "0x72588")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005B1B")]
			[Address(RVA = "0x142D8B4", Offset = "0x142D8B4", VA = "0x142D8B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72598", Offset = "0x72598")]
			set
			{
			}
		}

		[Token(Token = "0x6005B1C")]
		[Address(RVA = "0x142D8BC", Offset = "0x142D8BC", VA = "0x142D8BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005B1D")]
		[Address(RVA = "0x142D8E0", Offset = "0x142D8E0", VA = "0x142D8E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6005B1E")]
		[Address(RVA = "0x142D978", Offset = "0x142D978", VA = "0x142D978")]
		private void Raycast()
		{
		}

		[Token(Token = "0x6005B1F")]
		[Address(RVA = "0x142DA44", Offset = "0x142DA44", VA = "0x142DA44")]
		private bool TouchingSurface(Vector3 direction)
		{
			return default;
		}

		[Token(Token = "0x6005B20")]
		[Address(RVA = "0x142DCF8", Offset = "0x142DCF8", VA = "0x142DCF8")]
		private void SetGroundMaterial(GameObject go)
		{
		}

		[Token(Token = "0x6005B21")]
		[Address(RVA = "0x142DEFC", Offset = "0x142DEFC", VA = "0x142DEFC")]
		public AudioFromSurfaceModifier()
		{
		}
	}
}
