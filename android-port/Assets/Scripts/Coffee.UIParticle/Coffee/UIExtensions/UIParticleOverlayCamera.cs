using Il2CppDummyDll;
using UnityEngine;

namespace Coffee.UIExtensions
{
	[Token(Token = "0x2000006")]
	[ExecuteInEditMode]
	public class UIParticleOverlayCamera : MonoBehaviour
	{
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x18")]
		private Camera m_Camera;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x0")]
		private static UIParticleOverlayCamera s_Instance;

		[Token(Token = "0x1700000A")]
		public static UIParticleOverlayCamera instance
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x19147E4", Offset = "0x19147E4", VA = "0x19147E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		private Camera cameraForOvrelay
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x1914A10", Offset = "0x1914A10", VA = "0x1914A10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1914168", Offset = "0x1914168", VA = "0x1914168")]
		public static Camera GetCameraForOvrelay(Canvas canvas)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1914B20", Offset = "0x1914B20", VA = "0x1914B20")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1914DE4", Offset = "0x1914DE4", VA = "0x1914DE4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1914E90", Offset = "0x1914E90", VA = "0x1914E90")]
		public UIParticleOverlayCamera()
		{
		}
	}
}
