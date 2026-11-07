using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Token(Token = "0x20000E9")]
	public class Hierarchy
	{
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x13822A8", Offset = "0x13822A8", VA = "0x13822A8")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default;
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1382484", Offset = "0x1382484", VA = "0x1382484")]
		public static Object ContainsDuplicate(Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1382328", Offset = "0x1382328", VA = "0x1382328")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default;
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x13825B8", Offset = "0x13825B8", VA = "0x13825B8")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default;
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x13826F0", Offset = "0x13826F0", VA = "0x13826F0")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x138293C", Offset = "0x138293C", VA = "0x138293C")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}
	}
}
