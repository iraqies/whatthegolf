using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000040")]
	public class ShowNativePropertyTest : MonoBehaviour
	{
		[Token(Token = "0x17000001")]
		private Transform Transform
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x22ABCEC", Offset = "0x22ABCEC", VA = "0x22ABCEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private Transform ParentTransform
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x22ABCF4", Offset = "0x22ABCF4", VA = "0x22ABCF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x22ABD18", Offset = "0x22ABD18", VA = "0x22ABD18")]
		public ShowNativePropertyTest()
		{
		}
	}
}
