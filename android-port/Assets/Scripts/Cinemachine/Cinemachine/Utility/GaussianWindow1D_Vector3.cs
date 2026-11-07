using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine.Utility
{
	[Token(Token = "0x2000092")]
	internal class GaussianWindow1D_Vector3 : GaussianWindow1d<Vector3>
	{
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x190AC60", Offset = "0x190AC60", VA = "0x190AC60")]
		public GaussianWindow1D_Vector3(float sigma, int maxKernelRadius = 10)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x190ACD0", Offset = "0x190ACD0", VA = "0x190ACD0", Slot = "4")]
		protected override Vector3 Compute(int windowPos)
		{
			return default;
		}
	}
}
