using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001336")]
	public class IceSlideAudioNew : MonoBehaviour
	{
		[Token(Token = "0x40066BF")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip[] loopClips;

		[Token(Token = "0x40066C0")]
		[FieldOffset(Offset = "0x20")]
		public AudioSource audioSourcePrefab;

		[Token(Token = "0x40066C1")]
		[FieldOffset(Offset = "0x28")]
		public int maxSources;

		[Token(Token = "0x40066C2")]
		[FieldOffset(Offset = "0x30")]
		public List<string> debugStrings;

		[Token(Token = "0x40066C3")]
		[FieldOffset(Offset = "0x38")]
		private AudioSource[] audioSources;

		[Token(Token = "0x40066C4")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<Rigidbody, RigidbodyHierarchyInfo> OnIceDict;

		[Token(Token = "0x40066C5")]
		[FieldOffset(Offset = "0x48")]
		private List<RigidbodyHierarchyInfo> m_sortedInfos;

		[Token(Token = "0x600599A")]
		[Address(RVA = "0x14E3A44", Offset = "0x14E3A44", VA = "0x14E3A44")]
		private void Awake()
		{
		}

		[Token(Token = "0x600599B")]
		[Address(RVA = "0x14E3CE8", Offset = "0x14E3CE8", VA = "0x14E3CE8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600599C")]
		[Address(RVA = "0x14E3FDC", Offset = "0x14E3FDC", VA = "0x14E3FDC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600599D")]
		[Address(RVA = "0x14E42D0", Offset = "0x14E42D0", VA = "0x14E42D0")]
		private void DoSort()
		{
		}

		[Token(Token = "0x600599E")]
		[Address(RVA = "0x14E4404", Offset = "0x14E4404", VA = "0x14E4404")]
		private static int CompareByVelocity(RigidbodyHierarchyInfo x, RigidbodyHierarchyInfo y)
		{
			return default;
		}

		[Token(Token = "0x600599F")]
		[Address(RVA = "0x14E4490", Offset = "0x14E4490", VA = "0x14E4490")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60059A0")]
		[Address(RVA = "0x14E4140", Offset = "0x14E4140", VA = "0x14E4140")]
		private static Rigidbody GetParentRigidbody(Rigidbody rigid)
		{
			return null;
		}

		[Token(Token = "0x60059A1")]
		[Address(RVA = "0x14E45E4", Offset = "0x14E45E4", VA = "0x14E45E4")]
		public IceSlideAudioNew()
		{
		}
	}
}
