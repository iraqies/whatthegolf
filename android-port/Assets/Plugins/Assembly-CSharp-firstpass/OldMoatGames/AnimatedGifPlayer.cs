using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace OldMoatGames
{
	public class AnimatedGifPlayer : MonoBehaviour
	{
		public delegate void OnReadyAction();

		public delegate void OnLoadErrorAction();

		public bool Loop;

		public bool AutoPlay;

		public string FileName;

		public GifPath Path;

		public bool CacheFrames;

		public bool BufferAllFrames;

		public bool UseThreadedDecoder;

		public bool OverrideTimeScale;

		public float TimeScale;

		public Texture2D GifTexture;

		[CompilerGenerated]
		private OnReadyAction m_OnReady;

		[CompilerGenerated]
		private OnLoadErrorAction m_OnLoadError;

		private GifDecoder _gifDecoder;

		private bool _hasFirstFrameBeenShown;

		[SerializeField]
		private Component _targetComponent;

		[SerializeField]
		private int _targetMaterial;

		private bool _cacheFrames;

		private bool _bufferAllFrames;

		private bool _useThreadedDecoder;

		private float _secondsTillNextFrame;

		private List<GifDecoder.GifFrame> _cachedFrames;

		private Thread _decodeThread;

		private readonly EventWaitHandle _wh;

		private bool _threadIsCanceled;

		private bool _frameIsReady;

		private readonly object _locker;

		private float _editorPreviousUpdateTime;

		private bool nextFrameInit;

		public int Width => 0;

		public int Height => 0;

		public Component TargetComponent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int TargetMaterialNumber
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public GifPlayerState State { get; private set; }

		private GifDecoder.GifFrame CurrentFrame { get; set; }

		private int CurrentFrameNumber { get; set; }

		public event OnReadyAction OnReady
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event OnLoadErrorAction OnLoadError
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		public void Update()
		{
		}

		private void OnApplicationQuit()
		{
		}

		public void Init()
		{
		}

		public void Play()
		{
		}

		public void Pause()
		{
		}

		public int GetNumberOfFrames()
		{
			return 0;
		}

		private IEnumerator Load()
		{
			return null;
		}

		private void CreateTargetTexture()
		{
		}

		private void SetTexture()
		{
		}

		private Component GetTargetComponent()
		{
			return null;
		}

		private void SetTargetTexture()
		{
		}

		private static Texture2D CreateTexture(int width, int height)
		{
			return null;
		}

		private void BufferFrames()
		{
		}

		private void AddFrameToCache(GifDecoder.GifFrame frame)
		{
		}

		private void StartDecoder()
		{
		}

		private void SetNextFrameTime()
		{
		}

		private void UpdateFrameTime()
		{
		}

		private void UpdateFrame()
		{
		}

		private void CheckFrameChange()
		{
		}

		private void UpdateTexture()
		{
		}

		private void StartReadFrame()
		{
		}

		private void StartDecodeThread()
		{
		}

		public void EndDecodeThread()
		{
		}

		private void FrameDataThread(bool loopDecoder, bool readAllFrames)
		{
		}
	}
}
