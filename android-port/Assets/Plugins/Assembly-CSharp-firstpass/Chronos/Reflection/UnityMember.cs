using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Chronos.Reflection
{
	[Serializable]
	[Token(Token = "0x20002C3")]
	public abstract class UnityMember
	{
		[Token(Token = "0x40011BE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UnityEngine.Object _target;

		[Token(Token = "0x40011BF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _component;

		[Token(Token = "0x40011C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _name;

		[Token(Token = "0x40011C1")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x37580", Offset = "0x37580")]
		private bool isTargeted__BackingField;

		[Token(Token = "0x40011C2")]
		[FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x37590", Offset = "0x37590")]
		private bool isReflected__BackingField;

		[Token(Token = "0x40011C3")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x375A0", Offset = "0x375A0")]
		private UnityEngine.Object reflectionTarget__BackingField;

		[Token(Token = "0x17000270")]
		public UnityEngine.Object target
		{
			[Token(Token = "0x600128D")]
			[Address(RVA = "0x1325D38", Offset = "0x1325D38", VA = "0x1325D38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000271")]
		public string component
		{
			[Token(Token = "0x600128E")]
			[Address(RVA = "0x1325D40", Offset = "0x1325D40", VA = "0x1325D40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000272")]
		public string name
		{
			[Token(Token = "0x600128F")]
			[Address(RVA = "0x1325D48", Offset = "0x1325D48", VA = "0x1325D48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000273")]
		protected bool isTargeted
		{
			[Token(Token = "0x6001290")]
			[Address(RVA = "0x1325D50", Offset = "0x1325D50", VA = "0x1325D50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BBBC", Offset = "0x3BBBC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000274")]
		public bool isReflected
		{
			[Token(Token = "0x6001291")]
			[Address(RVA = "0x1325D58", Offset = "0x1325D58", VA = "0x1325D58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BBCC", Offset = "0x3BBCC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001292")]
			[Address(RVA = "0x1325D60", Offset = "0x1325D60", VA = "0x1325D60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BBDC", Offset = "0x3BBDC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000275")]
		public bool isAssigned
		{
			[Token(Token = "0x6001293")]
			[Address(RVA = "0x1325D68", Offset = "0x1325D68", VA = "0x1325D68")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000276")]
		protected UnityEngine.Object reflectionTarget
		{
			[Token(Token = "0x6001294")]
			[Address(RVA = "0x1325DFC", Offset = "0x1325DFC", VA = "0x1325DFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BBEC", Offset = "0x3BBEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001295")]
			[Address(RVA = "0x1325E04", Offset = "0x1325E04", VA = "0x1325E04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BBFC", Offset = "0x3BBFC")]
			private set
			{
			}
		}

		[Token(Token = "0x6001296")]
		[Address(RVA = "0x1325E0C", Offset = "0x1325E0C", VA = "0x1325E0C")]
		public UnityMember()
		{
		}

		[Token(Token = "0x6001297")]
		[Address(RVA = "0x1325E14", Offset = "0x1325E14", VA = "0x1325E14")]
		protected void Target()
		{
		}

		[Token(Token = "0x6001298")]
		public abstract void Reflect();

		[Token(Token = "0x6001299")]
		[Address(RVA = "0x1326228", Offset = "0x1326228", VA = "0x1326228")]
		public void EnsureReflected()
		{
		}

		[Token(Token = "0x600129A")]
		[Address(RVA = "0x1326240", Offset = "0x1326240", VA = "0x1326240")]
		public void EnsureTargeted()
		{
		}

		[Token(Token = "0x600129B")]
		[Address(RVA = "0x1326250", Offset = "0x1326250", VA = "0x1326250")]
		public void EnsureAssigned()
		{
		}
	}
}
