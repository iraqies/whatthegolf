using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200137A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x48D64", Offset = "0x48D64")]
	public class IntroLoopOutro : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200137B")]
		internal class ILO_Envelope
		{
			[Token(Token = "0x4006888")]
			[FieldOffset(Offset = "0x10")]
			public bool on;

			[Token(Token = "0x4006889")]
			[FieldOffset(Offset = "0x14")]
			public float attackTime;

			[Token(Token = "0x400688A")]
			[FieldOffset(Offset = "0x18")]
			public float decayTime;

			[Token(Token = "0x400688B")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5A588", Offset = "0x5A588")]
			public float sustainLevel;

			[Token(Token = "0x400688C")]
			[FieldOffset(Offset = "0x20")]
			public float sustainTime;

			[Token(Token = "0x400688D")]
			[FieldOffset(Offset = "0x24")]
			public float releaseTime;

			[Token(Token = "0x400688E")]
			[FieldOffset(Offset = "0x28")]
			public AudioEnvelopeSettings reference;

			[Token(Token = "0x6005B05")]
			[Address(RVA = "0x17C8F84", Offset = "0x17C8F84", VA = "0x17C8F84")]
			public ILO_Envelope()
			{
			}
		}

		[Token(Token = "0x200137C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48DCC", Offset = "0x48DCC")]
		private sealed class _003CSetRunningMode_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400688F")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006890")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006891")]
			[FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x4006892")]
			[FieldOffset(Offset = "0x28")]
			public IntroLoopOutro _003C_003E4__this;

			[Token(Token = "0x4006893")]
			[FieldOffset(Offset = "0x30")]
			public bool status;

			[Token(Token = "0x17000A4B")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005B09")]
				[Address(RVA = "0x17C8F34", Offset = "0x17C8F34", VA = "0x17C8F34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000A4C")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005B0B")]
				[Address(RVA = "0x17C8F7C", Offset = "0x17C8F7C", VA = "0x17C8F7C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005B06")]
			[Address(RVA = "0x17C8E44", Offset = "0x17C8E44", VA = "0x17C8E44")]
			[DebuggerHidden]
			public _003CSetRunningMode_003Ed__23(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005B07")]
			[Address(RVA = "0x17C8E70", Offset = "0x17C8E70", VA = "0x17C8E70", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005B08")]
			[Address(RVA = "0x17C8E74", Offset = "0x17C8E74", VA = "0x17C8E74", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005B09")]
			[Address(RVA = "0x17C8F34", Offset = "0x17C8F34", VA = "0x17C8F34", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005B0A")]
			[Address(RVA = "0x17C8F3C", Offset = "0x17C8F3C", VA = "0x17C8F3C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005B0B")]
			[Address(RVA = "0x17C8F7C", Offset = "0x17C8F7C", VA = "0x17C8F7C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400687C")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip intro;

		[Token(Token = "0x400687D")]
		[FieldOffset(Offset = "0x20")]
		public AudioClip loop;

		[Token(Token = "0x400687E")]
		[FieldOffset(Offset = "0x28")]
		public AudioClip outro;

		[Token(Token = "0x400687F")]
		[FieldOffset(Offset = "0x30")]
		public bool canAlwaysRestart;

		[Token(Token = "0x4006880")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ILO_Envelope introEnvelope;

		[Token(Token = "0x4006881")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ILO_Envelope loopEnvelope;

		[Token(Token = "0x4006882")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ILO_Envelope outroEnvelope;

		[Token(Token = "0x4006883")]
		[FieldOffset(Offset = "0x50")]
		private double introLength;

		[Token(Token = "0x4006884")]
		[FieldOffset(Offset = "0x58")]
		private AudioSource origSource;

		[Token(Token = "0x4006885")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource[] m_src;

		[Token(Token = "0x4006886")]
		[FieldOffset(Offset = "0x68")]
		private bool ending;

		[Token(Token = "0x4006887")]
		[FieldOffset(Offset = "0x69")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A578", Offset = "0x5A578")]
		private bool Running__BackingField;

		[Token(Token = "0x17000A49")]
		public bool Running
		{
			[Token(Token = "0x6005AF7")]
			[Address(RVA = "0x14F1F38", Offset = "0x14F1F38", VA = "0x14F1F38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72518", Offset = "0x72518")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005AF8")]
			[Address(RVA = "0x14F1F40", Offset = "0x14F1F40", VA = "0x14F1F40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72528", Offset = "0x72528")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000A4A")]
		public AudioSource OrigSource
		{
			[Token(Token = "0x6005AF9")]
			[Address(RVA = "0x14F1F48", Offset = "0x14F1F48", VA = "0x14F1F48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005AFA")]
		[Address(RVA = "0x14F1F50", Offset = "0x14F1F50", VA = "0x14F1F50")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005AFB")]
		[Address(RVA = "0x14F2724", Offset = "0x14F2724", VA = "0x14F2724")]
		private void Update()
		{
		}

		[Token(Token = "0x6005AFC")]
		[Address(RVA = "0x14F27D8", Offset = "0x14F27D8", VA = "0x14F27D8")]
		public void StartLoop()
		{
		}

		[Token(Token = "0x6005AFD")]
		[Address(RVA = "0x14F299C", Offset = "0x14F299C", VA = "0x14F299C")]
		public void EndLoop()
		{
		}

		[Token(Token = "0x6005AFE")]
		[Address(RVA = "0x14F2DEC", Offset = "0x14F2DEC", VA = "0x14F2DEC")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6005AFF")]
		[Address(RVA = "0x14F2D60", Offset = "0x14F2D60", VA = "0x14F2D60")]
		private IEnumerator SetRunningMode(bool status, float time)
		{
			return null;
		}

		[Token(Token = "0x6005B00")]
		[Address(RVA = "0x14F2B50", Offset = "0x14F2B50", VA = "0x14F2B50")]
		private void SetAudioProperties(AudioSource src)
		{
		}

		[Token(Token = "0x6005B01")]
		[Address(RVA = "0x14F2034", Offset = "0x14F2034", VA = "0x14F2034")]
		private double ReturnClipLength(AudioClip clip)
		{
			return default;
		}

		[Token(Token = "0x6005B02")]
		[Address(RVA = "0x14F2080", Offset = "0x14F2080", VA = "0x14F2080")]
		private void CreateAudioSources()
		{
		}

		[Token(Token = "0x6005B03")]
		[Address(RVA = "0x14F2E7C", Offset = "0x14F2E7C", VA = "0x14F2E7C")]
		private void SetEnvelope(AudioEnvelopeSettings settings, ILO_Envelope e)
		{
		}

		[Token(Token = "0x6005B04")]
		[Address(RVA = "0x14F2F34", Offset = "0x14F2F34", VA = "0x14F2F34")]
		public IntroLoopOutro()
		{
		}
	}
}
