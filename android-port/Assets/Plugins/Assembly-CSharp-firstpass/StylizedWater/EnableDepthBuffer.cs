using Il2CppDummyDll;
using UnityEngine;

namespace StylizedWater
{
	[Token(Token = "0x20000CB")]
	[ExecuteInEditMode]
	[Attribute(Name = "RequireComponent", RVA = "0x33674", Offset = "0x33674")]
	public class EnableDepthBuffer : MonoBehaviour
	{
		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x18")]
		private Camera cam;

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x136846C", Offset = "0x136846C", VA = "0x136846C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1368470", Offset = "0x1368470", VA = "0x1368470")]
		private void Set()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1368538", Offset = "0x1368538", VA = "0x1368538")]
		public EnableDepthBuffer()
		{
		}
	}
}
