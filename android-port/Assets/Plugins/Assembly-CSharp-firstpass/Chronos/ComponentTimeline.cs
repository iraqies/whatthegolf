using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x2000294")]
	public abstract class ComponentTimeline<T> : IComponentTimeline where T : Component
	{
		[Token(Token = "0x4001126")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37284", Offset = "0x37284")]
		private Timeline timeline__BackingField;

		[Token(Token = "0x4001127")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37294", Offset = "0x37294")]
		private T component__BackingField;

		[Token(Token = "0x17000210")]
		protected Timeline timeline
		{
			[Token(Token = "0x6001111")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B76C", Offset = "0x3B76C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001112")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B77C", Offset = "0x3B77C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000211")]
		public T component
		{
			[Token(Token = "0x6001113")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B78C", Offset = "0x3B78C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001114")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B79C", Offset = "0x3B79C")]
			internal set
			{
			}
		}

		[Token(Token = "0x6001115")]
		public ComponentTimeline(Timeline timeline, T component)
		{
		}

		[Token(Token = "0x6001116")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6001117")]
		public virtual void OnStartOrReEnable()
		{
		}

		[Token(Token = "0x6001118")]
		public virtual void Update()
		{
		}

		[Token(Token = "0x6001119")]
		public virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600111A")]
		public virtual void OnDisable()
		{
		}

		[Token(Token = "0x600111B")]
		public virtual void CopyProperties(T source)
		{
		}

		[Token(Token = "0x600111C")]
		public virtual void AdjustProperties(float timeScale)
		{
		}

		[Token(Token = "0x600111D")]
		public void AdjustProperties()
		{
		}

		[Token(Token = "0x600111E")]
		public virtual void Reset()
		{
		}
	}
}
