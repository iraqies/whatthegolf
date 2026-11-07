using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001338")]
	public class IceSlideSimple : MonoBehaviour
	{
		[Token(Token = "0x40066C9")]
		[FieldOffset(Offset = "0x18")]
		public AudioSource audioSourcePrefab;

		[Token(Token = "0x40066CA")]
		[FieldOffset(Offset = "0x20")]
		public AudioClip[] loopClips;

		[Token(Token = "0x40066CB")]
		[FieldOffset(Offset = "0x28")]
		public List<AudioMaterial> slideForMaterial;

		[Token(Token = "0x40066CC")]
		[FieldOffset(Offset = "0x30")]
		public int maxSources;

		[Token(Token = "0x40066CD")]
		[FieldOffset(Offset = "0x38")]
		public List<string> debugVelocity;

		[Token(Token = "0x40066CE")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 top;

		[Token(Token = "0x40066CF")]
		[FieldOffset(Offset = "0x50")]
		private AudioSource[] audioSources;

		[Token(Token = "0x40066D0")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<Rigidbody, AudioMaterialSettings> onIceDict;

		[Token(Token = "0x40066D1")]
		[FieldOffset(Offset = "0x60")]
		private List<Rigidbody> m_sortedRigids;

		[Token(Token = "0x60059A3")]
		[Address(RVA = "0x14E45F4", Offset = "0x14E45F4", VA = "0x14E45F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60059A4")]
		[Address(RVA = "0x14E494C", Offset = "0x14E494C", VA = "0x14E494C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60059A5")]
		[Address(RVA = "0x14E4C0C", Offset = "0x14E4C0C", VA = "0x14E4C0C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60059A6")]
		[Address(RVA = "0x14E4FCC", Offset = "0x14E4FCC", VA = "0x14E4FCC")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60059A7")]
		[Address(RVA = "0x14E4E3C", Offset = "0x14E4E3C", VA = "0x14E4E3C")]
		private void DoSort()
		{
		}

		[Token(Token = "0x60059A8")]
		[Address(RVA = "0x14E5128", Offset = "0x14E5128", VA = "0x14E5128")]
		private static int CompareByVelocity(Rigidbody x, Rigidbody y)
		{
			return default;
		}

		[Token(Token = "0x60059A9")]
		[Address(RVA = "0x14E51B4", Offset = "0x14E51B4", VA = "0x14E51B4")]
		public IceSlideSimple()
		{
		}
	}
}
