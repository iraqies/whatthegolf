using System.Collections.Generic;
using Audio.Conditions;
using Audio.Rumble;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013A3")]
	public class RagdollCollisionSounds : MonoBehaviour, IAudioCullable
	{
		[Token(Token = "0x4006990")]
		[FieldOffset(Offset = "0x18")]
		public Transform root;

		[Token(Token = "0x4006991")]
		[FieldOffset(Offset = "0x20")]
		public List<Transform> limbs;

		[Token(Token = "0x4006992")]
		[FieldOffset(Offset = "0x28")]
		public List<Transform> allLimbs;

		[Token(Token = "0x4006993")]
		[FieldOffset(Offset = "0x30")]
		public string limbsParsed;

		[Token(Token = "0x4006994")]
		[FieldOffset(Offset = "0x38")]
		public AudioMaterial audioMaterial;

		[Token(Token = "0x4006995")]
		[FieldOffset(Offset = "0x40")]
		public AudioMaterial[] includeMaterials;

		[Token(Token = "0x4006996")]
		[FieldOffset(Offset = "0x48")]
		public AudioMaterial[] excludeMaterials;

		[Token(Token = "0x4006997")]
		[FieldOffset(Offset = "0x50")]
		public bool onlyBelow;

		[Token(Token = "0x4006998")]
		[FieldOffset(Offset = "0x51")]
		public bool collideWithSelf;

		[Token(Token = "0x4006999")]
		[FieldOffset(Offset = "0x54")]
		public float cooldown;

		[Token(Token = "0x400699A")]
		[FieldOffset(Offset = "0x58")]
		public float minVelocity;

		[Token(Token = "0x400699B")]
		[FieldOffset(Offset = "0x5C")]
		public float maxVelocity;

		[Token(Token = "0x400699C")]
		[FieldOffset(Offset = "0x60")]
		public bool goesAboveMaxVelocity;

		[Token(Token = "0x400699D")]
		[FieldOffset(Offset = "0x68")]
		public RandomAudioClips clips;

		[Token(Token = "0x400699E")]
		[FieldOffset(Offset = "0x70")]
		public ConditionChecker conditions;

		[Token(Token = "0x400699F")]
		[FieldOffset(Offset = "0x78")]
		public List<RumbleEventAsset> rumbles;

		[Token(Token = "0x40069A0")]
		[FieldOffset(Offset = "0x80")]
		private float nextEventTime;

		[Token(Token = "0x40069A1")]
		[FieldOffset(Offset = "0x88")]
		private List<AudioMaterial> include;

		[Token(Token = "0x40069A2")]
		[FieldOffset(Offset = "0x90")]
		private List<AudioMaterial> exclude;

		[Token(Token = "0x40069A3")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A6E0", Offset = "0x5A6E0")]
		private bool IsVisible__BackingField;

		[Token(Token = "0x17000A56")]
		public bool IsVisible
		{
			[Token(Token = "0x6005BB0")]
			[Address(RVA = "0x163B060", Offset = "0x163B060", VA = "0x163B060", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x726B8", Offset = "0x726B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005BB1")]
			[Address(RVA = "0x163B068", Offset = "0x163B068", VA = "0x163B068", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x726C8", Offset = "0x726C8")]
			set
			{
			}
		}

		[Token(Token = "0x6005BB2")]
		[Address(RVA = "0x163B070", Offset = "0x163B070", VA = "0x163B070")]
		private void Start()
		{
		}

		[Token(Token = "0x6005BB3")]
		[Address(RVA = "0x163B584", Offset = "0x163B584", VA = "0x163B584")]
		private void OnCollisionAudio(LimbCollisionInfo.LimbHitInfo hitInfo)
		{
		}

		[Token(Token = "0x6005BB4")]
		[Address(RVA = "0x163B7C0", Offset = "0x163B7C0", VA = "0x163B7C0")]
		public RagdollCollisionSounds()
		{
		}
	}
}
