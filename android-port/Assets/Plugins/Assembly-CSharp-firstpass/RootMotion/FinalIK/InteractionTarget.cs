using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x200019C")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200019D")]
		public class Multiplier
		{
			[Token(Token = "0x4000B35")]
			[FieldOffset(Offset = "0x10")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000B36")]
			[FieldOffset(Offset = "0x14")]
			public float multiplier;

			[Token(Token = "0x6000C4B")]
			[Address(RVA = "0x134BBBC", Offset = "0x134BBBC", VA = "0x134BBBC")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000B2B")]
		[FieldOffset(Offset = "0x18")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000B2C")]
		[FieldOffset(Offset = "0x20")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000B2D")]
		[FieldOffset(Offset = "0x28")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000B2E")]
		[FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000B2F")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000B30")]
		[FieldOffset(Offset = "0x44")]
		public float twistWeight;

		[Token(Token = "0x4000B31")]
		[FieldOffset(Offset = "0x48")]
		public float swingWeight;

		[Token(Token = "0x4000B32")]
		[FieldOffset(Offset = "0x4C")]
		public bool rotateOnce;

		[Token(Token = "0x4000B33")]
		[FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000B34")]
		[FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x13A61C8", Offset = "0x13A61C8", VA = "0x13A61C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A66C", Offset = "0x3A66C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x13A6210", Offset = "0x13A6210", VA = "0x13A6210")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A6A4", Offset = "0x3A6A4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x13A6258", Offset = "0x13A6258", VA = "0x13A6258")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A6DC", Offset = "0x3A6DC")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x13A62A0", Offset = "0x13A62A0", VA = "0x13A62A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A714", Offset = "0x3A714")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x13A62E8", Offset = "0x13A62E8", VA = "0x13A62E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A74C", Offset = "0x3A74C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x13A6330", Offset = "0x13A6330", VA = "0x13A6330")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A784", Offset = "0x3A784")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x13A6378", Offset = "0x13A6378", VA = "0x13A6378")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A7BC", Offset = "0x3A7BC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x13A63C0", Offset = "0x13A63C0", VA = "0x13A63C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A7F4", Offset = "0x3A7F4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x13A6408", Offset = "0x13A6408", VA = "0x13A6408")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default;
		}

		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x13A6480", Offset = "0x13A6480", VA = "0x13A6480")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x13A652C", Offset = "0x13A652C", VA = "0x13A652C")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x13A6910", Offset = "0x13A6910", VA = "0x13A6910")]
		public InteractionTarget()
		{
		}
	}
}
