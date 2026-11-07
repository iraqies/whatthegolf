using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

namespace OldMoatGames
{
	[Token(Token = "0x20002EC")]
	public class AnimatedGifPlayer : MonoBehaviour
	{
		[Token(Token = "0x20002ED")]
		public delegate void OnReadyAction();

		[Token(Token = "0x20002EE")]
		public delegate void OnLoadErrorAction();

		[Token(Token = "0x20002EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34470", Offset = "0x34470")]
		private sealed class _003CLoad_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001297")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001298")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001299")]
			[FieldOffset(Offset = "0x20")]
			public AnimatedGifPlayer _003C_003E4__this;

			[Token(Token = "0x400129A")]
			[FieldOffset(Offset = "0x28")]
			private WWW _003Cwww_003E5__2;

			[Token(Token = "0x17000291")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6001371")]
				[Address(RVA = "0x13321C8", Offset = "0x13321C8", VA = "0x13321C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000292")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001373")]
				[Address(RVA = "0x1332210", Offset = "0x1332210", VA = "0x1332210", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600136D")]
			[Address(RVA = "0x1331728", Offset = "0x1331728", VA = "0x1331728")]
			[DebuggerHidden]
			public _003CLoad_003Ed__63(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600136E")]
			[Address(RVA = "0x1331754", Offset = "0x1331754", VA = "0x1331754", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600136F")]
			[Address(RVA = "0x13318F4", Offset = "0x13318F4", VA = "0x13318F4", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001370")]
			[Address(RVA = "0x1331830", Offset = "0x1331830", VA = "0x1331830")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6001371")]
			[Address(RVA = "0x13321C8", Offset = "0x13321C8", VA = "0x13321C8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001372")]
			[Address(RVA = "0x13321D0", Offset = "0x13321D0", VA = "0x13321D0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6001373")]
			[Address(RVA = "0x1332210", Offset = "0x1332210", VA = "0x1332210", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20002F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34480", Offset = "0x34480")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400129B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400129C")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Component, bool> _003C_003E9__66_0;

			[Token(Token = "0x6001375")]
			[Address(RVA = "0x1331658", Offset = "0x1331658", VA = "0x1331658")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6001376")]
			[Address(RVA = "0x1331660", Offset = "0x1331660", VA = "0x1331660")]
			internal bool _003CGetTargetComponent_003Eb__66_0(Component component)
			{
				return default;
			}
		}

		[Token(Token = "0x4001278")]
		[FieldOffset(Offset = "0x18")]
		public bool Loop;

		[Token(Token = "0x4001279")]
		[FieldOffset(Offset = "0x19")]
		public bool AutoPlay;

		[Token(Token = "0x400127A")]
		[FieldOffset(Offset = "0x20")]
		public string FileName;

		[Token(Token = "0x400127B")]
		[FieldOffset(Offset = "0x28")]
		public GifPath Path;

		[Token(Token = "0x400127C")]
		[FieldOffset(Offset = "0x2C")]
		public bool CacheFrames;

		[Token(Token = "0x400127D")]
		[FieldOffset(Offset = "0x2D")]
		public bool BufferAllFrames;

		[Token(Token = "0x400127E")]
		[FieldOffset(Offset = "0x2E")]
		public bool UseThreadedDecoder;

		[Token(Token = "0x400127F")]
		[FieldOffset(Offset = "0x2F")]
		public bool OverrideTimeScale;

		[Token(Token = "0x4001280")]
		[FieldOffset(Offset = "0x30")]
		public float TimeScale;

		[Token(Token = "0x4001281")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x37620", Offset = "0x37620")]
		private GifPlayerState State__BackingField;

		[Token(Token = "0x4001282")]
		[FieldOffset(Offset = "0x38")]
		public Texture2D GifTexture;

		[Token(Token = "0x4001283")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x37630", Offset = "0x37630")]
		private OnReadyAction m_OnReady;

		[Token(Token = "0x4001284")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x37640", Offset = "0x37640")]
		private OnLoadErrorAction m_OnLoadError;

		[Token(Token = "0x4001285")]
		[FieldOffset(Offset = "0x50")]
		private GifDecoder _gifDecoder;

		[Token(Token = "0x4001286")]
		[FieldOffset(Offset = "0x58")]
		private bool _hasFirstFrameBeenShown;

		[Token(Token = "0x4001287")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Component _targetComponent;

		[Token(Token = "0x4001288")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int _targetMaterial;

		[Token(Token = "0x4001289")]
		[FieldOffset(Offset = "0x6C")]
		private bool _cacheFrames;

		[Token(Token = "0x400128A")]
		[FieldOffset(Offset = "0x6D")]
		private bool _bufferAllFrames;

		[Token(Token = "0x400128B")]
		[FieldOffset(Offset = "0x6E")]
		private bool _useThreadedDecoder;

		[Token(Token = "0x400128C")]
		[FieldOffset(Offset = "0x70")]
		private float _secondsTillNextFrame;

		[Token(Token = "0x400128D")]
		[FieldOffset(Offset = "0x78")]
		private List<GifDecoder.GifFrame> _cachedFrames;

		[Token(Token = "0x400128E")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x37670", Offset = "0x37670")]
		private GifDecoder.GifFrame CurrentFrame__BackingField;

		[Token(Token = "0x400128F")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x37680", Offset = "0x37680")]
		private int CurrentFrameNumber__BackingField;

		[Token(Token = "0x4001290")]
		[FieldOffset(Offset = "0x90")]
		private Thread _decodeThread;

		[Token(Token = "0x4001291")]
		[FieldOffset(Offset = "0x98")]
		private readonly EventWaitHandle _wh;

		[Token(Token = "0x4001292")]
		[FieldOffset(Offset = "0xA0")]
		private bool _threadIsCanceled;

		[Token(Token = "0x4001293")]
		[FieldOffset(Offset = "0xA1")]
		private bool _frameIsReady;

		[Token(Token = "0x4001294")]
		[FieldOffset(Offset = "0xA8")]
		private readonly object _locker;

		[Token(Token = "0x4001295")]
		[FieldOffset(Offset = "0xB0")]
		private float _editorPreviousUpdateTime;

		[Token(Token = "0x4001296")]
		[FieldOffset(Offset = "0xB4")]
		private bool nextFrameInit;

		[Token(Token = "0x1700028A")]
		public int Width
		{
			[Token(Token = "0x600133A")]
			[Address(RVA = "0x12EBCA0", Offset = "0x12EBCA0", VA = "0x12EBCA0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700028B")]
		public int Height
		{
			[Token(Token = "0x600133B")]
			[Address(RVA = "0x12EBCB8", Offset = "0x12EBCB8", VA = "0x12EBCB8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700028C")]
		public Component TargetComponent
		{
			[Token(Token = "0x600133C")]
			[Address(RVA = "0x12EBCD0", Offset = "0x12EBCD0", VA = "0x12EBCD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600133D")]
			[Address(RVA = "0x12EBCD8", Offset = "0x12EBCD8", VA = "0x12EBCD8")]
			set
			{
			}
		}

		[Token(Token = "0x1700028D")]
		public int TargetMaterialNumber
		{
			[Token(Token = "0x600133E")]
			[Address(RVA = "0x12EBCE0", Offset = "0x12EBCE0", VA = "0x12EBCE0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600133F")]
			[Address(RVA = "0x12EBCE8", Offset = "0x12EBCE8", VA = "0x12EBCE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700028E")]
		public GifPlayerState State
		{
			[Token(Token = "0x6001340")]
			[Address(RVA = "0x12EBCF0", Offset = "0x12EBCF0", VA = "0x12EBCF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3C000", Offset = "0x3C000")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001341")]
			[Address(RVA = "0x12EBCF8", Offset = "0x12EBCF8", VA = "0x12EBCF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3C010", Offset = "0x3C010")]
			private set
			{
			}
		}

		[Token(Token = "0x1700028F")]
		private GifDecoder.GifFrame CurrentFrame
		{
			[Token(Token = "0x6001346")]
			[Address(RVA = "0x12EBF90", Offset = "0x12EBF90", VA = "0x12EBF90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3C060", Offset = "0x3C060")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001347")]
			[Address(RVA = "0x12EBF98", Offset = "0x12EBF98", VA = "0x12EBF98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3C070", Offset = "0x3C070")]
			set
			{
			}
		}

		[Token(Token = "0x17000290")]
		private int CurrentFrameNumber
		{
			[Token(Token = "0x6001348")]
			[Address(RVA = "0x12EBFA0", Offset = "0x12EBFA0", VA = "0x12EBFA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3C080", Offset = "0x3C080")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001349")]
			[Address(RVA = "0x12EBFA8", Offset = "0x12EBFA8", VA = "0x12EBFA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3C090", Offset = "0x3C090")]
			set
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event OnReadyAction OnReady
		{
			[Token(Token = "0x6001342")]
			[Address(RVA = "0x12EBD00", Offset = "0x12EBD00", VA = "0x12EBD00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3C020", Offset = "0x3C020")]
			add
			{
			}
			[Token(Token = "0x6001343")]
			[Address(RVA = "0x12EBDA4", Offset = "0x12EBDA4", VA = "0x12EBDA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3C030", Offset = "0x3C030")]
			remove
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event OnLoadErrorAction OnLoadError
		{
			[Token(Token = "0x6001344")]
			[Address(RVA = "0x12EBE48", Offset = "0x12EBE48", VA = "0x12EBE48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3C040", Offset = "0x3C040")]
			add
			{
			}
			[Token(Token = "0x6001345")]
			[Address(RVA = "0x12EBEEC", Offset = "0x12EBEEC", VA = "0x12EBEEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3C050", Offset = "0x3C050")]
			remove
			{
			}
		}

		[Token(Token = "0x600134A")]
		[Address(RVA = "0x12EBFB0", Offset = "0x12EBFB0", VA = "0x12EBFB0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600134B")]
		[Address(RVA = "0x12EC138", Offset = "0x12EC138", VA = "0x12EC138")]
		public void Update()
		{
		}

		[Token(Token = "0x600134C")]
		[Address(RVA = "0x12EC334", Offset = "0x12EC334", VA = "0x12EC334")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600134D")]
		[Address(RVA = "0x12EBFC0", Offset = "0x12EBFC0", VA = "0x12EBFC0")]
		public void Init()
		{
		}

		[Token(Token = "0x600134E")]
		[Address(RVA = "0x12EC6C8", Offset = "0x12EC6C8", VA = "0x12EC6C8")]
		public void Play()
		{
		}

		[Token(Token = "0x600134F")]
		[Address(RVA = "0x12EC7D0", Offset = "0x12EC7D0", VA = "0x12EC7D0")]
		public void Pause()
		{
		}

		[Token(Token = "0x6001350")]
		[Address(RVA = "0x12EC8D8", Offset = "0x12EC8D8", VA = "0x12EC8D8")]
		public int GetNumberOfFrames()
		{
			return default;
		}

		[Token(Token = "0x6001351")]
		[Address(RVA = "0x12EC654", Offset = "0x12EC654", VA = "0x12EC654")]
		private IEnumerator Load()
		{
			return null;
		}

		[Token(Token = "0x6001352")]
		[Address(RVA = "0x12EC8F0", Offset = "0x12EC8F0", VA = "0x12EC8F0")]
		private void CreateTargetTexture()
		{
		}

		[Token(Token = "0x6001353")]
		[Address(RVA = "0x12ECAE4", Offset = "0x12ECAE4", VA = "0x12ECAE4")]
		private void SetTexture()
		{
		}

		[Token(Token = "0x6001354")]
		[Address(RVA = "0x12EC394", Offset = "0x12EC394", VA = "0x12EC394")]
		private Component GetTargetComponent()
		{
			return null;
		}

		[Token(Token = "0x6001355")]
		[Address(RVA = "0x12ECE04", Offset = "0x12ECE04", VA = "0x12ECE04")]
		private void SetTargetTexture()
		{
		}

		[Token(Token = "0x6001356")]
		[Address(RVA = "0x12ECA6C", Offset = "0x12ECA6C", VA = "0x12ECA6C")]
		private static Texture2D CreateTexture(int width, int height)
		{
			return null;
		}

		[Token(Token = "0x6001357")]
		[Address(RVA = "0x12ED240", Offset = "0x12ED240", VA = "0x12ED240")]
		private void BufferFrames()
		{
		}

		[Token(Token = "0x6001358")]
		[Address(RVA = "0x12ED3A0", Offset = "0x12ED3A0", VA = "0x12ED3A0")]
		private void AddFrameToCache(GifDecoder.GifFrame frame)
		{
		}

		[Token(Token = "0x6001359")]
		[Address(RVA = "0x12ED50C", Offset = "0x12ED50C", VA = "0x12ED50C")]
		private void StartDecoder()
		{
		}

		[Token(Token = "0x600135A")]
		[Address(RVA = "0x12ED61C", Offset = "0x12ED61C", VA = "0x12ED61C")]
		private void SetNextFrameTime()
		{
		}

		[Token(Token = "0x600135B")]
		[Address(RVA = "0x12ED63C", Offset = "0x12ED63C", VA = "0x12ED63C")]
		private void UpdateFrameTime()
		{
		}

		[Token(Token = "0x600135C")]
		[Address(RVA = "0x12ED6E0", Offset = "0x12ED6E0", VA = "0x12ED6E0")]
		private void UpdateFrame()
		{
		}

		[Token(Token = "0x600135D")]
		[Address(RVA = "0x12EC16C", Offset = "0x12EC16C", VA = "0x12EC16C")]
		private void CheckFrameChange()
		{
		}

		[Token(Token = "0x600135E")]
		[Address(RVA = "0x12ED920", Offset = "0x12ED920", VA = "0x12ED920")]
		private void UpdateTexture()
		{
		}

		[Token(Token = "0x600135F")]
		[Address(RVA = "0x12ED574", Offset = "0x12ED574", VA = "0x12ED574")]
		private void StartReadFrame()
		{
		}

		[Token(Token = "0x6001360")]
		[Address(RVA = "0x12EC4FC", Offset = "0x12EC4FC", VA = "0x12EC4FC")]
		private void StartDecodeThread()
		{
		}

		[Token(Token = "0x6001361")]
		[Address(RVA = "0x12EC364", Offset = "0x12EC364", VA = "0x12EC364")]
		public void EndDecodeThread()
		{
		}

		[Token(Token = "0x6001362")]
		[Address(RVA = "0x12ED968", Offset = "0x12ED968", VA = "0x12ED968")]
		private void FrameDataThread(bool loopDecoder, bool readAllFrames)
		{
		}

		[Token(Token = "0x6001363")]
		[Address(RVA = "0x12EDB80", Offset = "0x12EDB80", VA = "0x12EDB80")]
		public AnimatedGifPlayer()
		{
		}

		[Token(Token = "0x6001364")]
		[Address(RVA = "0x12EDC58", Offset = "0x12EDC58", VA = "0x12EDC58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3C0A0", Offset = "0x3C0A0")]
		private void _003CStartDecodeThread_003Eb__78_0()
		{
		}
	}
}
