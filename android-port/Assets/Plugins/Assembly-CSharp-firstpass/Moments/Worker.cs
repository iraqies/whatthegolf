using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;
using Moments.Encoder;

namespace Moments
{
	[Token(Token = "0x2000281")]
	internal sealed class Worker
	{
		[Token(Token = "0x4001098")]
		[FieldOffset(Offset = "0x0")]
		private static int workerId;

		[Token(Token = "0x4001099")]
		[FieldOffset(Offset = "0x10")]
		private Thread m_Thread;

		[Token(Token = "0x400109A")]
		[FieldOffset(Offset = "0x18")]
		private int m_Id;

		[Token(Token = "0x400109B")]
		[FieldOffset(Offset = "0x1C")]
		private bool abortThread;

		[Token(Token = "0x400109C")]
		[FieldOffset(Offset = "0x20")]
		internal List<GifFrame> m_Frames;

		[Token(Token = "0x400109D")]
		[FieldOffset(Offset = "0x28")]
		internal Queue<List<GifFrame>> m_NextBatch;

		[Token(Token = "0x400109E")]
		[FieldOffset(Offset = "0x30")]
		internal GifEncoder m_Encoder;

		[Token(Token = "0x400109F")]
		[FieldOffset(Offset = "0x38")]
		internal string m_FilePath;

		[Token(Token = "0x40010A0")]
		[FieldOffset(Offset = "0x40")]
		internal Action<int, string> m_OnFileSaved;

		[Token(Token = "0x40010A1")]
		[FieldOffset(Offset = "0x48")]
		internal Action<int, float> m_OnFileSaveProgress;

		[Token(Token = "0x40010A2")]
		[FieldOffset(Offset = "0x50")]
		internal Action m_OnBatchCompleted;

		[Token(Token = "0x40010A3")]
		[FieldOffset(Offset = "0x58")]
		internal bool m_JobFinished;

		[Token(Token = "0x40010A4")]
		[FieldOffset(Offset = "0x59")]
		private bool canFinishSave;

		[Token(Token = "0x600107D")]
		[Address(RVA = "0x132D7D4", Offset = "0x132D7D4", VA = "0x132D7D4")]
		internal Worker(ThreadPriority priority)
		{
		}

		[Token(Token = "0x600107E")]
		[Address(RVA = "0x132D964", Offset = "0x132D964", VA = "0x132D964")]
		internal void Start()
		{
		}

		[Token(Token = "0x600107F")]
		[Address(RVA = "0x132D980", Offset = "0x132D980", VA = "0x132D980")]
		internal void Abort()
		{
		}

		[Token(Token = "0x6001080")]
		[Address(RVA = "0x132D98C", Offset = "0x132D98C", VA = "0x132D98C")]
		private void Run()
		{
		}

		[Token(Token = "0x6001081")]
		[Address(RVA = "0x132DBAC", Offset = "0x132DBAC", VA = "0x132DBAC")]
		public void AddNewFrames(List<GifFrame> newFrames)
		{
		}

		[Token(Token = "0x6001082")]
		[Address(RVA = "0x132DC5C", Offset = "0x132DC5C", VA = "0x132DC5C")]
		public void EnableSave()
		{
		}
	}
}
