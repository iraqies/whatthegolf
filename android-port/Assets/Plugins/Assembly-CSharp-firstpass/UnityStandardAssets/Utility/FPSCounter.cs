using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x200004F")]
	[Attribute(Name = "RequireComponent", RVA = "0x33204", Offset = "0x33204")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x400013C")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x4000140")]
		private const string display = "{0} FPS";

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x13708B8", Offset = "0x13708B8", VA = "0x13708B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1370928", Offset = "0x1370928", VA = "0x1370928")]
		private void Update()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1370A20", Offset = "0x1370A20", VA = "0x1370A20")]
		public FPSCounter()
		{
		}
	}
}
