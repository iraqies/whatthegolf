using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Serializable]
	[Token(Token = "0x2000060")]
	public sealed class CinemachineBlenderSettings : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000061")]
		public struct CustomBlend
		{
			[Token(Token = "0x4000244")]
			[FieldOffset(Offset = "0x0")]
			public string m_From;

			[Token(Token = "0x4000245")]
			[FieldOffset(Offset = "0x8")]
			public string m_To;

			[Token(Token = "0x4000246")]
			[FieldOffset(Offset = "0x10")]
			public CinemachineBlendDefinition m_Blend;
		}

		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x18")]
		public CustomBlend[] m_CustomBlends;

		[Token(Token = "0x4000243")]
		public const string kBlendFromAnyCameraLabel = "**ANY CAMERA**";

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x18E39DC", Offset = "0x18E39DC", VA = "0x18E39DC")]
		public CinemachineBlendDefinition GetBlendForVirtualCameras(string fromCameraName, string toCameraName, CinemachineBlendDefinition defaultBlend)
		{
			return default;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x18E3C04", Offset = "0x18E3C04", VA = "0x18E3C04")]
		public CinemachineBlenderSettings()
		{
		}
	}
}
