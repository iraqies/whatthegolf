using Il2CppDummyDll;
using UnityEngine;

namespace Triband.Splines
{
	[Token(Token = "0x2000019")]
	public class SplineMeshCollider : MonoBehaviour
	{
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshCollider meshCollider;

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2A08EA0", Offset = "0x2A08EA0", VA = "0x2A08EA0")]
		private void Reset()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2A08F78", Offset = "0x2A08F78", VA = "0x2A08F78")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2A07D94", Offset = "0x2A07D94", VA = "0x2A07D94")]
		public void UpdateCollider(Mesh mesh)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2A09084", Offset = "0x2A09084", VA = "0x2A09084")]
		public SplineMeshCollider()
		{
		}
	}
}
