using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000113")]
	public class MuscleCollisionBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000661")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000662")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public int muscleIndex;

		[Token(Token = "0x4000663")]
		private const string onMuscleHit = "OnMuscleHit";

		[Token(Token = "0x4000664")]
		private const string onMuscleCollision = "OnMuscleCollision";

		[Token(Token = "0x4000665")]
		private const string onMuscleCollisionExit = "OnMuscleCollisionExit";

		[Token(Token = "0x4000666")]
		[FieldOffset(Offset = "0x28")]
		private MuscleCollisionBroadcaster otherBroadcaster;

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x13B97C8", Offset = "0x13B97C8", VA = "0x13B97C8")]
		public void Hit(float unPin, Vector3 force, Vector3 position)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x13B98CC", Offset = "0x13B98CC", VA = "0x13B98CC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x13B9A80", Offset = "0x13B9A80", VA = "0x13B9A80")]
		private void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x13B9D18", Offset = "0x13B9D18", VA = "0x13B9D18")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x13B9F94", Offset = "0x13B9F94", VA = "0x13B9F94")]
		public MuscleCollisionBroadcaster()
		{
		}
	}
}
