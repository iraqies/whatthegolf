using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000217")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000DF7")]
		[FieldOffset(Offset = "0x18")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000DF8")]
		[FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000DF9")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x4000DFA")]
		[FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x6000E68")]
		[Address(RVA = "0x1324174", Offset = "0x1324174", VA = "0x1324174")]
		private void Start()
		{
		}

		[Token(Token = "0x6000E69")]
		[Address(RVA = "0x1324370", Offset = "0x1324370", VA = "0x1324370")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000E6A")]
		[Address(RVA = "0x1324560", Offset = "0x1324560", VA = "0x1324560")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0x132462C", Offset = "0x132462C", VA = "0x132462C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000E6C")]
		[Address(RVA = "0x1324748", Offset = "0x1324748", VA = "0x1324748")]
		public TwoHandedProp()
		{
		}
	}
}
