using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C64")]
public class ToggleSceneLighting : MonoBehaviour
{
	[Token(Token = "0x40043F3")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController Controller;

	[Token(Token = "0x40043F4")]
	[FieldOffset(Offset = "0x20")]
	public Camera MainCamera;

	[Token(Token = "0x40043F5")]
	[FieldOffset(Offset = "0x28")]
	public Color CameraOffColor;

	[Token(Token = "0x40043F6")]
	[FieldOffset(Offset = "0x38")]
	public Light DirectionalLight;

	[Token(Token = "0x40043F7")]
	[FieldOffset(Offset = "0x40")]
	public float LightOffIntensity;

	[Token(Token = "0x40043F8")]
	[FieldOffset(Offset = "0x48")]
	public List<AudioClip> ToggleClips;

	[Token(Token = "0x40043F9")]
	[FieldOffset(Offset = "0x50")]
	private float lightOnIntensity;

	[Token(Token = "0x40043FA")]
	[FieldOffset(Offset = "0x54")]
	private Color cameraOnColor;

	[Token(Token = "0x40043FB")]
	[FieldOffset(Offset = "0x64")]
	private bool lightState;

	[Token(Token = "0x6003AD8")]
	[Address(RVA = "0x171C8E4", Offset = "0x171C8E4", VA = "0x171C8E4")]
	private void Start()
	{
	}

	[Token(Token = "0x6003AD9")]
	[Address(RVA = "0x171C9C0", Offset = "0x171C9C0", VA = "0x171C9C0")]
	public void Toggle(bool lightOn)
	{
	}

	[Token(Token = "0x6003ADA")]
	[Address(RVA = "0x171CA58", Offset = "0x171CA58", VA = "0x171CA58")]
	public ToggleSceneLighting()
	{
	}

	[Token(Token = "0x6003ADB")]
	[Address(RVA = "0x171CA68", Offset = "0x171CA68", VA = "0x171CA68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B634", Offset = "0x6B634")]
	private void _003CStart_003Eb__9_0(Vector3 v)
	{
	}
}
