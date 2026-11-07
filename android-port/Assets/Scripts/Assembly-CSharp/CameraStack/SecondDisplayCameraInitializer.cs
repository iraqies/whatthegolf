using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x2001118")]
	public class SecondDisplayCameraInitializer : MonoBehaviour
	{
		[Token(Token = "0x4005A7D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Camera originalCamera;

		[Token(Token = "0x4005A7E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform secondCamParent;

		[Token(Token = "0x4005A7F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool autoInitialize;

		[Token(Token = "0x6004CF2")]
		[Address(RVA = "0x1680BC0", Offset = "0x1680BC0", VA = "0x1680BC0")]
		private SecondDisplayCameraManager InitializeFromBehavior(Camera originalCamera, Transform secondCamParent, float forwardRotation)
		{
			return null;
		}

		[Token(Token = "0x6004CF3")]
		[Address(RVA = "0x1680BDC", Offset = "0x1680BDC", VA = "0x1680BDC")]
		public static SecondDisplayCameraManager Initialize(Camera originalCamera, Transform secondCamParent, Transform scriptRoot, float forwardRotation)
		{
			return null;
		}

		[Token(Token = "0x6004CF4")]
		[Address(RVA = "0x1680BE4", Offset = "0x1680BE4", VA = "0x1680BE4")]
		private static void CopyCameraValues(Camera from, Camera to)
		{
		}

		[Token(Token = "0x6004CF5")]
		[Address(RVA = "0x1680DC0", Offset = "0x1680DC0", VA = "0x1680DC0")]
		public SecondDisplayCameraInitializer()
		{
		}
	}
}
