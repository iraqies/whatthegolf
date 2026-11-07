using System;
using System.Collections.Generic;
using System.Threading;
using Moments.Encoder;

namespace Moments
{
	internal sealed class Worker
	{
		private static int workerId;

		private Thread m_Thread;

		private int m_Id;

		private bool abortThread;

		internal List<GifFrame> m_Frames;

		internal Queue<List<GifFrame>> m_NextBatch;

		internal GifEncoder m_Encoder;

		internal string m_FilePath;

		internal Action<int, string> m_OnFileSaved;

		internal Action<int, float> m_OnFileSaveProgress;

		internal Action m_OnBatchCompleted;

		internal bool m_JobFinished;

		private bool canFinishSave;

		internal Worker(ThreadPriority priority)
		{
		}

		internal void Start()
		{
		}

		internal void Abort()
		{
		}

		private void Run()
		{
		}

		public void AddNewFrames(List<GifFrame> newFrames)
		{
		}

		public void EnableSave()
		{
		}
	}
}
