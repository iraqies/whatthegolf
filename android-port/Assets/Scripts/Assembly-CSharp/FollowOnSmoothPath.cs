using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000268")]
public class FollowOnSmoothPath : MonoBehaviour
{
	[Token(Token = "0x4000C74")]
	[FieldOffset(Offset = "0x18")]
	public CinemachineSmoothPath path;

	[Token(Token = "0x4000C75")]
	[FieldOffset(Offset = "0x20")]
	public Transform followTarget;

	[Token(Token = "0x4000C76")]
	[FieldOffset(Offset = "0x28")]
	public float maxRangeFromPath;

	[Token(Token = "0x6000AD7")]
	[Address(RVA = "0x146F7F8", Offset = "0x146F7F8", VA = "0x146F7F8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000AD8")]
	[Address(RVA = "0x146F9C4", Offset = "0x146F9C4", VA = "0x146F9C4")]
	public FollowOnSmoothPath()
	{
	}
}
