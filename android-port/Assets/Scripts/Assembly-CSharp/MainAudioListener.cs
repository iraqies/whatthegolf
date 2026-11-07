using CameraStack;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004F1")]
public class MainAudioListener : MonoBehaviour
{
	[Token(Token = "0x40019B3")]
	[FieldOffset(Offset = "0x0")]
	private static MainAudioListener instance;

	[Token(Token = "0x40019B4")]
	[FieldOffset(Offset = "0x18")]
	private OverworldBallFollower owFollower;

	[Token(Token = "0x40019B5")]
	[FieldOffset(Offset = "0x20")]
	private Transform cameraTransform;

	[Token(Token = "0x40019B6")]
	[FieldOffset(Offset = "0x28")]
	private Transform followTransform;

	[Token(Token = "0x40019B7")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 offset;

	[Token(Token = "0x40019B8")]
	[FieldOffset(Offset = "0x40")]
	private ICameraBehaviourFollowing follower;

	[Token(Token = "0x40019B9")]
	[FieldOffset(Offset = "0x48")]
	private bool inOverworld;

	[Token(Token = "0x17000280")]
	public static MainAudioListener Instance
	{
		[Token(Token = "0x60016BC")]
		[Address(RVA = "0x1553DD8", Offset = "0x1553DD8", VA = "0x1553DD8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60016BD")]
	[Address(RVA = "0x1553E28", Offset = "0x1553E28", VA = "0x1553E28")]
	public static void CreateInstanceIfNeeded()
	{
	}

	[Token(Token = "0x60016BE")]
	[Address(RVA = "0x1554034", Offset = "0x1554034", VA = "0x1554034")]
	public void SubscribeToOverworld(OverworldManager2d owManager)
	{
	}

	[Token(Token = "0x60016BF")]
	[Address(RVA = "0x15540F4", Offset = "0x15540F4", VA = "0x15540F4")]
	private void OwManager_OnToggleOverworld(bool status)
	{
	}

	[Token(Token = "0x60016C0")]
	[Address(RVA = "0x15542CC", Offset = "0x15542CC", VA = "0x15542CC")]
	public void OnCameraBehaviourChanged(CameraBehavior cb)
	{
	}

	[Token(Token = "0x60016C1")]
	[Address(RVA = "0x1554AE4", Offset = "0x1554AE4", VA = "0x1554AE4")]
	public void SetFollowTarget(Transform target)
	{
	}

	[Token(Token = "0x60016C2")]
	[Address(RVA = "0x1554AEC", Offset = "0x1554AEC", VA = "0x1554AEC")]
	public void SetCameraTransform(Transform target)
	{
	}

	[Token(Token = "0x60016C3")]
	[Address(RVA = "0x15549A4", Offset = "0x15549A4", VA = "0x15549A4")]
	public void SetListenerDistanceFromCamera(bool isFollow)
	{
	}

	[Token(Token = "0x60016C4")]
	[Address(RVA = "0x1554848", Offset = "0x1554848", VA = "0x1554848")]
	private GameObject CreateDummyListenerTransform(Transform cameraTransform)
	{
		return null;
	}

	[Token(Token = "0x60016C5")]
	[Address(RVA = "0x1554AF4", Offset = "0x1554AF4", VA = "0x1554AF4")]
	private bool IsFakeForward(Transform cameraTrans)
	{
		return default;
	}

	[Token(Token = "0x60016C6")]
	[Address(RVA = "0x1554104", Offset = "0x1554104", VA = "0x1554104")]
	private void SetOverworldListener()
	{
	}

	[Token(Token = "0x60016C7")]
	[Address(RVA = "0x1554B64", Offset = "0x1554B64", VA = "0x1554B64")]
	private void Update()
	{
	}

	[Token(Token = "0x60016C8")]
	[Address(RVA = "0x1554E64", Offset = "0x1554E64", VA = "0x1554E64")]
	public MainAudioListener()
	{
	}

	[Token(Token = "0x60016C9")]
	[Address(RVA = "0x1554E98", Offset = "0x1554E98", VA = "0x1554E98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x628E8", Offset = "0x628E8")]
	private void _003COnCameraBehaviourChanged_003Eb__12_0(ICinemachineCamera v1, ICinemachineCamera v2)
	{
	}
}
