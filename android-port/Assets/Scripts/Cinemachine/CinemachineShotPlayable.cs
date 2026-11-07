using Cinemachine;
using Il2CppDummyDll;
using UnityEngine.Playables;

[Token(Token = "0x2000007")]
internal sealed class CinemachineShotPlayable : PlayableBehaviour
{
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x10")]
	public CinemachineVirtualCameraBase VirtualCamera;

	[Token(Token = "0x17000001")]
	public bool IsValid
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x18F96AC", Offset = "0x18F96AC", VA = "0x18F96AC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x18FE1A0", Offset = "0x18FE1A0", VA = "0x18FE1A0")]
	public CinemachineShotPlayable()
	{
	}
}
