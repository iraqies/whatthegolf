using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x20002B9")]
	public abstract class RigidbodyTimeline<TComponent, TSnapshot> : RecorderTimeline<TComponent, TSnapshot> where TComponent : Component
	{
		[Token(Token = "0x400119B")]
		[FieldOffset(Offset = "0x0")]
		protected float lastPositiveTimeScale;

		[Token(Token = "0x400119C")]
		[FieldOffset(Offset = "0x0")]
		protected TSnapshot zeroSnapshot;

		[Token(Token = "0x400119D")]
		[FieldOffset(Offset = "0x0")]
		protected float zeroTime;

		[Token(Token = "0x400119E")]
		[FieldOffset(Offset = "0x0")]
		protected Vector3 zeroDestination;

		[Token(Token = "0x1700024D")]
		protected abstract bool bodyIsManual
		{
			[Token(Token = "0x600122C")]
			get;
			[Token(Token = "0x600122D")]
			set;
		}

		[Token(Token = "0x1700024E")]
		protected abstract float bodyMass
		{
			[Token(Token = "0x600122E")]
			set;
		}

		[Token(Token = "0x1700024F")]
		protected abstract Vector3 bodyVelocity
		{
			[Token(Token = "0x600122F")]
			get;
			[Token(Token = "0x6001230")]
			set;
		}

		[Token(Token = "0x17000250")]
		protected abstract Vector3 bodyAngularVelocity
		{
			[Token(Token = "0x6001231")]
			get;
			[Token(Token = "0x6001232")]
			set;
		}

		[Token(Token = "0x17000251")]
		protected abstract float bodyDrag
		{
			[Token(Token = "0x6001233")]
			get;
			[Token(Token = "0x6001234")]
			set;
		}

		[Token(Token = "0x17000252")]
		protected abstract float bodyAngularDrag
		{
			[Token(Token = "0x6001235")]
			get;
			[Token(Token = "0x6001236")]
			set;
		}

		[Token(Token = "0x17000253")]
		protected abstract bool isManual
		{
			[Token(Token = "0x6001238")]
			get;
		}

		[Token(Token = "0x17000254")]
		public float mass
		{
			[Token(Token = "0x6001239")]
			set
			{
			}
		}

		[Token(Token = "0x17000255")]
		public float drag
		{
			[Token(Token = "0x600123A")]
			get
			{
				return default;
			}
			[Token(Token = "0x600123B")]
			set
			{
			}
		}

		[Token(Token = "0x17000256")]
		public float angularDrag
		{
			[Token(Token = "0x600123C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600123D")]
			set
			{
			}
		}

		[Token(Token = "0x6001228")]
		public RigidbodyTimeline(Timeline timeline, TComponent component)
		{
		}

		[Token(Token = "0x6001229")]
		public override void Update()
		{
		}

		[Token(Token = "0x600122A")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600122B")]
		public override void ModifySnapshots(SnapshotModifier modifier)
		{
		}

		[Token(Token = "0x6001237")]
		protected abstract void WakeUp();

		[Token(Token = "0x600123E")]
		protected virtual Vector2 AdjustForce(Vector2 force)
		{
			return default;
		}

		[Token(Token = "0x600123F")]
		protected virtual Vector3 AdjustForce(Vector3 force)
		{
			return default;
		}

		[Token(Token = "0x6001240")]
		protected bool AssertForwardProperty(string property, Severity severity)
		{
			return default;
		}

		[Token(Token = "0x6001241")]
		protected bool AssertForwardForce(Severity severity)
		{
			return default;
		}
	}
}
