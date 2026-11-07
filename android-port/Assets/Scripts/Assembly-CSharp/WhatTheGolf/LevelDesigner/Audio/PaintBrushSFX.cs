using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;
using WhatTheGolf.LevelDesigner.Tools;

namespace WhatTheGolf.LevelDesigner.Audio
{
	[Token(Token = "0x20012D8")]
	public class PaintBrushSFX : MonoBehaviour, IRequireEvents<AudioEvent>, IRequireEvents
	{
		[Token(Token = "0x20012D9")]
		public class MovingAverage
		{
			[Token(Token = "0x4006590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Queue<float> samples;

			[Token(Token = "0x4006591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int windowSize;

			[Token(Token = "0x4006592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private float sampleAccumulator;

			[Token(Token = "0x4006593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59AFC", Offset = "0x59AFC")]
			private float Average__BackingField;

			[Token(Token = "0x17000A02")]
			public float Average
			{
				[Token(Token = "0x600576F")]
				[Address(RVA = "0x1822200", Offset = "0x1822200", VA = "0x1822200")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71D34", Offset = "0x71D34")]
				get
				{
					return default;
				}
				[Token(Token = "0x6005770")]
				[Address(RVA = "0x1822208", Offset = "0x1822208", VA = "0x1822208")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71D44", Offset = "0x71D44")]
				private set
				{
				}
			}

			[Token(Token = "0x6005771")]
			[Address(RVA = "0x1822210", Offset = "0x1822210", VA = "0x1822210")]
			public void ComputeAverage(float newSample, int maxWindowSize)
			{
			}

			[Token(Token = "0x6005772")]
			[Address(RVA = "0x18222F4", Offset = "0x18222F4", VA = "0x18222F4")]
			public void Clear()
			{
			}

			[Token(Token = "0x6005773")]
			[Address(RVA = "0x1822350", Offset = "0x1822350", VA = "0x1822350")]
			public MovingAverage()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20012DA")]
		public class BrushModeBehaviour
		{
			[Token(Token = "0x4006594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource AudioSource;

			[Token(Token = "0x4006595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AnimationCurve m_VolumeOverVelocity;

			[Token(Token = "0x4006596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float m_MinVolume;

			[Token(Token = "0x4006597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float m_MaxVolume;

			[Token(Token = "0x4006598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59B0C", Offset = "0x59B0C")]
			private float TargetVelocity__BackingField;

			[Token(Token = "0x4006599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59B1C", Offset = "0x59B1C")]
			private float m_VelocityGain__BackingField;

			[Token(Token = "0x400659A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59B2C", Offset = "0x59B2C")]
			private float m_FadeGain__BackingField;

			[Token(Token = "0x400659B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59B3C", Offset = "0x59B3C")]
			private Coroutine FadeCoroutine__BackingField;

			[Token(Token = "0x400659C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float velocity;

			[Token(Token = "0x17000A03")]
			public float TargetVelocity
			{
				[Token(Token = "0x6005774")]
				[Address(RVA = "0x1822038", Offset = "0x1822038", VA = "0x1822038")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71D54", Offset = "0x71D54")]
				get
				{
					return default;
				}
				[Token(Token = "0x6005775")]
				[Address(RVA = "0x1822040", Offset = "0x1822040", VA = "0x1822040")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71D64", Offset = "0x71D64")]
				set
				{
				}
			}

			[Token(Token = "0x17000A04")]
			public float m_VelocityGain
			{
				[Token(Token = "0x6005776")]
				[Address(RVA = "0x1822048", Offset = "0x1822048", VA = "0x1822048")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71D74", Offset = "0x71D74")]
				get
				{
					return default;
				}
				[Token(Token = "0x6005777")]
				[Address(RVA = "0x1822050", Offset = "0x1822050", VA = "0x1822050")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71D84", Offset = "0x71D84")]
				set
				{
				}
			}

			[Token(Token = "0x17000A05")]
			public float m_FadeGain
			{
				[Token(Token = "0x6005778")]
				[Address(RVA = "0x1822058", Offset = "0x1822058", VA = "0x1822058")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71D94", Offset = "0x71D94")]
				get
				{
					return default;
				}
				[Token(Token = "0x6005779")]
				[Address(RVA = "0x1822060", Offset = "0x1822060", VA = "0x1822060")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71DA4", Offset = "0x71DA4")]
				set
				{
				}
			}

			[Token(Token = "0x17000A06")]
			public Coroutine FadeCoroutine
			{
				[Token(Token = "0x600577A")]
				[Address(RVA = "0x1822068", Offset = "0x1822068", VA = "0x1822068")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71DB4", Offset = "0x71DB4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600577B")]
				[Address(RVA = "0x1822070", Offset = "0x1822070", VA = "0x1822070")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71DC4", Offset = "0x71DC4")]
				set
				{
				}
			}

			[Token(Token = "0x600577C")]
			[Address(RVA = "0x1822078", Offset = "0x1822078", VA = "0x1822078")]
			public void UpdateAudioSource(float minAvg, float maxAvg)
			{
			}

			[Token(Token = "0x600577D")]
			[Address(RVA = "0x18221F8", Offset = "0x18221F8", VA = "0x18221F8")]
			public BrushModeBehaviour()
			{
			}
		}

		[Token(Token = "0x20012DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48A70", Offset = "0x48A70")]
		private sealed class _003C_003Ec__DisplayClass15_0
		{
			[Token(Token = "0x400659D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BrushModeBehaviour b;

			[Token(Token = "0x600577E")]
			[Address(RVA = "0x1821E24", Offset = "0x1821E24", VA = "0x1821E24")]
			public _003C_003Ec__DisplayClass15_0()
			{
			}

			[Token(Token = "0x600577F")]
			[Address(RVA = "0x1821E2C", Offset = "0x1821E2C", VA = "0x1821E2C")]
			internal void _003COnPaintStop_003Eb__0(float v)
			{
			}

			[Token(Token = "0x6005780")]
			[Address(RVA = "0x1821E48", Offset = "0x1821E48", VA = "0x1821E48")]
			internal void _003COnPaintStop_003Eb__1()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20012DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48A80", Offset = "0x48A80")]
		private struct _003C_003Ec__DisplayClass17_0
		{
			[Token(Token = "0x400659E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool fadeIn;

			[Token(Token = "0x400659F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float targetVolume;
		}

		[Token(Token = "0x20012DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48A90", Offset = "0x48A90")]
		private sealed class _003CFadeBrush_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40065A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40065A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40065A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool fadeIn;

			[Token(Token = "0x40065A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float startVolume;

			[Token(Token = "0x40065A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float time;

			[Token(Token = "0x40065A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<float> onIncrement;

			[Token(Token = "0x40065A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass17_0 _003C_003E8__1;

			[Token(Token = "0x40065A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action onFinish;

			[Token(Token = "0x40065A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float _003CcurrentVal_003E5__2;

			[Token(Token = "0x17000A07")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005784")]
				[Address(RVA = "0x1821FE8", Offset = "0x1821FE8", VA = "0x1821FE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000A08")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005786")]
				[Address(RVA = "0x1822030", Offset = "0x1822030", VA = "0x1822030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005781")]
			[Address(RVA = "0x1821E8C", Offset = "0x1821E8C", VA = "0x1821E8C")]
			[DebuggerHidden]
			public _003CFadeBrush_003Ed__17(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005782")]
			[Address(RVA = "0x1821EB8", Offset = "0x1821EB8", VA = "0x1821EB8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005783")]
			[Address(RVA = "0x1821EBC", Offset = "0x1821EBC", VA = "0x1821EBC", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005784")]
			[Address(RVA = "0x1821FE8", Offset = "0x1821FE8", VA = "0x1821FE8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005785")]
			[Address(RVA = "0x1821FF0", Offset = "0x1821FF0", VA = "0x1821FF0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005786")]
			[Address(RVA = "0x1822030", Offset = "0x1822030", VA = "0x1822030", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MinVelocityAvg;

		[Token(Token = "0x4006588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_MaxVelocityAvg;

		[Token(Token = "0x4006589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_MovingAverageWindowSize;

		[Token(Token = "0x400658A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float deltaMultiplier;

		[Token(Token = "0x400658B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BrushModeBehaviour m_TerrainPaintBehaviour;

		[Token(Token = "0x400658C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BrushModeBehaviour m_EraseBehaviour;

		[Token(Token = "0x400658D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_VelocityAverage;

		[Token(Token = "0x400658E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PaintTerrainTool m_Tool;

		[Token(Token = "0x400658F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private MovingAverage m_BrushMovingAverage;

		[Token(Token = "0x6005766")]
		[Address(RVA = "0x15D52DC", Offset = "0x15D52DC", VA = "0x15D52DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005767")]
		[Address(RVA = "0x15D5378", Offset = "0x15D5378", VA = "0x15D5378")]
		private void OnPaintStart(bool isErasing)
		{
		}

		[Token(Token = "0x6005768")]
		[Address(RVA = "0x15D545C", Offset = "0x15D545C", VA = "0x15D545C")]
		private void OnPaintUpdate(bool isErasing, float delta)
		{
		}

		[Token(Token = "0x6005769")]
		[Address(RVA = "0x15D555C", Offset = "0x15D555C", VA = "0x15D555C")]
		private void OnPaintStop(bool isErasing)
		{
		}

		[Token(Token = "0x600576A")]
		[Address(RVA = "0x15D5818", Offset = "0x15D5818", VA = "0x15D5818")]
		private void Update()
		{
		}

		[Token(Token = "0x600576B")]
		[Address(RVA = "0x15D5778", Offset = "0x15D5778", VA = "0x15D5778")]
		private IEnumerator FadeBrush(float startVolume, Action<float> onIncrement, bool fadeIn, float time, Action onFinish)
		{
			return null;
		}

		[Token(Token = "0x600576C")]
		[Address(RVA = "0x15D585C", Offset = "0x15D585C", VA = "0x15D585C", Slot = "4")]
		public void OnEvent(AudioEvent evt)
		{
		}

		[Token(Token = "0x600576D")]
		[Address(RVA = "0x15D59F0", Offset = "0x15D59F0", VA = "0x15D59F0")]
		public PaintBrushSFX()
		{
		}

		[Token(Token = "0x600576E")]
		[Address(RVA = "0x15D5A08", Offset = "0x15D5A08", VA = "0x15D5A08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71D24", Offset = "0x71D24")]
		internal static bool _003CFadeBrush_003Eg__atTarget_007C17_0(float v, ref _003C_003Ec__DisplayClass17_0 P_1)
		{
			return default;
		}
	}
}
