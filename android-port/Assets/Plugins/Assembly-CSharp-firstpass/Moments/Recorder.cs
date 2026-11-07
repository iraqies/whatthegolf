using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Moments.Encoder;
using UnityEngine;

namespace Moments
{
	[DisallowMultipleComponent]
	public sealed class Recorder : MonoBehaviour
	{
		[SerializeField]
		private int m_Width;

		[SerializeField]
		private int m_Height;

		[SerializeField]
		private bool m_AutoAspect;

		[SerializeField]
		private int m_FramePerSecond;

		[SerializeField]
		private int m_Repeat;

		[SerializeField]
		private int m_Quality;

		[SerializeField]
		private float m_BufferSize;

		public System.Threading.ThreadPriority WorkerPriority;

		public Action OnPreProcessingDone;

		public Action<int, float> OnFileSaveProgress;

		public Action<int, string> OnFileSaved;

		public Action OnBatchCompleted;

		private int m_MaxFrameCount;

		private float m_Time;

		private float m_TimePerFrame;

		private Queue<RenderTexture> m_Frames;

		private RenderTexture m_RecycledRenderTexture;

		private ReflectionUtils<Recorder> m_ReflectionUtils;

		private Worker currentWorker;

		public RecorderState State { get; private set; }

		public string SaveFolder { get; set; }

		public float EstimatedMemoryUse => 0f;

		public void Setup(bool autoAspect, int width, int height, int fps, float bufferSize, int repeat, int quality)
		{
		}

		public void Pause()
		{
		}

		public void Record()
		{
		}

		public void FlushMemory()
		{
		}

		public void Save()
		{
		}

		public void Save(string filename)
		{
		}

		public IEnumerator AddMoreFrames(List<RenderTexture> newFrames)
		{
			return null;
		}

		public void EnableSave()
		{
		}

		public List<RenderTexture> GetFrames(bool clone = false)
		{
			return null;
		}

		public void SetFrames(List<RenderTexture> frames)
		{
		}

		private void Awake()
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		private void Init()
		{
		}

		public void ComputeHeight()
		{
		}

		public void AbortThread()
		{
		}

		private void Flush(UnityEngine.Object obj)
		{
		}

		private string GenerateFileName()
		{
			return null;
		}

		private IEnumerator PreProcess(string filename)
		{
			return null;
		}

		private GifFrame ToGifFrame(RenderTexture source, Texture2D target)
		{
			return null;
		}
	}
}
