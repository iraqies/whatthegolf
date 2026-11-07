using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001399")]
	public class PlayerCarAudioV2 : MonoBehaviour, ISpatializeDisable
	{
		[Token(Token = "0x4006934")]
		[FieldOffset(Offset = "0x18")]
		public AudioClipSettings FirstAimClip;

		[Token(Token = "0x4006935")]
		[FieldOffset(Offset = "0x20")]
		public ClipSettingsCollection ForwardShootClips;

		[Token(Token = "0x4006936")]
		[FieldOffset(Offset = "0x28")]
		public ClipSettingsCollection DriftShootClips;

		[Token(Token = "0x4006937")]
		[FieldOffset(Offset = "0x30")]
		public float thresholdForward;

		[Token(Token = "0x4006938")]
		[FieldOffset(Offset = "0x38")]
		public Rigidbody carRigidbody;

		[Token(Token = "0x4006939")]
		[FieldOffset(Offset = "0x40")]
		public GolfBallController ballController;

		[Token(Token = "0x400693A")]
		[FieldOffset(Offset = "0x48")]
		private bool firstAim;

		[Token(Token = "0x400693B")]
		[FieldOffset(Offset = "0x49")]
		private bool firstShot;

		[Token(Token = "0x400693C")]
		[FieldOffset(Offset = "0x4A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A630", Offset = "0x5A630")]
		private bool DisableSpatial__BackingField;

		[Token(Token = "0x17000A51")]
		public bool DisableSpatial
		{
			[Token(Token = "0x6005B6D")]
			[Address(RVA = "0x15F7920", Offset = "0x15F7920", VA = "0x15F7920", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72618", Offset = "0x72618")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005B6E")]
			[Address(RVA = "0x15F7928", Offset = "0x15F7928", VA = "0x15F7928", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72628", Offset = "0x72628")]
			set
			{
			}
		}

		[Token(Token = "0x6005B6F")]
		[Address(RVA = "0x15F7930", Offset = "0x15F7930", VA = "0x15F7930")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005B70")]
		[Address(RVA = "0x15F7A90", Offset = "0x15F7A90", VA = "0x15F7A90")]
		private void OnAim()
		{
		}

		[Token(Token = "0x6005B71")]
		[Address(RVA = "0x15F7C08", Offset = "0x15F7C08", VA = "0x15F7C08")]
		private void OnShoot(Vector3 v)
		{
		}

		[Token(Token = "0x6005B72")]
		[Address(RVA = "0x15F7CD0", Offset = "0x15F7CD0", VA = "0x15F7CD0")]
		private void PlayShootClipFromDirection(Vector3 shootDirection)
		{
		}

		[Token(Token = "0x6005B73")]
		[Address(RVA = "0x15F7D90", Offset = "0x15F7D90", VA = "0x15F7D90")]
		private void PlayGroupClip(ClipSettingsCollection c)
		{
		}

		[Token(Token = "0x6005B74")]
		[Address(RVA = "0x15F7AAC", Offset = "0x15F7AAC", VA = "0x15F7AAC")]
		private void PlayClipWithSettings(AudioClipSettings c)
		{
		}

		[Token(Token = "0x6005B75")]
		[Address(RVA = "0x15F7EEC", Offset = "0x15F7EEC", VA = "0x15F7EEC")]
		public PlayerCarAudioV2()
		{
		}
	}
}
