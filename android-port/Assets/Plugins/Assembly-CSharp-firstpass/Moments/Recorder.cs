using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Il2CppDummyDll;
using Moments.Encoder;
using UnityEngine;

namespace Moments
{
	[Token(Token = "0x200027D")]
	[DisallowMultipleComponent]
	public sealed class Recorder : MonoBehaviour
	{
		[Token(Token = "0x200027E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34220", Offset = "0x34220")]
		private sealed class _003CAddMoreFrames_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001089")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400108A")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400108B")]
			[FieldOffset(Offset = "0x20")]
			public Recorder _003C_003E4__this;

			[Token(Token = "0x400108C")]
			[FieldOffset(Offset = "0x28")]
			public List<RenderTexture> newFrames;

			[Token(Token = "0x400108D")]
			[FieldOffset(Offset = "0x30")]
			private Texture2D _003Ctemp_003E5__2;

			[Token(Token = "0x400108E")]
			[FieldOffset(Offset = "0x38")]
			private List<GifFrame> _003Cframes_003E5__3;

			[Token(Token = "0x400108F")]
			[FieldOffset(Offset = "0x40")]
			private int _003Ci_003E5__4;

			[Token(Token = "0x170001F7")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600106D")]
				[Address(RVA = "0x1354C3C", Offset = "0x1354C3C", VA = "0x1354C3C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001F8")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600106F")]
				[Address(RVA = "0x1354C84", Offset = "0x1354C84", VA = "0x1354C84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600106A")]
			[Address(RVA = "0x13549B8", Offset = "0x13549B8", VA = "0x13549B8")]
			[DebuggerHidden]
			public _003CAddMoreFrames_003Ed__35(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600106B")]
			[Address(RVA = "0x13549E4", Offset = "0x13549E4", VA = "0x13549E4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600106C")]
			[Address(RVA = "0x13549E8", Offset = "0x13549E8", VA = "0x13549E8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600106D")]
			[Address(RVA = "0x1354C3C", Offset = "0x1354C3C", VA = "0x1354C3C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600106E")]
			[Address(RVA = "0x1354C44", Offset = "0x1354C44", VA = "0x1354C44", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600106F")]
			[Address(RVA = "0x1354C84", Offset = "0x1354C84", VA = "0x1354C84", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200027F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34230", Offset = "0x34230")]
		private sealed class _003CPreProcess_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001090")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001091")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001092")]
			[FieldOffset(Offset = "0x20")]
			public Recorder _003C_003E4__this;

			[Token(Token = "0x4001093")]
			[FieldOffset(Offset = "0x28")]
			public string filename;

			[Token(Token = "0x4001094")]
			[FieldOffset(Offset = "0x30")]
			private string _003Cfilepath_003E5__2;

			[Token(Token = "0x4001095")]
			[FieldOffset(Offset = "0x38")]
			private List<GifFrame> _003Cframes_003E5__3;

			[Token(Token = "0x4001096")]
			[FieldOffset(Offset = "0x40")]
			private Texture2D _003Ctemp_003E5__4;

			[Token(Token = "0x170001F9")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6001073")]
				[Address(RVA = "0x1354FDC", Offset = "0x1354FDC", VA = "0x1354FDC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001FA")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001075")]
				[Address(RVA = "0x1355024", Offset = "0x1355024", VA = "0x1355024", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001070")]
			[Address(RVA = "0x1354C8C", Offset = "0x1354C8C", VA = "0x1354C8C")]
			[DebuggerHidden]
			public _003CPreProcess_003Ed__47(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6001071")]
			[Address(RVA = "0x1354CB8", Offset = "0x1354CB8", VA = "0x1354CB8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6001072")]
			[Address(RVA = "0x1354CBC", Offset = "0x1354CBC", VA = "0x1354CBC", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001073")]
			[Address(RVA = "0x1354FDC", Offset = "0x1354FDC", VA = "0x1354FDC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001074")]
			[Address(RVA = "0x1354FE4", Offset = "0x1354FE4", VA = "0x1354FE4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6001075")]
			[Address(RVA = "0x1355024", Offset = "0x1355024", VA = "0x1355024", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4001074")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x36FE8", Offset = "0x36FE8")]
		[SerializeField]
		private int m_Width;

		[Token(Token = "0x4001075")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x37024", Offset = "0x37024")]
		private int m_Height;

		[Token(Token = "0x4001076")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_AutoAspect;

		[Token(Token = "0x4001077")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x37070", Offset = "0x37070")]
		[SerializeField]
		private int m_FramePerSecond;

		[Token(Token = "0x4001078")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x370B0", Offset = "0x370B0")]
		[SerializeField]
		private int m_Repeat;

		[Token(Token = "0x4001079")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x370EC", Offset = "0x370EC")]
		[SerializeField]
		private int m_Quality;

		[Token(Token = "0x400107A")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x37130", Offset = "0x37130")]
		[SerializeField]
		private float m_BufferSize;

		[Token(Token = "0x400107B")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x37174", Offset = "0x37174")]
		private RecorderState State__BackingField;

		[Token(Token = "0x400107C")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x37184", Offset = "0x37184")]
		private string SaveFolder__BackingField;

		[Token(Token = "0x400107D")]
		[FieldOffset(Offset = "0x40")]
		public System.Threading.ThreadPriority WorkerPriority;

		[Token(Token = "0x400107E")]
		[FieldOffset(Offset = "0x48")]
		public Action OnPreProcessingDone;

		[Token(Token = "0x400107F")]
		[FieldOffset(Offset = "0x50")]
		public Action<int, float> OnFileSaveProgress;

		[Token(Token = "0x4001080")]
		[FieldOffset(Offset = "0x58")]
		public Action<int, string> OnFileSaved;

		[Token(Token = "0x4001081")]
		[FieldOffset(Offset = "0x60")]
		public Action OnBatchCompleted;

		[Token(Token = "0x4001082")]
		[FieldOffset(Offset = "0x68")]
		private int m_MaxFrameCount;

		[Token(Token = "0x4001083")]
		[FieldOffset(Offset = "0x6C")]
		private float m_Time;

		[Token(Token = "0x4001084")]
		[FieldOffset(Offset = "0x70")]
		private float m_TimePerFrame;

		[Token(Token = "0x4001085")]
		[FieldOffset(Offset = "0x78")]
		private Queue<RenderTexture> m_Frames;

		[Token(Token = "0x4001086")]
		[FieldOffset(Offset = "0x80")]
		private RenderTexture m_RecycledRenderTexture;

		[Token(Token = "0x4001087")]
		[FieldOffset(Offset = "0x88")]
		private ReflectionUtils<Recorder> m_ReflectionUtils;

		[Token(Token = "0x4001088")]
		[FieldOffset(Offset = "0x90")]
		private Worker currentWorker;

		[Token(Token = "0x170001F4")]
		public RecorderState State
		{
			[Token(Token = "0x6001051")]
			[Address(RVA = "0x13DA300", Offset = "0x13DA300", VA = "0x13DA300")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B5CC", Offset = "0x3B5CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001052")]
			[Address(RVA = "0x13DA308", Offset = "0x13DA308", VA = "0x13DA308")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B5DC", Offset = "0x3B5DC")]
			private set
			{
			}
		}

		[Token(Token = "0x170001F5")]
		public string SaveFolder
		{
			[Token(Token = "0x6001053")]
			[Address(RVA = "0x13DA310", Offset = "0x13DA310", VA = "0x13DA310")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B5EC", Offset = "0x3B5EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001054")]
			[Address(RVA = "0x13DA318", Offset = "0x13DA318", VA = "0x13DA318")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B5FC", Offset = "0x3B5FC")]
			set
			{
			}
		}

		[Token(Token = "0x170001F6")]
		public float EstimatedMemoryUse
		{
			[Token(Token = "0x6001055")]
			[Address(RVA = "0x13DA320", Offset = "0x13DA320", VA = "0x13DA320")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001056")]
		[Address(RVA = "0x13DA354", Offset = "0x13DA354", VA = "0x13DA354")]
		public void Setup(bool autoAspect, int width, int height, int fps, float bufferSize, int repeat, int quality)
		{
		}

		[Token(Token = "0x6001057")]
		[Address(RVA = "0x13DAEB0", Offset = "0x13DAEB0", VA = "0x13DAEB0")]
		public void Pause()
		{
		}

		[Token(Token = "0x6001058")]
		[Address(RVA = "0x13DAF48", Offset = "0x13DAF48", VA = "0x13DAF48")]
		public void Record()
		{
		}

		[Token(Token = "0x6001059")]
		[Address(RVA = "0x13DAB18", Offset = "0x13DAB18", VA = "0x13DAB18")]
		public void FlushMemory()
		{
		}

		[Token(Token = "0x600105A")]
		[Address(RVA = "0x13DB048", Offset = "0x13DB048", VA = "0x13DB048")]
		public void Save()
		{
		}

		[Token(Token = "0x600105B")]
		[Address(RVA = "0x13DB130", Offset = "0x13DB130", VA = "0x13DB130")]
		public void Save(string filename)
		{
		}

		[Token(Token = "0x600105C")]
		[Address(RVA = "0x13DB310", Offset = "0x13DB310", VA = "0x13DB310")]
		public IEnumerator AddMoreFrames(List<RenderTexture> newFrames)
		{
			return null;
		}

		[Token(Token = "0x600105D")]
		[Address(RVA = "0x13DB388", Offset = "0x13DB388", VA = "0x13DB388")]
		public void EnableSave()
		{
		}

		[Token(Token = "0x600105E")]
		[Address(RVA = "0x13DB39C", Offset = "0x13DB39C", VA = "0x13DB39C")]
		public List<RenderTexture> GetFrames(bool clone = false)
		{
			return null;
		}

		[Token(Token = "0x600105F")]
		[Address(RVA = "0x13DB448", Offset = "0x13DB448", VA = "0x13DB448")]
		public void SetFrames(List<RenderTexture> frames)
		{
		}

		[Token(Token = "0x6001060")]
		[Address(RVA = "0x13DB5E0", Offset = "0x13DB5E0", VA = "0x13DB5E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6001061")]
		[Address(RVA = "0x13DB700", Offset = "0x13DB700", VA = "0x13DB700")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6001062")]
		[Address(RVA = "0x13DAE3C", Offset = "0x13DAE3C", VA = "0x13DAE3C")]
		private void Init()
		{
		}

		[Token(Token = "0x6001063")]
		[Address(RVA = "0x13DB914", Offset = "0x13DB914", VA = "0x13DB914")]
		public void ComputeHeight()
		{
		}

		[Token(Token = "0x6001064")]
		[Address(RVA = "0x13DB9FC", Offset = "0x13DB9FC", VA = "0x13DB9FC")]
		public void AbortThread()
		{
		}

		[Token(Token = "0x6001065")]
		[Address(RVA = "0x13DAFDC", Offset = "0x13DAFDC", VA = "0x13DAFDC")]
		private void Flush(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6001066")]
		[Address(RVA = "0x13DB070", Offset = "0x13DB070", VA = "0x13DB070")]
		private string GenerateFileName()
		{
			return null;
		}

		[Token(Token = "0x6001067")]
		[Address(RVA = "0x13DB298", Offset = "0x13DB298", VA = "0x13DB298")]
		private IEnumerator PreProcess(string filename)
		{
			return null;
		}

		[Token(Token = "0x6001068")]
		[Address(RVA = "0x13DBA10", Offset = "0x13DBA10", VA = "0x13DBA10")]
		private GifFrame ToGifFrame(RenderTexture source, Texture2D target)
		{
			return null;
		}

		[Token(Token = "0x6001069")]
		[Address(RVA = "0x13DBC34", Offset = "0x13DBC34", VA = "0x13DBC34")]
		public Recorder()
		{
		}
	}
}
