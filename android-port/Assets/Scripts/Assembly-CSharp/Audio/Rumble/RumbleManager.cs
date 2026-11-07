using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Rumble
{
	[Token(Token = "0x20013FF")]
	public class RumbleManager : MonoBehaviour
	{
		[Token(Token = "0x4006B55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RumbleEventAsset SubtleBump;

		[Token(Token = "0x4006B56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RumbleEventAsset BumpHard;

		[Token(Token = "0x4006B57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RumbleEventAsset OnShoot;

		[Token(Token = "0x4006B58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RumbleEventAsset Explosion;

		[Token(Token = "0x4006B59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RumbleEventAsset Confetti;

		[Token(Token = "0x4006B5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RumbleEventAsset HighFreqBump;

		[Token(Token = "0x4006B5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public RumbleEventAsset LongBuildupRumble;

		[Token(Token = "0x4006B5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PS5HapticsAudioPlayer PS5HapticsAudioSources;

		[Token(Token = "0x4006B5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip m_GenericSineWaveRumbleClip;

		[Token(Token = "0x6005D15")]
		[Address(RVA = "0x1661CB0", Offset = "0x1661CB0", VA = "0x1661CB0")]
		public void PlayVibrationValue(float amplitudeLow, float amplitudeHigh, int playerIndex, [Optional] AudioClip ps5HapticsAudioClip)
		{
		}

		[Token(Token = "0x6005D16")]
		[Address(RVA = "0x1661CB8", Offset = "0x1661CB8", VA = "0x1661CB8")]
		public void PlayVibrationValue(float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, int playerIndex, [Optional] AudioClip ps5HapticsAudioClip)
		{
		}

		[Token(Token = "0x6005D17")]
		[Address(RVA = "0x1661CC0", Offset = "0x1661CC0", VA = "0x1661CC0")]
		public void StopVibration(int playerIndex)
		{
		}

		[Token(Token = "0x6005D18")]
		[Address(RVA = "0x1661CC8", Offset = "0x1661CC8", VA = "0x1661CC8")]
		public void PlayVibrationFile(RumbleFileSetting rumbleSettings, int playerIndex, float volume)
		{
		}

		[Token(Token = "0x6005D19")]
		[Address(RVA = "0x1661CD0", Offset = "0x1661CD0", VA = "0x1661CD0")]
		public List<int> GetPlayerIndexesInRangeOfSpatial(Vector3 position, float range)
		{
			return null;
		}

		[Token(Token = "0x6005D1A")]
		[Address(RVA = "0x1661CCC", Offset = "0x1661CCC", VA = "0x1661CCC")]
		private void PlayVibrationFileInternal(RumbleFileSetting rumbleSettings, int playerIndex, float volume)
		{
		}

		[Token(Token = "0x6005D1B")]
		[Address(RVA = "0x1661CB4", Offset = "0x1661CB4", VA = "0x1661CB4")]
		private void PlayVibrationValueInternal(float amplitudeLow, float amplitudeHigh, int playerIndex, [Optional] AudioClip ps5AudioClip)
		{
		}

		[Token(Token = "0x6005D1C")]
		[Address(RVA = "0x1661CBC", Offset = "0x1661CBC", VA = "0x1661CBC")]
		private void PlayVibrationValueInternal(float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, int playerIndex, [Optional] AudioClip ps5AudioClip)
		{
		}

		[Token(Token = "0x6005D1D")]
		[Address(RVA = "0x1661CC4", Offset = "0x1661CC4", VA = "0x1661CC4")]
		private void StopVibrationInternal(int playerIndex)
		{
		}

		[Token(Token = "0x6005D1E")]
		[Address(RVA = "0x1662098", Offset = "0x1662098", VA = "0x1662098")]
		public RumbleManager()
		{
		}
	}
}
