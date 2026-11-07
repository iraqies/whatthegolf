using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using UnityEngine;

namespace PlayFab.Public
{
	public abstract class PlayFabLoggerBase : IPlayFabLogger
	{
		private static readonly StringBuilder Sb;

		private readonly Queue<string> LogMessageQueue;

		private Thread _writeLogThread;

		private readonly object _threadLock;

		private static readonly TimeSpan _threadKillTimeout;

		private DateTime _threadKillTime;

		private bool _isApplicationPlaying;

		private int _pendingLogsCount;

		public virtual void OnEnable()
		{
		}

		private IEnumerator RegisterLogger()
		{
			return null;
		}

		public virtual void OnDisable()
		{
		}

		public virtual void OnDestroy()
		{
		}

		protected abstract void BeginUploadLog();

		protected abstract void UploadLog(string message);

		protected abstract void EndUploadLog();

		private void HandleUnityLog(string message, string stacktrace, LogType type)
		{
		}

		private void ActivateThreadWorker()
		{
		}

		private void WriteLogThreadWorker()
		{
		}
	}
}
