using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001333")]
	public class IceSlideAudio : MonoBehaviour
	{
		[Token(Token = "0x2001334")]
		public class SlideTarget
		{
			[Token(Token = "0x40066BA")]
			[FieldOffset(Offset = "0x10")]
			public Rigidbody[] allRigids;

			[Token(Token = "0x40066BB")]
			[FieldOffset(Offset = "0x18")]
			public List<Rigidbody> rigidsOnice;

			[Token(Token = "0x6005995")]
			[Address(RVA = "0x17C328C", Offset = "0x17C328C", VA = "0x17C328C")]
			public SlideTarget(Rigidbody[] allRigids, Rigidbody initRigid)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2001335")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48BB0", Offset = "0x48BB0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40066BC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40066BD")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<KeyValuePair<Rigidbody, SlideTarget>> _003C_003E9__16_0;

			[Token(Token = "0x40066BE")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<KeyValuePair<Rigidbody, SlideTarget>> _003C_003E9__18_0;

			[Token(Token = "0x6005997")]
			[Address(RVA = "0x17C3114", Offset = "0x17C3114", VA = "0x17C3114")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6005998")]
			[Address(RVA = "0x17C311C", Offset = "0x17C311C", VA = "0x17C311C")]
			internal int _003CUpdate_003Eb__16_0(KeyValuePair<Rigidbody, SlideTarget> x, KeyValuePair<Rigidbody, SlideTarget> y)
			{
				return default;
			}

			[Token(Token = "0x6005999")]
			[Address(RVA = "0x17C31D4", Offset = "0x17C31D4", VA = "0x17C31D4")]
			internal int _003CDoSort_003Eb__18_0(KeyValuePair<Rigidbody, SlideTarget> x, KeyValuePair<Rigidbody, SlideTarget> y)
			{
				return default;
			}
		}

		[Token(Token = "0x40066AC")]
		[FieldOffset(Offset = "0x18")]
		public AudioSource audioSourcePrefab;

		[Token(Token = "0x40066AD")]
		[FieldOffset(Offset = "0x20")]
		public int maxSources;

		[Token(Token = "0x40066AE")]
		[FieldOffset(Offset = "0x24")]
		public float minForwardVelocity;

		[Token(Token = "0x40066AF")]
		[FieldOffset(Offset = "0x28")]
		public float maxForwardVelocity;

		[Token(Token = "0x40066B0")]
		[FieldOffset(Offset = "0x2C")]
		public float maxVolume;

		[Token(Token = "0x40066B1")]
		[FieldOffset(Offset = "0x30")]
		public float minPitch;

		[Token(Token = "0x40066B2")]
		[FieldOffset(Offset = "0x34")]
		public float maxPitch;

		[Token(Token = "0x40066B3")]
		[FieldOffset(Offset = "0x38")]
		public ClipSettingsCollection sfxOneshotOnEnter;

		[Token(Token = "0x40066B4")]
		[FieldOffset(Offset = "0x40")]
		public AudioClip[] loopClips;

		[Token(Token = "0x40066B5")]
		[FieldOffset(Offset = "0x48")]
		public int iceCount;

		[Token(Token = "0x40066B6")]
		[FieldOffset(Offset = "0x4C")]
		public int applicableIceCount;

		[Token(Token = "0x40066B7")]
		[FieldOffset(Offset = "0x50")]
		private AudioSource[] sources;

		[Token(Token = "0x40066B8")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<Rigidbody, SlideTarget> targetsOnIce;

		[Token(Token = "0x40066B9")]
		[FieldOffset(Offset = "0x60")]
		private List<KeyValuePair<Rigidbody, SlideTarget>> s;

		[Token(Token = "0x600598E")]
		[Address(RVA = "0x14E2BA4", Offset = "0x14E2BA4", VA = "0x14E2BA4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600598F")]
		[Address(RVA = "0x14E2DC8", Offset = "0x14E2DC8", VA = "0x14E2DC8")]
		private void Update()
		{
		}

		[Token(Token = "0x6005990")]
		[Address(RVA = "0x14E3310", Offset = "0x14E3310", VA = "0x14E3310")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6005991")]
		[Address(RVA = "0x14E3580", Offset = "0x14E3580", VA = "0x14E3580")]
		private void DoSort()
		{
		}

		[Token(Token = "0x6005992")]
		[Address(RVA = "0x14E37DC", Offset = "0x14E37DC", VA = "0x14E37DC")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6005993")]
		[Address(RVA = "0x14E3498", Offset = "0x14E3498", VA = "0x14E3498")]
		private static Rigidbody GetParentRigidbody(Rigidbody rigid)
		{
			return null;
		}

		[Token(Token = "0x6005994")]
		[Address(RVA = "0x14E394C", Offset = "0x14E394C", VA = "0x14E394C")]
		public IceSlideAudio()
		{
		}
	}
}
