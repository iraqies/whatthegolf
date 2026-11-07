using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Token(Token = "0x20000DF")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x40004D8")]
		[FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x130D8CC", Offset = "0x130D8CC", VA = "0x130D8CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x130D904", Offset = "0x130D904", VA = "0x130D904")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x130DAB4", Offset = "0x130DAB4", VA = "0x130DAB4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default;
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x130DAE4", Offset = "0x130DAE4", VA = "0x130DAE4")]
		public CameraControllerFPS()
		{
		}
	}
}
