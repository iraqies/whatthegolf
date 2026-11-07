using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001D9")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000C72")]
		[FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x4000C73")]
		[FieldOffset(Offset = "0x1C")]
		public float offset;

		[Token(Token = "0x4000C74")]
		[FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000C75")]
		[FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000D79")]
		[Address(RVA = "0x13F996C", Offset = "0x13F996C", VA = "0x13F996C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000D7A")]
		[Address(RVA = "0x13F9A5C", Offset = "0x13F9A5C", VA = "0x13F9A5C")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000D7B")]
		[Address(RVA = "0x13F9B5C", Offset = "0x13F9B5C", VA = "0x13F9B5C")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000D7C")]
		[Address(RVA = "0x13F9EEC", Offset = "0x13F9EEC", VA = "0x13F9EEC")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000D7D")]
		[Address(RVA = "0x13F9F24", Offset = "0x13F9F24", VA = "0x13F9F24")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000D7E")]
		[Address(RVA = "0x13FA040", Offset = "0x13FA040", VA = "0x13FA040")]
		public ShoulderRotator()
		{
		}
	}
}
