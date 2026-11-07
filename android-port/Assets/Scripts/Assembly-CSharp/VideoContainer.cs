using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

[Token(Token = "0x2000065")]
public class VideoContainer : MonoBehaviour
{
	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _defaultVideoPlayerRoot;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private VideoPlayer _defaultVideoPlayer;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private WorkingSwitchVideoPlayer _switchVideoPlayer;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private UnityEvent _onEndReached;

	[Token(Token = "0x17000046")]
	public bool isPlaying
	{
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x174A980", Offset = "0x174A980", VA = "0x174A980")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x174A9A4", Offset = "0x174A9A4", VA = "0x174A9A4")]
	public void Play(string url, Camera camera, bool loop, [Optional] UnityAction onEndReached, [Optional] VideoClip videoClip)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x174ACA4", Offset = "0x174ACA4", VA = "0x174ACA4")]
	private void ErrorReceived(VideoPlayer source, string message)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x174AD88", Offset = "0x174AD88", VA = "0x174AD88")]
	private void LoopReached(VideoPlayer source)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x174ADA4", Offset = "0x174ADA4", VA = "0x174ADA4")]
	private void LoopReachedSwitch()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x174AD30", Offset = "0x174AD30", VA = "0x174AD30")]
	public void Stop()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x174ADC0", Offset = "0x174ADC0", VA = "0x174ADC0")]
	public VideoContainer()
	{
	}
}
