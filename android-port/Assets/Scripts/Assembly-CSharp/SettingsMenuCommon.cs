using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000925")]
public abstract class SettingsMenuCommon : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000926")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x42098", Offset = "0x42098")]
	private struct _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x40031EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SettingsMenuCommon _003C_003E4__this;

		[Token(Token = "0x40031F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SettingsMenu.Location location;
	}

	[Token(Token = "0x40031E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SettingsMenu.Location ValidLocations;

	[Token(Token = "0x40031E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool isHighlighted;

	[Token(Token = "0x40031EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject Parent;

	[Token(Token = "0x40031EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject highlightPanel;

	[Token(Token = "0x40031EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public SettingsMenu settingsMenu;

	[Token(Token = "0x40031ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F9B4", Offset = "0x4F9B4")]
	private bool IsEnabled__BackingField;

	[Token(Token = "0x40031EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	protected bool isInitialized;

	[Token(Token = "0x17000462")]
	public bool IsEnabled
	{
		[Token(Token = "0x6002A5E")]
		[Address(RVA = "0x169C0A0", Offset = "0x169C0A0", VA = "0x169C0A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x67820", Offset = "0x67820")]
		get
		{
			return default;
		}
		[Token(Token = "0x6002A5F")]
		[Address(RVA = "0x169C0A8", Offset = "0x169C0A8", VA = "0x169C0A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x67830", Offset = "0x67830")]
		set
		{
		}
	}

	[Token(Token = "0x6002A60")]
	[Address(RVA = "0x169B4E0", Offset = "0x169B4E0", VA = "0x169B4E0", Slot = "4")]
	public virtual void Init(SettingsMenu settings)
	{
	}

	[Token(Token = "0x6002A61")]
	[Address(RVA = "0x1698CF0", Offset = "0x1698CF0", VA = "0x1698CF0")]
	public void EnableByLocation(SettingsMenu.Location location)
	{
	}

	[Token(Token = "0x6002A62")]
	[Address(RVA = "0x169B408", Offset = "0x169B408", VA = "0x169B408")]
	protected void TryDestroy(bool active)
	{
	}

	[Token(Token = "0x6002A63")]
	[Address(RVA = "0x169BEDC", Offset = "0x169BEDC", VA = "0x169BEDC", Slot = "5")]
	public virtual void SetIsHighlighted(bool active)
	{
	}

	[Token(Token = "0x6002A64")]
	[Address(RVA = "0x169B6B4", Offset = "0x169B6B4", VA = "0x169B6B4", Slot = "6")]
	public virtual void HandleController()
	{
	}

	[Token(Token = "0x6002A65")]
	[Address(RVA = "0x169C08C", Offset = "0x169C08C", VA = "0x169C08C", Slot = "7")]
	public virtual void Refresh()
	{
	}

	[Token(Token = "0x6002A66")]
	[Address(RVA = "0x169C084", Offset = "0x169C084", VA = "0x169C084", Slot = "8")]
	public virtual void ResetValues()
	{
	}

	[Token(Token = "0x6002A67")]
	[Address(RVA = "0x169C13C", Offset = "0x169C13C", VA = "0x169C13C")]
	public float GetSiblingIndex()
	{
		return default;
	}

	[Token(Token = "0x6002A68")]
	[Address(RVA = "0x169B6C0", Offset = "0x169B6C0", VA = "0x169B6C0")]
	protected SettingsMenuCommon()
	{
	}

	[Token(Token = "0x6002A69")]
	[Address(RVA = "0x169C0B0", Offset = "0x169C0B0", VA = "0x169C0B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x67840", Offset = "0x67840")]
	private void _003CEnableByLocation_003Eg__Deactivate_007C11_0(GameObject g, ref _003C_003Ec__DisplayClass11_0 P_1)
	{
	}
}
