using Il2CppDummyDll;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	[Token(Token = "0x20000A8")]
	public static class RopeInternalUtils
	{
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x13EDD54", Offset = "0x13EDD54", VA = "0x13EDD54")]
		public static Camera GetCameraThatDrawLayer(int p_layer)
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x13EFDC0", Offset = "0x13EFDC0", VA = "0x13EFDC0")]
		public static void TryClearRigidBody2D(Rigidbody2D p_body)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x13EFEA0", Offset = "0x13EFEA0", VA = "0x13EFEA0")]
		public static float GetObjectMass(GameObject p_object, bool p_includeChildrens = true, bool p_multiplyByGravityScale = true)
		{
			return default;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x13EF2E0", Offset = "0x13EF2E0", VA = "0x13EF2E0")]
		public static bool FindLineIntersection(Vector2 p_line1_p1, Vector2 p_line1_p2, Vector2 p_line2_p1, Vector2 p_line2_p2, ref Vector2 p_intersection)
		{
			return default;
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x13F01EC", Offset = "0x13F01EC", VA = "0x13F01EC")]
		public static Vector3 GetVectorDirection(Vector3 from, Vector3 to)
		{
			return default;
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x13F0228", Offset = "0x13F0228", VA = "0x13F0228")]
		public static Vector3 RotateZ(Vector3 p, float angle)
		{
			return default;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x13F0280", Offset = "0x13F0280", VA = "0x13F0280")]
		public static bool IsPrefab(GameObject p_object)
		{
			return default;
		}

		[Token(Token = "0x60003D1")]
		public static T CopyComponent<T>(GameObject p_destination, T p_original, bool p_pasteAsValue = true, bool p_deleteOldOne = false) where T : Component
		{
			return null;
		}
	}
}
