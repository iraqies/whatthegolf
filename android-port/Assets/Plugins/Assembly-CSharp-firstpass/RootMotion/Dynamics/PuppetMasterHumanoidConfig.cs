using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000129")]
	public class PuppetMasterHumanoidConfig : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x200012A")]
		public class HumanoidMuscle
		{
			[Token(Token = "0x4000725")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000726")]
			[FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000727")]
			[FieldOffset(Offset = "0x20")]
			public Muscle.Props props;

			[Token(Token = "0x6000833")]
			[Address(RVA = "0x1353BEC", Offset = "0x1353BEC", VA = "0x1353BEC")]
			public HumanoidMuscle()
			{
			}
		}

		[Token(Token = "0x4000711")]
		[FieldOffset(Offset = "0x18")]
		public PuppetMaster.State state;

		[Token(Token = "0x4000712")]
		[FieldOffset(Offset = "0x1C")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x4000713")]
		[FieldOffset(Offset = "0x30")]
		public PuppetMaster.Mode mode;

		[Token(Token = "0x4000714")]
		[FieldOffset(Offset = "0x34")]
		public float blendTime;

		[Token(Token = "0x4000715")]
		[FieldOffset(Offset = "0x38")]
		public bool fixTargetTransforms;

		[Token(Token = "0x4000716")]
		[FieldOffset(Offset = "0x3C")]
		public int solverIterationCount;

		[Token(Token = "0x4000717")]
		[FieldOffset(Offset = "0x40")]
		public bool visualizeTargetPose;

		[Token(Token = "0x4000718")]
		[FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35980", Offset = "0x35980")]
		public float mappingWeight;

		[Token(Token = "0x4000719")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35998", Offset = "0x35998")]
		public float pinWeight;

		[Token(Token = "0x400071A")]
		[FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x359B0", Offset = "0x359B0")]
		public float muscleWeight;

		[Token(Token = "0x400071B")]
		[FieldOffset(Offset = "0x50")]
		public float muscleSpring;

		[Token(Token = "0x400071C")]
		[FieldOffset(Offset = "0x54")]
		public float muscleDamper;

		[Token(Token = "0x400071D")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x359C8", Offset = "0x359C8")]
		public float pinPow;

		[Token(Token = "0x400071E")]
		[FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x359E0", Offset = "0x359E0")]
		public float pinDistanceFalloff;

		[Token(Token = "0x400071F")]
		[FieldOffset(Offset = "0x60")]
		public bool angularPinning;

		[Token(Token = "0x4000720")]
		[FieldOffset(Offset = "0x61")]
		public bool updateJointAnchors;

		[Token(Token = "0x4000721")]
		[FieldOffset(Offset = "0x62")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x4000722")]
		[FieldOffset(Offset = "0x63")]
		public bool angularLimits;

		[Token(Token = "0x4000723")]
		[FieldOffset(Offset = "0x64")]
		public bool internalCollisions;

		[Token(Token = "0x4000724")]
		[FieldOffset(Offset = "0x68")]
		public HumanoidMuscle[] muscles;

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x13D3A88", Offset = "0x13D3A88", VA = "0x13D3A88")]
		public void ApplyTo(PuppetMaster p)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x13D3DC8", Offset = "0x13D3DC8", VA = "0x13D3DC8")]
		private Muscle GetMuscle(HumanBodyBones boneId, Animator animator, PuppetMaster puppetMaster)
		{
			return null;
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x13D3F00", Offset = "0x13D3F00", VA = "0x13D3F00")]
		public PuppetMasterHumanoidConfig()
		{
		}
	}
}
