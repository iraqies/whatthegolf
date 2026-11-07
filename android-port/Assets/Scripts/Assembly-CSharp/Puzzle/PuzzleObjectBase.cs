using Il2CppDummyDll;
using UnityEngine;

namespace Puzzle
{
	[Token(Token = "0x2001050")]
	public abstract class PuzzleObjectBase : GolfBehaviour
	{
		[Token(Token = "0x40055F6")]
		[FieldOffset(Offset = "0x19")]
		public bool isBallInArea;

		[Token(Token = "0x40055F7")]
		[FieldOffset(Offset = "0x1A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x555D0", Offset = "0x555D0")]
		private bool Active__BackingField;

		[Token(Token = "0x40055F8")]
		[FieldOffset(Offset = "0x1B")]
		public bool alwaysReverseStatusOnTrigger;

		[Token(Token = "0x40055F9")]
		[FieldOffset(Offset = "0x1C")]
		private Vector2 startPosition;

		[Token(Token = "0x40055FA")]
		[FieldOffset(Offset = "0x24")]
		private Quaternion startRotation;

		[Token(Token = "0x170007BA")]
		public bool Active
		{
			[Token(Token = "0x6004921")]
			[Address(RVA = "0x162FE58", Offset = "0x162FE58", VA = "0x162FE58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F204", Offset = "0x6F204")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004922")]
			[Address(RVA = "0x162FE60", Offset = "0x162FE60", VA = "0x162FE60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F214", Offset = "0x6F214")]
			set
			{
			}
		}

		[Token(Token = "0x6004923")]
		[Address(RVA = "0x162FE68", Offset = "0x162FE68", VA = "0x162FE68")]
		private void Start()
		{
		}

		[Token(Token = "0x6004924")]
		[Address(RVA = "0x162FEC0", Offset = "0x162FEC0", VA = "0x162FEC0", Slot = "5")]
		public virtual void ResetObject()
		{
		}

		[Token(Token = "0x6004925")]
		[Address(RVA = "0x162FA14", Offset = "0x162FA14", VA = "0x162FA14", Slot = "6")]
		public virtual void OnBallEnter(OverworldBall2D ball)
		{
		}

		[Token(Token = "0x6004926")]
		[Address(RVA = "0x162FA2C", Offset = "0x162FA2C", VA = "0x162FA2C", Slot = "7")]
		public virtual void OnBallLeave()
		{
		}

		[Token(Token = "0x6004927")]
		[Address(RVA = "0x162FF18", Offset = "0x162FF18", VA = "0x162FF18", Slot = "8")]
		public virtual void Trigger(bool active)
		{
		}

		[Token(Token = "0x6004928")]
		[Address(RVA = "0x162FE50", Offset = "0x162FE50", VA = "0x162FE50")]
		protected PuzzleObjectBase()
		{
		}
	}
}
