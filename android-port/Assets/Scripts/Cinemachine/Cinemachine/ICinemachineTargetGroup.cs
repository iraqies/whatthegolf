using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000032")]
	public interface ICinemachineTargetGroup
	{
		[Token(Token = "0x1700003F")]
		BoundingSphere Sphere
		{
			[Token(Token = "0x6000128")]
			get;
		}

		[Token(Token = "0x6000129")]
		Bounds GetViewSpaceBoundingBox(Matrix4x4 observer);

		[Token(Token = "0x600012A")]
		void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange);
	}
}
