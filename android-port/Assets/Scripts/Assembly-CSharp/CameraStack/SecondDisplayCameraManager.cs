using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x2001119")]
	public class SecondDisplayCameraManager : MonoBehaviour
	{
		[Token(Token = "0x4005A80")]
		[FieldOffset(Offset = "0x18")]
		private Camera secondScreenCamera;

		[Token(Token = "0x17000826")]
		public Camera ActualCamera
		{
			[Token(Token = "0x6004CF6")]
			[Address(RVA = "0x1680DC8", Offset = "0x1680DC8", VA = "0x1680DC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004CF7")]
		[Address(RVA = "0x1680DD0", Offset = "0x1680DD0", VA = "0x1680DD0")]
		public void Configure(Camera camera, int screenIndex)
		{
		}

		[Token(Token = "0x6004CF8")]
		[Address(RVA = "0x1680EC8", Offset = "0x1680EC8", VA = "0x1680EC8")]
		private void OnDisplaysUpdated()
		{
		}

		[Token(Token = "0x6004CF9")]
		[Address(RVA = "0x1681268", Offset = "0x1681268", VA = "0x1681268")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6004CFA")]
		[Address(RVA = "0x1681320", Offset = "0x1681320", VA = "0x1681320")]
		public SecondDisplayCameraManager()
		{
		}
	}
}
