using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009F6")]
public class OverworldCameraSettings : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20009F7")]
	public class CameraData
	{
		[Token(Token = "0x40036E6")]
		[FieldOffset(Offset = "0x10")]
		public float orthographicSize;

		[Token(Token = "0x40036E7")]
		[FieldOffset(Offset = "0x14")]
		public float sideTrackPadding;

		[Token(Token = "0x40036E8")]
		[FieldOffset(Offset = "0x18")]
		public float upperTrackPadding;

		[Token(Token = "0x40036E9")]
		[FieldOffset(Offset = "0x1C")]
		public float lowerTrackPadding;

		[Token(Token = "0x40036EA")]
		[FieldOffset(Offset = "0x20")]
		public bool lockVerticalAxis;

		[Token(Token = "0x40036EB")]
		[FieldOffset(Offset = "0x21")]
		public bool lockHorizontalAxis;

		[Token(Token = "0x40036EC")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 offset;

		[Token(Token = "0x40036ED")]
		[FieldOffset(Offset = "0x2C")]
		public float tweenTime;

		[Token(Token = "0x40036EE")]
		[FieldOffset(Offset = "0x30")]
		public float tweenTimtweenTime;

		[Token(Token = "0x40036EF")]
		[FieldOffset(Offset = "0x34")]
		public float lookAhead;

		[Token(Token = "0x6002F37")]
		[Address(RVA = "0x180EF5C", Offset = "0x180EF5C", VA = "0x180EF5C")]
		public CameraData()
		{
		}
	}

	[Token(Token = "0x40036E3")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50114", Offset = "0x50114")]
	private Action<OverworldCameraSettings, float> m_OnSettingsUpdated;

	[Token(Token = "0x40036E4")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x50124", Offset = "0x50124")]
	public CameraData IOSData;

	[Token(Token = "0x40036E5")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5015C", Offset = "0x5015C")]
	public CameraData PCTVData;

	[Token(Token = "0x1400005B")]
	public event Action<OverworldCameraSettings, float> OnSettingsUpdated
	{
		[Token(Token = "0x6002F33")]
		[Address(RVA = "0x15AF0D4", Offset = "0x15AF0D4", VA = "0x15AF0D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D58", Offset = "0x68D58")]
		add
		{
		}
		[Token(Token = "0x6002F34")]
		[Address(RVA = "0x15B02D8", Offset = "0x15B02D8", VA = "0x15B02D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D68", Offset = "0x68D68")]
		remove
		{
		}
	}

	[Token(Token = "0x6002F35")]
	[Address(RVA = "0x15AE5EC", Offset = "0x15AE5EC", VA = "0x15AE5EC")]
	public void SetValue(float pct)
	{
	}

	[Token(Token = "0x6002F36")]
	[Address(RVA = "0x15B037C", Offset = "0x15B037C", VA = "0x15B037C")]
	public OverworldCameraSettings()
	{
	}
}
