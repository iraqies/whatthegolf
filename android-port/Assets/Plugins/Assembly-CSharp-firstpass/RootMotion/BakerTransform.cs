using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Serializable]
	[Token(Token = "0x20000DB")]
	public class BakerTransform
	{
		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x12F7700", Offset = "0x12F7700", VA = "0x12F7700")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x12F7884", Offset = "0x12F7884", VA = "0x12F7884")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x12F7898", Offset = "0x12F7898", VA = "0x12F7898")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x12F7B80", Offset = "0x12F7B80", VA = "0x12F7B80")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x12F7790", Offset = "0x12F7790", VA = "0x12F7790")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x12F7E38", Offset = "0x12F7E38", VA = "0x12F7E38")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x12F7FF8", Offset = "0x12F7FF8", VA = "0x12F7FF8")]
		public void AddLoopFrame(float time)
		{
		}
	}
}
