using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013DB")]
	public class AudioValueTransform : BaseAudioValue
	{
		[Token(Token = "0x20013DC")]
		public enum TransformListenType
		{
			[Token(Token = "0x4006AC0")]
			LocalScaleX = 0,
			[Token(Token = "0x4006AC1")]
			LocalScaleY = 1,
			[Token(Token = "0x4006AC2")]
			LocalScaleZ = 2,
			[Token(Token = "0x4006AC3")]
			LocalScaleMagnitude = 3,
			[Token(Token = "0x4006AC4")]
			MovementDelta = 4,
			[Token(Token = "0x4006AC5")]
			MovementDeltaAverage = 5
		}

		[Token(Token = "0x4006ABA")]
		[FieldOffset(Offset = "0x38")]
		public Transform target;

		[Token(Token = "0x4006ABB")]
		[FieldOffset(Offset = "0x40")]
		public TransformListenType listenType;

		[Token(Token = "0x4006ABC")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 lastPosition;

		[Token(Token = "0x4006ABD")]
		[FieldOffset(Offset = "0x50")]
		private Queue<float> positionDeltas;

		[Token(Token = "0x4006ABE")]
		[FieldOffset(Offset = "0x58")]
		private int sampleSize;

		[Token(Token = "0x17000A7C")]
		protected override bool Use2D
		{
			[Token(Token = "0x6005CA1")]
			[Address(RVA = "0x151259C", Offset = "0x151259C", VA = "0x151259C", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005CA2")]
		[Address(RVA = "0x15125A4", Offset = "0x15125A4", VA = "0x15125A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6005CA3")]
		[Address(RVA = "0x1512644", Offset = "0x1512644", VA = "0x1512644", Slot = "4")]
		public override string ValueInputName()
		{
			return null;
		}

		[Token(Token = "0x6005CA4")]
		[Address(RVA = "0x151277C", Offset = "0x151277C", VA = "0x151277C", Slot = "7")]
		protected override void SetValue()
		{
		}

		[Token(Token = "0x6005CA5")]
		[Address(RVA = "0x15128D8", Offset = "0x15128D8", VA = "0x15128D8")]
		private void MovementDeltaAverage()
		{
		}

		[Token(Token = "0x6005CA6")]
		[Address(RVA = "0x1512A5C", Offset = "0x1512A5C", VA = "0x1512A5C")]
		public AudioValueTransform()
		{
		}
	}
}
