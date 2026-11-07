using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000048")]
	public class MaskUtilities
	{
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x2C28B48", Offset = "0x2C28B48", VA = "0x2C28B48")]
		public static void Notify2DMaskStateChanged(Component mask)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x2C27A94", Offset = "0x2C27A94", VA = "0x2C27A94")]
		public static void NotifyStencilStateChanged(Component mask)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x2C28644", Offset = "0x2C28644", VA = "0x2C28644")]
		public static Transform FindRootSortOverrideCanvas(Transform start)
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x2C28810", Offset = "0x2C28810", VA = "0x2C28810")]
		public static int GetStencilDepth(Transform transform, Transform stopAfter)
		{
			return default;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x2C28DFC", Offset = "0x2C28DFC", VA = "0x2C28DFC")]
		public static bool IsDescendantOrSelf(Transform father, Transform child)
		{
			return default;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x2C28F88", Offset = "0x2C28F88", VA = "0x2C28F88")]
		public static RectMask2D GetRectMaskForClippable(IClippable clippable)
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x2C29410", Offset = "0x2C29410", VA = "0x2C29410")]
		public static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks)
		{
		}
	}
}
