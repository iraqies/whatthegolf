using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Audio.Impact;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Arena
{
	[Token(Token = "0x2001213")]
	public class ArenaCrab : MonoBehaviour
	{
		[Token(Token = "0x2001214")]
		public enum PushState
		{
			[Token(Token = "0x40061B5")]
			Push = 0,
			[Token(Token = "0x40061B6")]
			Recovering = 1,
			[Token(Token = "0x40061B7")]
			None = 2
		}

		[Token(Token = "0x2001215")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48504", Offset = "0x48504")]
		private sealed class _003CSquashCoroutine_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40061B8")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40061B9")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40061BA")]
			[FieldOffset(Offset = "0x20")]
			public ArenaCrab _003C_003E4__this;

			[Token(Token = "0x1700092D")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005343")]
				[Address(RVA = "0x176ED20", Offset = "0x176ED20", VA = "0x176ED20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700092E")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005345")]
				[Address(RVA = "0x176ED68", Offset = "0x176ED68", VA = "0x176ED68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005340")]
			[Address(RVA = "0x176EB90", Offset = "0x176EB90", VA = "0x176EB90")]
			[DebuggerHidden]
			public _003CSquashCoroutine_003Ed__63(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005341")]
			[Address(RVA = "0x176EBBC", Offset = "0x176EBBC", VA = "0x176EBBC", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005342")]
			[Address(RVA = "0x176EBC0", Offset = "0x176EBC0", VA = "0x176EBC0", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005343")]
			[Address(RVA = "0x176ED20", Offset = "0x176ED20", VA = "0x176ED20", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005344")]
			[Address(RVA = "0x176ED28", Offset = "0x176ED28", VA = "0x176ED28", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005345")]
			[Address(RVA = "0x176ED68", Offset = "0x176ED68", VA = "0x176ED68", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006197")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform modelContainer;

		[Token(Token = "0x4006198")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float squashDuration;

		[Token(Token = "0x4006199")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5840C", Offset = "0x5840C")]
		private float squashSlowFactor;

		[Token(Token = "0x400619A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioEventAsset _sfxOnSquash;

		[Token(Token = "0x400619B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioEventAsset _sfxOnUnsquash;

		[Token(Token = "0x400619C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ParticleSystem squashParticles;

		[Token(Token = "0x400619D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ImpactAsset gruntOnHit;

		[Token(Token = "0x400619E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float initialPushMultiplier;

		[Token(Token = "0x400619F")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ForceMode initialPushForceMode;

		[Token(Token = "0x40061A0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float updateForceMultiplier;

		[Token(Token = "0x40061A1")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ForceMode updateForceMode;

		[Token(Token = "0x40061A2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ImpactAsset sfxOnPush;

		[Token(Token = "0x40061A3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float regainShootVelocityTime;

		[Token(Token = "0x40061A4")]
		[FieldOffset(Offset = "0x68")]
		private Rigidbody _rigidbody;

		[Token(Token = "0x40061A5")]
		[FieldOffset(Offset = "0x70")]
		private Transform _transform;

		[Token(Token = "0x40061A6")]
		[FieldOffset(Offset = "0x78")]
		private ArenaCrabShooter _shooter;

		[Token(Token = "0x40061A7")]
		[FieldOffset(Offset = "0x80")]
		private float _maxSpeed;

		[Token(Token = "0x40061A8")]
		[FieldOffset(Offset = "0x84")]
		private float _maxLegMoveSpeed;

		[Token(Token = "0x40061A9")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 _scale;

		[Token(Token = "0x40061AA")]
		[FieldOffset(Offset = "0x98")]
		private WaitForSeconds _squashWait;

		[Token(Token = "0x40061AB")]
		[FieldOffset(Offset = "0xA0")]
		private List<ArenaCrab> touchingCrabs;

		[Token(Token = "0x40061AC")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x584EC", Offset = "0x584EC")]
		private Action<ArenaDroppable, ArenaCrab> m_OnCrabHit;

		[Token(Token = "0x40061AD")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x584FC", Offset = "0x584FC")]
		private bool IsBeingPushed__BackingField;

		[Token(Token = "0x40061AE")]
		[FieldOffset(Offset = "0xB1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5850C", Offset = "0x5850C")]
		private bool isSquashed__BackingField;

		[Token(Token = "0x40061AF")]
		[FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5851C", Offset = "0x5851C")]
		private Vector3 Velocity__BackingField;

		[Token(Token = "0x40061B0")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5852C", Offset = "0x5852C")]
		private float LastPushTime__BackingField;

		[Token(Token = "0x40061B1")]
		[FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5853C", Offset = "0x5853C")]
		private float PushForce__BackingField;

		[Token(Token = "0x40061B2")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5854C", Offset = "0x5854C")]
		private Vector3 PushDirection__BackingField;

		[Token(Token = "0x40061B3")]
		[FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5855C", Offset = "0x5855C")]
		private PushState CurrentPushState__BackingField;

		[Token(Token = "0x17000926")]
		public bool IsBeingPushed
		{
			[Token(Token = "0x6005326")]
			[Address(RVA = "0x1420FF8", Offset = "0x1420FF8", VA = "0x1420FF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70D98", Offset = "0x70D98")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005327")]
			[Address(RVA = "0x1421000", Offset = "0x1421000", VA = "0x1421000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70DA8", Offset = "0x70DA8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000927")]
		public bool isSquashed
		{
			[Token(Token = "0x6005328")]
			[Address(RVA = "0x1421008", Offset = "0x1421008", VA = "0x1421008")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70DB8", Offset = "0x70DB8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005329")]
			[Address(RVA = "0x1421010", Offset = "0x1421010", VA = "0x1421010")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70DC8", Offset = "0x70DC8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000928")]
		public Vector3 Velocity
		{
			[Token(Token = "0x600532A")]
			[Address(RVA = "0x1421018", Offset = "0x1421018", VA = "0x1421018")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70DD8", Offset = "0x70DD8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600532B")]
			[Address(RVA = "0x1421024", Offset = "0x1421024", VA = "0x1421024")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70DE8", Offset = "0x70DE8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000929")]
		public float LastPushTime
		{
			[Token(Token = "0x600532C")]
			[Address(RVA = "0x1421030", Offset = "0x1421030", VA = "0x1421030")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70DF8", Offset = "0x70DF8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600532D")]
			[Address(RVA = "0x1421038", Offset = "0x1421038", VA = "0x1421038")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70E08", Offset = "0x70E08")]
			private set
			{
			}
		}

		[Token(Token = "0x1700092A")]
		public float PushForce
		{
			[Token(Token = "0x600532E")]
			[Address(RVA = "0x1421040", Offset = "0x1421040", VA = "0x1421040")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70E18", Offset = "0x70E18")]
			get
			{
				return default;
			}
			[Token(Token = "0x600532F")]
			[Address(RVA = "0x1421048", Offset = "0x1421048", VA = "0x1421048")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70E28", Offset = "0x70E28")]
			private set
			{
			}
		}

		[Token(Token = "0x1700092B")]
		public Vector3 PushDirection
		{
			[Token(Token = "0x6005330")]
			[Address(RVA = "0x1421050", Offset = "0x1421050", VA = "0x1421050")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70E38", Offset = "0x70E38")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005331")]
			[Address(RVA = "0x142105C", Offset = "0x142105C", VA = "0x142105C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70E48", Offset = "0x70E48")]
			private set
			{
			}
		}

		[Token(Token = "0x1700092C")]
		public PushState CurrentPushState
		{
			[Token(Token = "0x6005332")]
			[Address(RVA = "0x1421068", Offset = "0x1421068", VA = "0x1421068")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70E58", Offset = "0x70E58")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005333")]
			[Address(RVA = "0x1421070", Offset = "0x1421070", VA = "0x1421070")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70E68", Offset = "0x70E68")]
			private set
			{
			}
		}

		[Token(Token = "0x1400008F")]
		public event Action<ArenaDroppable, ArenaCrab> OnCrabHit
		{
			[Token(Token = "0x6005324")]
			[Address(RVA = "0x1420EB0", Offset = "0x1420EB0", VA = "0x1420EB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70D78", Offset = "0x70D78")]
			add
			{
			}
			[Token(Token = "0x6005325")]
			[Address(RVA = "0x1420F54", Offset = "0x1420F54", VA = "0x1420F54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70D88", Offset = "0x70D88")]
			remove
			{
			}
		}

		[Token(Token = "0x6005334")]
		[Address(RVA = "0x1421078", Offset = "0x1421078", VA = "0x1421078")]
		public GolfBallController GetController()
		{
			return null;
		}

		[Token(Token = "0x6005335")]
		[Address(RVA = "0x1421094", Offset = "0x1421094", VA = "0x1421094")]
		private void Start()
		{
		}

		[Token(Token = "0x6005336")]
		[Address(RVA = "0x1421258", Offset = "0x1421258", VA = "0x1421258")]
		private void OnCrabShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005337")]
		[Address(RVA = "0x14215B8", Offset = "0x14215B8", VA = "0x14215B8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6005338")]
		[Address(RVA = "0x142182C", Offset = "0x142182C", VA = "0x142182C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6005339")]
		[Address(RVA = "0x1421B34", Offset = "0x1421B34", VA = "0x1421B34")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600533A")]
		[Address(RVA = "0x142152C", Offset = "0x142152C", VA = "0x142152C")]
		public void DoPush(Vector3 incomingVelocity, Vector3 direction)
		{
		}

		[Token(Token = "0x600533B")]
		[Address(RVA = "0x1421C34", Offset = "0x1421C34", VA = "0x1421C34")]
		public void OnDroppedOnCrab(ArenaDroppable dropped)
		{
		}

		[Token(Token = "0x600533C")]
		[Address(RVA = "0x1421D94", Offset = "0x1421D94", VA = "0x1421D94")]
		public void Squash()
		{
		}

		[Token(Token = "0x600533D")]
		[Address(RVA = "0x1421EA0", Offset = "0x1421EA0", VA = "0x1421EA0")]
		private void Recover()
		{
		}

		[Token(Token = "0x600533E")]
		[Address(RVA = "0x1421E2C", Offset = "0x1421E2C", VA = "0x1421E2C")]
		private IEnumerator SquashCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600533F")]
		[Address(RVA = "0x1421EF8", Offset = "0x1421EF8", VA = "0x1421EF8")]
		public ArenaCrab()
		{
		}
	}
}
