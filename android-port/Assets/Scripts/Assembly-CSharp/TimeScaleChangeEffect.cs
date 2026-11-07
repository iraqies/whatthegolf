using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200053E")]
public class TimeScaleChangeEffect : MonoBehaviour
{
	[Token(Token = "0x4001B08")]
	[FieldOffset(Offset = "0x18")]
	public CanvasGroup CanvasGroup;

	[Token(Token = "0x4001B09")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 AlphaRange;

	[Token(Token = "0x4001B0A")]
	[FieldOffset(Offset = "0x28")]
	public float Scale;

	[Token(Token = "0x4001B0B")]
	[FieldOffset(Offset = "0x2C")]
	public float ChangeSpeed;

	[Token(Token = "0x4001B0C")]
	[FieldOffset(Offset = "0x30")]
	public List<Transform> Bars;

	[Token(Token = "0x4001B0D")]
	[FieldOffset(Offset = "0x38")]
	public float FovChange;

	[Token(Token = "0x4001B0E")]
	[FieldOffset(Offset = "0x3C")]
	public float OrthoSizeChange;

	[Token(Token = "0x4001B0F")]
	[FieldOffset(Offset = "0x40")]
	private float target;

	[Token(Token = "0x4001B10")]
	[FieldOffset(Offset = "0x48")]
	private CameraFilterPack_Color_Sepia sepia;

	[Token(Token = "0x4001B11")]
	[FieldOffset(Offset = "0x50")]
	private bool inLevel;

	[Token(Token = "0x60017F4")]
	[Address(RVA = "0x17162F4", Offset = "0x17162F4", VA = "0x17162F4")]
	private void Start()
	{
	}

	[Token(Token = "0x60017F5")]
	[Address(RVA = "0x1716424", Offset = "0x1716424", VA = "0x1716424")]
	private void InstanceOnOnLevelWillUnload()
	{
	}

	[Token(Token = "0x60017F6")]
	[Address(RVA = "0x1716430", Offset = "0x1716430", VA = "0x1716430")]
	public void ToggleEffect(bool state)
	{
	}

	[Token(Token = "0x60017F7")]
	[Address(RVA = "0x1716438", Offset = "0x1716438", VA = "0x1716438")]
	private void InstanceOnOnLevelLoaded(LevelData levelData)
	{
	}

	[Token(Token = "0x60017F8")]
	[Address(RVA = "0x1716548", Offset = "0x1716548", VA = "0x1716548")]
	private void Update()
	{
	}

	[Token(Token = "0x60017F9")]
	[Address(RVA = "0x1716A00", Offset = "0x1716A00", VA = "0x1716A00")]
	public TimeScaleChangeEffect()
	{
	}
}
