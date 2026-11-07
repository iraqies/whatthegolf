using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x200019E")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200019F")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000B38")]
			[FieldOffset(Offset = "0x10")]
			public bool use;

			[Token(Token = "0x4000B39")]
			[FieldOffset(Offset = "0x14")]
			public Vector2 offset;

			[Token(Token = "0x4000B3A")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x367D4", Offset = "0x367D4")]
			public float angleOffset;

			[Token(Token = "0x4000B3B")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x367F4", Offset = "0x367F4")]
			public float maxAngle;

			[Token(Token = "0x4000B3C")]
			[FieldOffset(Offset = "0x24")]
			public float radius;

			[Token(Token = "0x4000B3D")]
			[FieldOffset(Offset = "0x28")]
			public bool orbit;

			[Token(Token = "0x4000B3E")]
			[FieldOffset(Offset = "0x29")]
			public bool fixYAxis;

			[Token(Token = "0x17000192")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000C53")]
				[Address(RVA = "0x134BF38", Offset = "0x134BF38", VA = "0x134BF38")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000193")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000C54")]
				[Address(RVA = "0x134BF44", Offset = "0x134BF44", VA = "0x134BF44")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000C55")]
			[Address(RVA = "0x134BFCC", Offset = "0x134BFCC", VA = "0x134BFCC")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default;
			}

			[Token(Token = "0x6000C56")]
			[Address(RVA = "0x134C484", Offset = "0x134C484", VA = "0x134C484")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001A0")]
		public class CameraPosition
		{
			[Token(Token = "0x4000B3F")]
			[FieldOffset(Offset = "0x10")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000B40")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 direction;

			[Token(Token = "0x4000B41")]
			[FieldOffset(Offset = "0x24")]
			public float maxDistance;

			[Token(Token = "0x4000B42")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36810", Offset = "0x36810")]
			public float maxAngle;

			[Token(Token = "0x4000B43")]
			[FieldOffset(Offset = "0x2C")]
			public bool fixYAxis;

			[Token(Token = "0x6000C57")]
			[Address(RVA = "0x134BBC4", Offset = "0x134BBC4", VA = "0x134BBC4")]
			public Quaternion GetRotation()
			{
				return default;
			}

			[Token(Token = "0x6000C58")]
			[Address(RVA = "0x134BCB8", Offset = "0x134BCB8", VA = "0x134BCB8")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default;
			}

			[Token(Token = "0x6000C59")]
			[Address(RVA = "0x134BEEC", Offset = "0x134BEEC", VA = "0x134BEEC")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001A1")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20001A2")]
			public class Interaction
			{
				[Token(Token = "0x4000B49")]
				[FieldOffset(Offset = "0x10")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000B4A")]
				[FieldOffset(Offset = "0x18")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000C5C")]
				[Address(RVA = "0x135AEC0", Offset = "0x135AEC0", VA = "0x135AEC0")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000B44")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000B45")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public bool show;

			[Token(Token = "0x4000B46")]
			[FieldOffset(Offset = "0x20")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000B47")]
			[FieldOffset(Offset = "0x28")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000B48")]
			[FieldOffset(Offset = "0x30")]
			public Interaction[] interactions;

			[Token(Token = "0x6000C5A")]
			[Address(RVA = "0x134C498", Offset = "0x134C498", VA = "0x134C498")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default;
			}

			[Token(Token = "0x6000C5B")]
			[Address(RVA = "0x134C534", Offset = "0x134C534", VA = "0x134C534")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000B37")]
		[FieldOffset(Offset = "0x18")]
		public Range[] ranges;

		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x13A6958", Offset = "0x13A6958", VA = "0x13A6958")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A82C", Offset = "0x3A82C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x13A69A0", Offset = "0x13A69A0", VA = "0x13A69A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A864", Offset = "0x3A864")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x13A69E8", Offset = "0x13A69E8", VA = "0x13A69E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A89C", Offset = "0x3A89C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x13A6A30", Offset = "0x13A6A30", VA = "0x13A6A30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A8D4", Offset = "0x3A8D4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x13A6A78", Offset = "0x13A6A78", VA = "0x13A6A78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A90C", Offset = "0x3A90C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x13A6AC0", Offset = "0x13A6AC0", VA = "0x13A6AC0")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default;
		}

		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x13A6C88", Offset = "0x13A6C88", VA = "0x13A6C88")]
		public InteractionTrigger()
		{
		}
	}
}
