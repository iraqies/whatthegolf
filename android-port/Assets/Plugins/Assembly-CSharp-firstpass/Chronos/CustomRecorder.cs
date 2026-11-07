using System.Collections.Generic;
using Chronos.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x2000295")]
	public class CustomRecorder : Recorder<CustomRecorder.Snapshot>
	{
		[Token(Token = "0x2000296")]
		public class Snapshot
		{
			[Token(Token = "0x4001129")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x372B4", Offset = "0x372B4")]
			private object[] values__BackingField;

			[Token(Token = "0x17000212")]
			public object[] values
			{
				[Token(Token = "0x6001124")]
				[Address(RVA = "0x1339530", Offset = "0x1339530", VA = "0x1339530")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B7AC", Offset = "0x3B7AC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6001125")]
				[Address(RVA = "0x1339538", Offset = "0x1339538", VA = "0x1339538")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B7BC", Offset = "0x3B7BC")]
				private set
				{
				}
			}

			[Token(Token = "0x6001126")]
			[Address(RVA = "0x1339540", Offset = "0x1339540", VA = "0x1339540")]
			public Snapshot(int size)
			{
			}
		}

		[Token(Token = "0x4001128")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<UnityVariable> variables;

		[Token(Token = "0x600111F")]
		[Address(RVA = "0x1363588", Offset = "0x1363588", VA = "0x1363588")]
		public CustomRecorder()
		{
		}

		[Token(Token = "0x6001120")]
		[Address(RVA = "0x1363628", Offset = "0x1363628", VA = "0x1363628", Slot = "10")]
		protected override void ApplySnapshot(Snapshot snapshot)
		{
		}

		[Token(Token = "0x6001121")]
		[Address(RVA = "0x13637CC", Offset = "0x13637CC", VA = "0x13637CC", Slot = "11")]
		protected override Snapshot CopySnapshot()
		{
			return null;
		}

		[Token(Token = "0x6001122")]
		[Address(RVA = "0x13639F0", Offset = "0x13639F0", VA = "0x13639F0", Slot = "12")]
		protected override Snapshot LerpSnapshots(Snapshot from, Snapshot to, float t)
		{
			return null;
		}

		[Token(Token = "0x6001123")]
		[Address(RVA = "0x1363B34", Offset = "0x1363B34", VA = "0x1363B34")]
		private static object LerpValue(object from, object to, float t)
		{
			return null;
		}
	}
}
