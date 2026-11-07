using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x200028C")]
	public abstract class AreaClock<TCollider, TVector> : Clock, IAreaClock
	{
		[Serializable]
		[Token(Token = "0x200028D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34240", Offset = "0x34240")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4001110")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4001111")]
			[FieldOffset(Offset = "0x0")]
			public static Func<Timeline, bool> _003C_003E9__28_0;

			[Token(Token = "0x60010DD")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60010DE")]
			internal bool _003CReleaseAll_003Eb__28_0(Timeline w)
			{
				return default;
			}
		}

		[Token(Token = "0x4001108")]
		[FieldOffset(Offset = "0x0")]
		protected Dictionary<Timeline, Vector3> within;

		[Token(Token = "0x4001109")]
		[FieldOffset(Offset = "0x0")]
		protected HashSet<Timeline> outOfBounds;

		[Token(Token = "0x400110A")]
		[FieldOffset(Offset = "0x0")]
		protected TCollider collider;

		[Token(Token = "0x400110B")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private AreaClockMode _mode;

		[Token(Token = "0x400110C")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private AnimationCurve _curve;

		[Token(Token = "0x400110D")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TVector _center;

		[Token(Token = "0x400110E")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float _padding;

		[Token(Token = "0x400110F")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ClockBlend _innerBlend;

		[Token(Token = "0x17000200")]
		public AreaClockMode mode
		{
			[Token(Token = "0x60010CA")]
			get
			{
				return default;
			}
			[Token(Token = "0x60010CB")]
			set
			{
			}
		}

		[Token(Token = "0x17000201")]
		public AnimationCurve curve
		{
			[Token(Token = "0x60010CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010CD")]
			set
			{
			}
		}

		[Token(Token = "0x17000202")]
		public TVector center
		{
			[Token(Token = "0x60010CE")]
			get
			{
				return (TVector)null;
			}
			[Token(Token = "0x60010CF")]
			set
			{
			}
		}

		[Token(Token = "0x17000203")]
		public float padding
		{
			[Token(Token = "0x60010D0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60010D1")]
			set
			{
			}
		}

		[Token(Token = "0x17000204")]
		public ClockBlend innerBlend
		{
			[Token(Token = "0x60010D2")]
			get
			{
				return default;
			}
			[Token(Token = "0x60010D3")]
			set
			{
			}
		}

		[Token(Token = "0x60010C7")]
		public AreaClock()
		{
		}

		[Token(Token = "0x60010C8")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60010C9")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60010D4")]
		protected virtual void Capture(Timeline timeline, Vector3 entry)
		{
		}

		[Token(Token = "0x60010D5")]
		public virtual void Release(Timeline timeline)
		{
		}

		[Token(Token = "0x60010D6")]
		public virtual void ReleaseAll()
		{
		}

		[Token(Token = "0x60010D7")]
		private float Chronos_002EIAreaClock_002ETimeScale(Timeline timeline)
		{
			return default;
		}

		[Token(Token = "0x60010D8")]
		protected virtual float DistanceFromEntryTimeScale(Vector3 entry, Vector3 position)
		{
			return default;
		}

		[Token(Token = "0x60010D9")]
		protected abstract float PointToEdgeTimeScale(Vector3 position);

		[Token(Token = "0x60010DA")]
		public abstract bool ContainsPoint(Vector3 point);

		[Token(Token = "0x60010DB")]
		public virtual void CacheComponents()
		{
		}
	}
}
