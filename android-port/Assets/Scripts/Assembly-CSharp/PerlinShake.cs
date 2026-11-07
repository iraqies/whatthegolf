using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003FA")]
public class PerlinShake : MonoBehaviour
{
	[Token(Token = "0x20003FB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F97C", Offset = "0x3F97C")]
	private sealed class _003CShakePosition_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40015B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40015B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40015B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve damper;

		[Token(Token = "0x40015BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x40015BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float magnitude;

		[Token(Token = "0x40015BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float speed;

		[Token(Token = "0x40015BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform transform;

		[Token(Token = "0x40015BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 originalPosition;

		[Token(Token = "0x40015BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public PerlinShake _003C_003E4__this;

		[Token(Token = "0x40015C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _003Celapsed_003E5__2;

		[Token(Token = "0x17000220")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60012B5")]
			[Address(RVA = "0x18235DC", Offset = "0x18235DC", VA = "0x18235DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000221")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60012B7")]
			[Address(RVA = "0x1823624", Offset = "0x1823624", VA = "0x1823624", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60012B2")]
		[Address(RVA = "0x1823460", Offset = "0x1823460", VA = "0x1823460")]
		[DebuggerHidden]
		public _003CShakePosition_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60012B3")]
		[Address(RVA = "0x182348C", Offset = "0x182348C", VA = "0x182348C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60012B4")]
		[Address(RVA = "0x1823490", Offset = "0x1823490", VA = "0x1823490", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60012B5")]
		[Address(RVA = "0x18235DC", Offset = "0x18235DC", VA = "0x18235DC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60012B6")]
		[Address(RVA = "0x18235E4", Offset = "0x18235E4", VA = "0x18235E4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60012B7")]
		[Address(RVA = "0x1823624", Offset = "0x1823624", VA = "0x1823624", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20003FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F98C", Offset = "0x3F98C")]
	private sealed class _003CShakeRotation_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40015C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40015C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40015C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion originalRotation;

		[Token(Token = "0x40015C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve damper;

		[Token(Token = "0x40015C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float duration;

		[Token(Token = "0x40015C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float magnitude;

		[Token(Token = "0x40015C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float speed;

		[Token(Token = "0x40015C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform transform;

		[Token(Token = "0x40015C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public PerlinShake _003C_003E4__this;

		[Token(Token = "0x40015CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 _003CoriginalEuler_003E5__2;

		[Token(Token = "0x40015CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float _003Celapsed_003E5__3;

		[Token(Token = "0x17000222")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60012BB")]
			[Address(RVA = "0x1823800", Offset = "0x1823800", VA = "0x1823800", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000223")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60012BD")]
			[Address(RVA = "0x1823848", Offset = "0x1823848", VA = "0x1823848", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60012B8")]
		[Address(RVA = "0x182362C", Offset = "0x182362C", VA = "0x182362C")]
		[DebuggerHidden]
		public _003CShakeRotation_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60012B9")]
		[Address(RVA = "0x1823658", Offset = "0x1823658", VA = "0x1823658", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60012BA")]
		[Address(RVA = "0x182365C", Offset = "0x182365C", VA = "0x182365C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60012BB")]
		[Address(RVA = "0x1823800", Offset = "0x1823800", VA = "0x1823800", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60012BC")]
		[Address(RVA = "0x1823808", Offset = "0x1823808", VA = "0x1823808", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60012BD")]
		[Address(RVA = "0x1823848", Offset = "0x1823848", VA = "0x1823848", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20003FD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F99C", Offset = "0x3F99C")]
	private sealed class _003CShakeCameraProjection_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40015CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40015CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40015CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve damper;

		[Token(Token = "0x40015CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x40015D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float magnitude;

		[Token(Token = "0x40015D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float speed;

		[Token(Token = "0x40015D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Camera camera;

		[Token(Token = "0x40015D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _003Celapsed_003E5__2;

		[Token(Token = "0x17000224")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60012C1")]
			[Address(RVA = "0x1823410", Offset = "0x1823410", VA = "0x1823410", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000225")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60012C3")]
			[Address(RVA = "0x1823458", Offset = "0x1823458", VA = "0x1823458", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60012BE")]
		[Address(RVA = "0x18231C8", Offset = "0x18231C8", VA = "0x18231C8")]
		[DebuggerHidden]
		public _003CShakeCameraProjection_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60012BF")]
		[Address(RVA = "0x18231F4", Offset = "0x18231F4", VA = "0x18231F4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60012C0")]
		[Address(RVA = "0x18231F8", Offset = "0x18231F8", VA = "0x18231F8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60012C1")]
		[Address(RVA = "0x1823410", Offset = "0x1823410", VA = "0x1823410", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60012C2")]
		[Address(RVA = "0x1823418", Offset = "0x1823418", VA = "0x1823418", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60012C3")]
		[Address(RVA = "0x1823458", Offset = "0x1823458", VA = "0x1823458", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40015AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float duration;

	[Token(Token = "0x40015AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float speed;

	[Token(Token = "0x40015B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float magnitude;

	[Token(Token = "0x40015B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve damper;

	[Token(Token = "0x40015B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool testPosition;

	[Token(Token = "0x40015B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool testRotation;

	[Token(Token = "0x40015B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool testProjection;

	[Token(Token = "0x40015B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 originalPos;

	[Token(Token = "0x40015B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion originalRot;

	[Token(Token = "0x60012A8")]
	[Address(RVA = "0x15DE224", Offset = "0x15DE224", VA = "0x15DE224")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60012A9")]
	[Address(RVA = "0x15DE228", Offset = "0x15DE228", VA = "0x15DE228")]
	private void UpdateOriginalInfo()
	{
	}

	[Token(Token = "0x60012AA")]
	[Address(RVA = "0x15DE284", Offset = "0x15DE284", VA = "0x15DE284")]
	public void Shake()
	{
	}

	[Token(Token = "0x60012AB")]
	[Address(RVA = "0x15DE2AC", Offset = "0x15DE2AC", VA = "0x15DE2AC")]
	public void StopShake()
	{
	}

	[Token(Token = "0x60012AC")]
	[Address(RVA = "0x15DE318", Offset = "0x15DE318", VA = "0x15DE318")]
	public void Shake(float duration, float speed, float magnitude)
	{
	}

	[Token(Token = "0x60012AD")]
	[Address(RVA = "0x15DE3C4", Offset = "0x15DE3C4", VA = "0x15DE3C4")]
	private void Update()
	{
	}

	[Token(Token = "0x60012AE")]
	[Address(RVA = "0x15DE620", Offset = "0x15DE620", VA = "0x15DE620")]
	private IEnumerator ShakePosition(Transform transform, Vector3 originalPosition, float duration, float speed, float magnitude, [Optional] AnimationCurve damper)
	{
		return null;
	}

	[Token(Token = "0x60012AF")]
	[Address(RVA = "0x15DE6EC", Offset = "0x15DE6EC", VA = "0x15DE6EC")]
	private IEnumerator ShakeRotation(Transform transform, Quaternion originalRotation, float duration, float speed, float magnitude, [Optional] AnimationCurve damper)
	{
		return null;
	}

	[Token(Token = "0x60012B0")]
	[Address(RVA = "0x15DE7C0", Offset = "0x15DE7C0", VA = "0x15DE7C0")]
	private IEnumerator ShakeCameraProjection(Camera camera, float duration, float speed, float magnitude, [Optional] AnimationCurve damper)
	{
		return null;
	}

	[Token(Token = "0x60012B1")]
	[Address(RVA = "0x15DE860", Offset = "0x15DE860", VA = "0x15DE860")]
	public PerlinShake()
	{
	}
}
