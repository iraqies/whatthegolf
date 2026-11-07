using Il2CppDummyDll;

namespace Cinemachine
{
	[Token(Token = "0x2000046")]
	public class CinemachineHardLookAt : CinemachineComponentBase
	{
		[Token(Token = "0x1700005B")]
		public override bool IsValid
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x18F8290", Offset = "0x18F8290", VA = "0x18F8290", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005C")]
		public override CinemachineCore.Stage Stage
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x18F8328", Offset = "0x18F8328", VA = "0x18F8328", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x18F8330", Offset = "0x18F8330", VA = "0x18F8330", Slot = "7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x18F845C", Offset = "0x18F845C", VA = "0x18F845C")]
		public CinemachineHardLookAt()
		{
		}
	}
}
