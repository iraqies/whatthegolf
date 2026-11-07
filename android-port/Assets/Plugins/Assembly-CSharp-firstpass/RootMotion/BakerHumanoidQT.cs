using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Serializable]
	[Token(Token = "0x20000D9")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x4000478")]
		[FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x4000479")]
		[FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x400047A")]
		[FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x400047B")]
		[FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x400047F")]
		[FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x4000480")]
		[FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x12F5738", Offset = "0x12F5738", VA = "0x12F5738")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x12F59BC", Offset = "0x12F59BC", VA = "0x12F59BC")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x12F58B4", Offset = "0x12F58B4", VA = "0x12F58B4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x12F5B48", Offset = "0x12F5B48", VA = "0x12F5B48")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x12F5FF0", Offset = "0x12F5FF0", VA = "0x12F5FF0")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x12F60EC", Offset = "0x12F60EC", VA = "0x12F60EC")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x12F61E0", Offset = "0x12F61E0", VA = "0x12F61E0")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x12F6160", Offset = "0x12F6160", VA = "0x12F6160")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x12F6404", Offset = "0x12F6404", VA = "0x12F6404")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x12F64B8", Offset = "0x12F64B8", VA = "0x12F64B8")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
}
