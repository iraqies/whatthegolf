using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x200000D")]
	public struct RenderCamera
	{
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x0")]
		public Camera Camera;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x8")]
		public Plane[] FrustumPlanes;
	}
}
