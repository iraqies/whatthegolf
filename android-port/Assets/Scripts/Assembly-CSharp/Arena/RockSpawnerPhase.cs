using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

namespace Arena
{
	[Token(Token = "0x2001228")]
	public abstract class RockSpawnerPhase : MonoBehaviour
	{
		[Token(Token = "0x2001229")]
		public enum TransitionCondition
		{
			[Token(Token = "0x400623C")]
			AllPlayerAtLastPoint = 0,
			[Token(Token = "0x400623D")]
			SomeoneDied = 1
		}

		[Token(Token = "0x4006238")]
		[FieldOffset(Offset = "0x18")]
		public TransitionCondition transitionCondition;

		[Token(Token = "0x4006239")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5876C", Offset = "0x5876C")]
		private Vector2[] CurrentSafeSpots__BackingField;

		[Token(Token = "0x400623A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5877C", Offset = "0x5877C")]
		private ObjectPool<ArenaDroppableRock> RockPool__BackingField;

		[Token(Token = "0x1700093E")]
		public abstract bool IsSpawning
		{
			[Token(Token = "0x60053B3")]
			get;
			[Token(Token = "0x60053B4")]
			set;
		}

		[Token(Token = "0x1700093F")]
		public Vector2[] CurrentSafeSpots
		{
			[Token(Token = "0x60053B6")]
			[Address(RVA = "0x1658FB8", Offset = "0x1658FB8", VA = "0x1658FB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x71168", Offset = "0x71168")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053B7")]
			[Address(RVA = "0x1658FC0", Offset = "0x1658FC0", VA = "0x1658FC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x71178", Offset = "0x71178")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000940")]
		public ObjectPool<ArenaDroppableRock> RockPool
		{
			[Token(Token = "0x60053B8")]
			[Address(RVA = "0x1658FC8", Offset = "0x1658FC8", VA = "0x1658FC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x71188", Offset = "0x71188")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053B9")]
			[Address(RVA = "0x1658FD0", Offset = "0x1658FD0", VA = "0x1658FD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x71198", Offset = "0x71198")]
			set
			{
			}
		}

		[Token(Token = "0x60053B5")]
		public abstract IEnumerator SpawnCoroutine();

		[Token(Token = "0x60053BA")]
		[Address(RVA = "0x1658FD8", Offset = "0x1658FD8", VA = "0x1658FD8")]
		protected RockSpawnerPhase()
		{
		}
	}
}
