using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine.Utility
{
	[Token(Token = "0x2000099")]
	public static class UnityQuaternionExtensions
	{
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x190D188", Offset = "0x190D188", VA = "0x190D188")]
		public static Quaternion SlerpWithReferenceUp(Quaternion qA, Quaternion qB, float t, Vector3 up)
		{
			return default;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x190D460", Offset = "0x190D460", VA = "0x190D460")]
		public static Quaternion Normalized(this Quaternion q)
		{
			return default;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x190D4B4", Offset = "0x190D4B4", VA = "0x190D4B4")]
		public static Vector2 GetCameraRotationToTarget(this Quaternion orient, Vector3 lookAtDir, Vector3 worldUp)
		{
			return default;
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x190D91C", Offset = "0x190D91C", VA = "0x190D91C")]
		public static Quaternion ApplyCameraRotation(this Quaternion orient, Vector2 rot, Vector3 worldUp)
		{
			return default;
		}
	}
}
