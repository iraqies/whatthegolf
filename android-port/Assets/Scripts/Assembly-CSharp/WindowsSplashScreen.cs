using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

[Token(Token = "0x200058F")]
public class WindowsSplashScreen : MonoBehaviour
{
	[Token(Token = "0x4001C68")]
	[FieldOffset(Offset = "0x18")]
	public List<string> changeToTallScenes;

	[Token(Token = "0x4001C69")]
	[FieldOffset(Offset = "0x20")]
	public List<string> changeToWideScenes;

	[Token(Token = "0x4001C6A")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 tallResolution;

	[Token(Token = "0x4001C6B")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 wideResolution;

	[Token(Token = "0x6001952")]
	[Address(RVA = "0x17591DC", Offset = "0x17591DC", VA = "0x17591DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6001953")]
	[Address(RVA = "0x175934C", Offset = "0x175934C", VA = "0x175934C")]
	private void OnSceneLoaded(Scene prevScene, Scene nextScene)
	{
	}

	[Token(Token = "0x6001954")]
	[Address(RVA = "0x1759440", Offset = "0x1759440", VA = "0x1759440")]
	public WindowsSplashScreen()
	{
	}
}
