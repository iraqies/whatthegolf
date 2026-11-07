using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Impact
{
	[Token(Token = "0x2001405")]
	public class ImpactAsset : ScriptableObject
	{
		[Token(Token = "0x4006B78")]
		[FieldOffset(Offset = "0x18")]
		public List<VelocityClipGroup> velocityClipGroups;

		[Token(Token = "0x4006B79")]
		[FieldOffset(Offset = "0x20")]
		public List<ImpactConditionBase> conditions;

		[Token(Token = "0x4006B7A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool affectVolume;

		[Token(Token = "0x4006B7B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve volumeCurve;

		[Token(Token = "0x4006B7C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool affectPitch;

		[Token(Token = "0x4006B7D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationCurve pitchCurve;

		[Token(Token = "0x4006B7E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float minVelocity;

		[Token(Token = "0x4006B7F")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float maxVelocity;

		[Token(Token = "0x4006B80")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool includeBelowMin;

		[Token(Token = "0x4006B81")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool includeAboveMax;

		[Token(Token = "0x4006B82")]
		[FieldOffset(Offset = "0x52")]
		[SerializeField]
		private bool lockVelocityThresholds;

		[Token(Token = "0x4006B83")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "RangeAttribute", RVA = "0x5AD24", Offset = "0x5AD24")]
		[SerializeField]
		private float cooldown;

		[Token(Token = "0x4006B84")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AD64", Offset = "0x5AD64")]
		private float m_lastPlayTime__BackingField;

		[Token(Token = "0x4006B85")]
		[FieldOffset(Offset = "0x5C")]
		public SizeModifier CurrentIncomingObjectSize;

		[Token(Token = "0x17000A8D")]
		public float m_lastPlayTime
		{
			[Token(Token = "0x6005D31")]
			[Address(RVA = "0x14E6428", Offset = "0x14E6428", VA = "0x14E6428")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72940", Offset = "0x72940")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005D32")]
			[Address(RVA = "0x14E6430", Offset = "0x14E6430", VA = "0x14E6430")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72950", Offset = "0x72950")]
			private set
			{
			}
		}

		[Token(Token = "0x17000A8E")]
		public float[] SIZE_VOLUME_MULTIPLIER
		{
			[Token(Token = "0x6005D33")]
			[Address(RVA = "0x14E6438", Offset = "0x14E6438", VA = "0x14E6438")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A8F")]
		public float[] SIZE_PITCH_MULTIPLIER
		{
			[Token(Token = "0x6005D34")]
			[Address(RVA = "0x14E64B4", Offset = "0x14E64B4", VA = "0x14E64B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005D35")]
		[Address(RVA = "0x14E6530", Offset = "0x14E6530", VA = "0x14E6530")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005D36")]
		[Address(RVA = "0x14E653C", Offset = "0x14E653C", VA = "0x14E653C")]
		public void ResetOnSceneLoad()
		{
		}

		[Token(Token = "0x6005D37")]
		[Address(RVA = "0x14E6548", Offset = "0x14E6548", VA = "0x14E6548")]
		public bool OnCollision(HitInfo info, bool sizeAffects = false, ObjectWeight objectWeight = ObjectWeight.Medium, bool disableSpatial = false)
		{
			return default;
		}

		[Token(Token = "0x6005D38")]
		[Address(RVA = "0x14E689C", Offset = "0x14E689C", VA = "0x14E689C")]
		public float GetNormalizedVelocity(float velocity)
		{
			return default;
		}

		[Token(Token = "0x6005D39")]
		[Address(RVA = "0x14E6C18", Offset = "0x14E6C18", VA = "0x14E6C18")]
		public bool OnCollision(HitInfo info, ImpactUser user)
		{
			return default;
		}

		[Token(Token = "0x6005D3A")]
		[Address(RVA = "0x14E6938", Offset = "0x14E6938", VA = "0x14E6938")]
		public float GetPitchMod(float velocityNormalized, bool affectSize, ObjectWeight size, IgnoreCurve ignoreCurve)
		{
			return default;
		}

		[Token(Token = "0x6005D3B")]
		[Address(RVA = "0x14E6AA8", Offset = "0x14E6AA8", VA = "0x14E6AA8")]
		public float GetVolumeMod(float velocityNormalized, bool affectSize, ObjectWeight size, IgnoreCurve ignoreCurve)
		{
			return default;
		}

		[Token(Token = "0x6005D3C")]
		[Address(RVA = "0x14E6C64", Offset = "0x14E6C64", VA = "0x14E6C64")]
		public List<VelocityClipGroup> GetVelocityClipGroups(float velocityNormalized)
		{
			return null;
		}

		[Token(Token = "0x6005D3D")]
		[Address(RVA = "0x14E6DE8", Offset = "0x14E6DE8", VA = "0x14E6DE8")]
		private void OnTrigger(TriggerInfo obj)
		{
		}

		[Token(Token = "0x6005D3E")]
		[Address(RVA = "0x14E6DEC", Offset = "0x14E6DEC", VA = "0x14E6DEC")]
		public ImpactAsset()
		{
		}
	}
}
