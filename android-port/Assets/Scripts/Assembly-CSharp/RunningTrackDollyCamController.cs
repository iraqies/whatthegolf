using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000254")]
public class RunningTrackDollyCamController : MonoBehaviour
{
	[Token(Token = "0x4000BEE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CinemachineVirtualCamera primaryPathCam;

	[Token(Token = "0x4000BEF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CinemachineVirtualCamera offPathCam;

	[Token(Token = "0x4000BF0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform followTarget;

	[Token(Token = "0x4000BF1")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private DollyPathTrigger runnerTrigger;

	[Token(Token = "0x4000BF2")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private CinemachineSmoothPath primaryPath;

	[Token(Token = "0x4000BF3")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Animator cameraStateAnimator;

	[Token(Token = "0x4000BF4")]
	[FieldOffset(Offset = "0x48")]
	private CinemachineSmoothPath currentPath;

	[Token(Token = "0x4000BF5")]
	[FieldOffset(Offset = "0x50")]
	private CinemachineTrackedDolly offPathCamDolly;

	[Token(Token = "0x4000BF6")]
	[FieldOffset(Offset = "0x58")]
	private float pathDistance;

	[Token(Token = "0x4000BF7")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 pathPosition;

	[Token(Token = "0x6000A79")]
	[Address(RVA = "0x16649C0", Offset = "0x16649C0", VA = "0x16649C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000A7A")]
	[Address(RVA = "0x1664B38", Offset = "0x1664B38", VA = "0x1664B38")]
	private void RunnerTrigger_OnDollyPathEnter(SecondaryDollyPath obj)
	{
	}

	[Token(Token = "0x6000A7B")]
	[Address(RVA = "0x1664BB8", Offset = "0x1664BB8", VA = "0x1664BB8")]
	private void RunnerTrigger_OnDollyPathExit(SecondaryDollyPath obj)
	{
	}

	[Token(Token = "0x6000A7C")]
	[Address(RVA = "0x1664C18", Offset = "0x1664C18", VA = "0x1664C18")]
	public RunningTrackDollyCamController()
	{
	}
}
