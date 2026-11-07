using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace StylizedWater
{
	[Token(Token = "0x20000D0")]
	[Attribute(Name = "RequireComponent", RVA = "0x337DC", Offset = "0x337DC")]
	[ExecuteInEditMode]
	public class StylizedWaterShadowCaster : MonoBehaviour
	{
		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x18")]
		private CommandBuffer cmd;

		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x20")]
		public Light dirLight;

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1401890", Offset = "0x1401890", VA = "0x1401890")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1401A60", Offset = "0x1401A60", VA = "0x1401A60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1401B00", Offset = "0x1401B00", VA = "0x1401B00")]
		public StylizedWaterShadowCaster()
		{
		}
	}
}
