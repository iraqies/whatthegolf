using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000245")]
	public class RaycastShooter : MonoBehaviour
	{
		[Token(Token = "0x4000EC7")]
		[FieldOffset(Offset = "0x18")]
		public LayerMask layers;

		[Token(Token = "0x4000EC8")]
		[FieldOffset(Offset = "0x1C")]
		public float unpin;

		[Token(Token = "0x4000EC9")]
		[FieldOffset(Offset = "0x20")]
		public float force;

		[Token(Token = "0x4000ECA")]
		[FieldOffset(Offset = "0x28")]
		public ParticleSystem blood;

		[Token(Token = "0x6000F1D")]
		[Address(RVA = "0x13D9030", Offset = "0x13D9030", VA = "0x13D9030")]
		private void Update()
		{
		}

		[Token(Token = "0x6000F1E")]
		[Address(RVA = "0x13D9274", Offset = "0x13D9274", VA = "0x13D9274")]
		public RaycastShooter()
		{
		}
	}
}
