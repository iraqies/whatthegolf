using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace StylizedWater
{
	[Token(Token = "0x20000CD")]
	[ExecuteInEditMode]
	[Attribute(Name = "RequireComponent", RVA = "0x33764", Offset = "0x33764")]
	public class StylizedWaterBlur : MonoBehaviour
	{
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x18")]
		public Camera cam;

		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x20")]
		public float length;

		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x24")]
		public int passes;

		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x0")]
		private static Shader m_BlurRenderShader;

		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x8")]
		private static Material m_BlurRenderMat;

		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x28")]
		private CommandBuffer cmd;

		[Token(Token = "0x170000C9")]
		private static Shader BlurRenderShader
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x1400C00", Offset = "0x1400C00", VA = "0x1400C00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CA")]
		private static Material BlurRenderMat
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x1400CD8", Offset = "0x1400CD8", VA = "0x1400CD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1400DD8", Offset = "0x1400DD8", VA = "0x1400DD8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1400E80", Offset = "0x1400E80", VA = "0x1400E80")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1400288", Offset = "0x1400288", VA = "0x1400288")]
		public void Render()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1400F34", Offset = "0x1400F34", VA = "0x1400F34")]
		public StylizedWaterBlur()
		{
		}
	}
}
