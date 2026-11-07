using System.Collections.Generic;
using Audio.Conditions;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013BA")]
	public static class AudioUtility
	{
		[Token(Token = "0x20013BB")]
		public enum AudioManagerVoice
		{
			[Token(Token = "0x4006A2E")]
			ShortEffects = 0,
			[Token(Token = "0x4006A2F")]
			ImpactEffects = 1,
			[Token(Token = "0x4006A30")]
			UiEffects = 2,
			[Token(Token = "0x4006A31")]
			AmbientEffects = 3,
			[Token(Token = "0x4006A32")]
			OverworldSpatial = 4
		}

		[Token(Token = "0x4006A2C")]
		[FieldOffset(Offset = "0x0")]
		private static float twelfthRootOfTwo;

		[Token(Token = "0x6005C0D")]
		[Address(RVA = "0x150E3E8", Offset = "0x150E3E8", VA = "0x150E3E8")]
		public static float LinearToDecibel(float linear, float zeroVolume = -80f)
		{
			return default;
		}

		[Token(Token = "0x6005C0E")]
		[Address(RVA = "0x150E42C", Offset = "0x150E42C", VA = "0x150E42C")]
		public static float NormalizeMinMax(float value, float min, float max)
		{
			return default;
		}

		[Token(Token = "0x6005C0F")]
		[Address(RVA = "0x150E43C", Offset = "0x150E43C", VA = "0x150E43C")]
		public static float NormalizeMinMax(float value, MinMax minMax)
		{
			return default;
		}

		[Token(Token = "0x6005C10")]
		[Address(RVA = "0x150E460", Offset = "0x150E460", VA = "0x150E460")]
		public static float NormalizeMinMax01(float value, float min, float max)
		{
			return default;
		}

		[Token(Token = "0x6005C11")]
		[Address(RVA = "0x150E4E4", Offset = "0x150E4E4", VA = "0x150E4E4")]
		public static float NormalizeMinMax01(float value, MinMax minMax)
		{
			return default;
		}

		[Token(Token = "0x6005C12")]
		[Address(RVA = "0x150E570", Offset = "0x150E570", VA = "0x150E570")]
		public static bool CheckConditions(this List<SerializedAudioCondition> conditions)
		{
			return default;
		}

		[Token(Token = "0x6005C13")]
		[Address(RVA = "0x150E750", Offset = "0x150E750", VA = "0x150E750")]
		public static AudioSources GetVoice(AudioManagerVoice voice)
		{
			return null;
		}

		[Token(Token = "0x6005C14")]
		[Address(RVA = "0x150E8C0", Offset = "0x150E8C0", VA = "0x150E8C0")]
		public static HitInfo GetHitInfo(Collision collision)
		{
			return default;
		}

		[Token(Token = "0x6005C15")]
		[Address(RVA = "0x150EA94", Offset = "0x150EA94", VA = "0x150EA94")]
		public static HitInfo GetHitInfo(Collision2D collision)
		{
			return default;
		}

		[Token(Token = "0x6005C16")]
		[Address(RVA = "0x150ECE4", Offset = "0x150ECE4", VA = "0x150ECE4")]
		public static HitInfo GetHitInfo(RaycastHit raycastHit, Rigidbody hitter)
		{
			return default;
		}
	}
}
