using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000066")]
public class WorkingSwitchVideoPlayer : MonoBehaviour
{
	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform _outputPlane;

	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Renderer _outputRenderer;

	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent loopPointReached;

	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0x30")]
	private CameraPreRenderHook _preRenderHook;

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x175A858", Offset = "0x175A858", VA = "0x175A858")]
	private void CleanupCameraHook()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x175A910", Offset = "0x175A910", VA = "0x175A910")]
	public bool Play(string url, Camera camera, bool loop)
	{
		return default;
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x175AC58", Offset = "0x175AC58", VA = "0x175AC58")]
	public void Stop()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x175AC5C", Offset = "0x175AC5C", VA = "0x175AC5C")]
	private void OnCameraPreRender()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x175AC60", Offset = "0x175AC60", VA = "0x175AC60")]
	public WorkingSwitchVideoPlayer()
	{
	}
}
