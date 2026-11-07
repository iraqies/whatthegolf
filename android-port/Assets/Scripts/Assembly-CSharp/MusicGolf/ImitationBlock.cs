using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace MusicGolf
{
	[Token(Token = "0x20010BD")]
	public class ImitationBlock : MonoBehaviour
	{
		[Token(Token = "0x20010BE")]
		private class MaterialInfo
		{
			[Token(Token = "0x4005832")]
			[FieldOffset(Offset = "0x10")]
			public Material material;

			[Token(Token = "0x4005833")]
			[FieldOffset(Offset = "0x18")]
			public Color color;

			[Token(Token = "0x6004B05")]
			[Address(RVA = "0x17C36C0", Offset = "0x17C36C0", VA = "0x17C36C0")]
			public MaterialInfo()
			{
			}
		}

		[Token(Token = "0x20010BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47B24", Offset = "0x47B24")]
		private sealed class _003CPlayCoroutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005834")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005835")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005836")]
			[FieldOffset(Offset = "0x20")]
			public ImitationBlock _003C_003E4__this;

			[Token(Token = "0x4005837")]
			[FieldOffset(Offset = "0x28")]
			public VoiceType type;

			[Token(Token = "0x170007EB")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004B09")]
				[Address(RVA = "0x17C3670", Offset = "0x17C3670", VA = "0x17C3670", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007EC")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004B0B")]
				[Address(RVA = "0x17C36B8", Offset = "0x17C36B8", VA = "0x17C36B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004B06")]
			[Address(RVA = "0x17C352C", Offset = "0x17C352C", VA = "0x17C352C")]
			[DebuggerHidden]
			public _003CPlayCoroutine_003Ed__23(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004B07")]
			[Address(RVA = "0x17C3558", Offset = "0x17C3558", VA = "0x17C3558", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004B08")]
			[Address(RVA = "0x17C355C", Offset = "0x17C355C", VA = "0x17C355C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004B09")]
			[Address(RVA = "0x17C3670", Offset = "0x17C3670", VA = "0x17C3670", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004B0A")]
			[Address(RVA = "0x17C3678", Offset = "0x17C3678", VA = "0x17C3678", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004B0B")]
			[Address(RVA = "0x17C36B8", Offset = "0x17C36B8", VA = "0x17C36B8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20010C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47B34", Offset = "0x47B34")]
		private sealed class _003CGlowCoroutine_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005838")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005839")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400583A")]
			[FieldOffset(Offset = "0x20")]
			public ImitationBlock _003C_003E4__this;

			[Token(Token = "0x170007ED")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004B0F")]
				[Address(RVA = "0x17C34DC", Offset = "0x17C34DC", VA = "0x17C34DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007EE")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004B11")]
				[Address(RVA = "0x17C3524", Offset = "0x17C3524", VA = "0x17C3524", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004B0C")]
			[Address(RVA = "0x17C33AC", Offset = "0x17C33AC", VA = "0x17C33AC")]
			[DebuggerHidden]
			public _003CGlowCoroutine_003Ed__26(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004B0D")]
			[Address(RVA = "0x17C33D8", Offset = "0x17C33D8", VA = "0x17C33D8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004B0E")]
			[Address(RVA = "0x17C33DC", Offset = "0x17C33DC", VA = "0x17C33DC", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004B0F")]
			[Address(RVA = "0x17C34DC", Offset = "0x17C34DC", VA = "0x17C34DC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004B10")]
			[Address(RVA = "0x17C34E4", Offset = "0x17C34E4", VA = "0x17C34E4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004B11")]
			[Address(RVA = "0x17C3524", Offset = "0x17C3524", VA = "0x17C3524", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005824")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioClip questionClip;

		[Token(Token = "0x4005825")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip answerClip;

		[Token(Token = "0x4005826")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StingerData answerStinger;

		[Token(Token = "0x4005827")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private StingerData lastAnswerStinger;

		[Token(Token = "0x4005828")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Renderer renderer;

		[Token(Token = "0x4005829")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationCurve glowAnimationCurve;

		[Token(Token = "0x400582A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float glowDuration;

		[Token(Token = "0x400582B")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Color glowColor;

		[Token(Token = "0x400582C")]
		[FieldOffset(Offset = "0x60")]
		private MaterialInfo[] materialInfo;

		[Token(Token = "0x400582D")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55FA0", Offset = "0x55FA0")]
		private bool IsLastAnswer__BackingField;

		[Token(Token = "0x400582E")]
		[FieldOffset(Offset = "0x69")]
		private bool isPlaying;

		[Token(Token = "0x400582F")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55FB0", Offset = "0x55FB0")]
		private Action<ImitationBlock> m_OnAfterPlay;

		[Token(Token = "0x4005830")]
		[FieldOffset(Offset = "0x78")]
		private float lastCollisionTime;

		[Token(Token = "0x4005831")]
		[FieldOffset(Offset = "0x80")]
		private AudioSource audioSource;

		[Token(Token = "0x170007EA")]
		public bool IsLastAnswer
		{
			[Token(Token = "0x6004AF8")]
			[Address(RVA = "0x14E5CE0", Offset = "0x14E5CE0", VA = "0x14E5CE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7D4", Offset = "0x6F7D4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004AF9")]
			[Address(RVA = "0x14E5CE8", Offset = "0x14E5CE8", VA = "0x14E5CE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7E4", Offset = "0x6F7E4")]
			set
			{
			}
		}

		[Token(Token = "0x1400007D")]
		public event Action<ImitationBlock> OnAfterPlay
		{
			[Token(Token = "0x6004AFA")]
			[Address(RVA = "0x14E5CF0", Offset = "0x14E5CF0", VA = "0x14E5CF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F7F4", Offset = "0x6F7F4")]
			add
			{
			}
			[Token(Token = "0x6004AFB")]
			[Address(RVA = "0x14E5D94", Offset = "0x14E5D94", VA = "0x14E5D94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F804", Offset = "0x6F804")]
			remove
			{
			}
		}

		[Token(Token = "0x6004AFC")]
		[Address(RVA = "0x14E5E38", Offset = "0x14E5E38", VA = "0x14E5E38")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004AFD")]
		[Address(RVA = "0x14E5FC4", Offset = "0x14E5FC4", VA = "0x14E5FC4")]
		private void OnCollisionEnter2D(Collision2D col)
		{
		}

		[Token(Token = "0x6004AFE")]
		[Address(RVA = "0x14E6074", Offset = "0x14E6074", VA = "0x14E6074")]
		public void Play(VoiceType type)
		{
		}

		[Token(Token = "0x6004AFF")]
		[Address(RVA = "0x14E60F8", Offset = "0x14E60F8", VA = "0x14E60F8")]
		private IEnumerator PlayCoroutine(VoiceType type)
		{
			return null;
		}

		[Token(Token = "0x6004B00")]
		[Address(RVA = "0x14E6174", Offset = "0x14E6174", VA = "0x14E6174")]
		public void StopPlaying()
		{
		}

		[Token(Token = "0x6004B01")]
		[Address(RVA = "0x14E6190", Offset = "0x14E6190", VA = "0x14E6190")]
		public void Glow(float duration)
		{
		}

		[Token(Token = "0x6004B02")]
		[Address(RVA = "0x14E620C", Offset = "0x14E620C", VA = "0x14E620C")]
		private IEnumerator GlowCoroutine(float duration)
		{
			return null;
		}

		[Token(Token = "0x6004B03")]
		[Address(RVA = "0x14E6280", Offset = "0x14E6280", VA = "0x14E6280")]
		public ImitationBlock()
		{
		}

		[Token(Token = "0x6004B04")]
		[Address(RVA = "0x14E62D8", Offset = "0x14E62D8", VA = "0x14E62D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F814", Offset = "0x6F814")]
		private void _003CGlowCoroutine_003Eb__26_0(float t)
		{
		}
	}
}
