using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000ECC")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x453C8", Offset = "0x453C8")]
public class AnimateRectTransformPlatformSettings : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000ECD")]
	public class PlatformCameraSettings
	{
		[Token(Token = "0x4004FFE")]
		[FieldOffset(Offset = "0x10")]
		public AvailablePlatformsEnum Platform;

		[Token(Token = "0x4004FFF")]
		[FieldOffset(Offset = "0x18")]
		public AnimateRectTransform animateRectTransform;

		[Token(Token = "0x600451D")]
		[Address(RVA = "0x176C418", Offset = "0x176C418", VA = "0x176C418")]
		public PlatformCameraSettings()
		{
		}
	}

	[Token(Token = "0x2000ECE")]
	public enum AvailablePlatformsEnum
	{
		[Token(Token = "0x4005001")]
		Mobile = 0,
		[Token(Token = "0x4005002")]
		NonMobile = 1
	}

	[Serializable]
	[Token(Token = "0x2000ECF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45430", Offset = "0x45430")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4005003")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4005004")]
		[FieldOffset(Offset = "0x8")]
		public static Func<PlatformCameraSettings, AnimateRectTransform> _003C_003E9__5_1;

		[Token(Token = "0x600451F")]
		[Address(RVA = "0x176C3F8", Offset = "0x176C3F8", VA = "0x176C3F8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6004520")]
		[Address(RVA = "0x176C400", Offset = "0x176C400", VA = "0x176C400")]
		internal AnimateRectTransform _003Cget_UIAnimater_003Eb__5_1(PlatformCameraSettings s)
		{
			return null;
		}
	}

	[Token(Token = "0x4004FFD")]
	[FieldOffset(Offset = "0x18")]
	public List<PlatformCameraSettings> Settings;

	[Token(Token = "0x17000724")]
	public AnimateRectTransform UIAnimater
	{
		[Token(Token = "0x600451A")]
		[Address(RVA = "0x1417A98", Offset = "0x1417A98", VA = "0x1417A98")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004519")]
	[Address(RVA = "0x1417A34", Offset = "0x1417A34", VA = "0x1417A34")]
	private AvailablePlatformsEnum GetPlatform()
	{
		return default;
	}

	[Token(Token = "0x600451B")]
	[Address(RVA = "0x1417CD0", Offset = "0x1417CD0", VA = "0x1417CD0")]
	public AnimateRectTransformPlatformSettings()
	{
	}

	[Token(Token = "0x600451C")]
	[Address(RVA = "0x1417CD8", Offset = "0x1417CD8", VA = "0x1417CD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E454", Offset = "0x6E454")]
	private bool _003Cget_UIAnimater_003Eb__5_0(PlatformCameraSettings s)
	{
		return default;
	}
}
