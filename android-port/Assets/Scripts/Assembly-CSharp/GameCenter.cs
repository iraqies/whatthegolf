using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Apple.GameKit.Players;
using Il2CppDummyDll;

[Token(Token = "0x2000C9B")]
internal static class GameCenter
{
	[Token(Token = "0x2000C9C")]
	private class AchievementCompleteRequest
	{
		[Token(Token = "0x40044D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x40044D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string userId;

		[Token(Token = "0x40044D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float progress;

		[Token(Token = "0x40044D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<bool, float> onCompleted;

		[Token(Token = "0x6003BB0")]
		[Address(RVA = "0x17ACFF8", Offset = "0x17ACFF8", VA = "0x17ACFF8")]
		public AchievementCompleteRequest()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000C9D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44288", Offset = "0x44288")]
	private struct _003CProcessAchievementCompleteRequestQueue_003Ed__5 : IAsyncStateMachine
	{
		[Token(Token = "0x40044D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40044D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40044D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool firstFinished;

		[Token(Token = "0x40044DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AchievementCompleteRequest _003Cr_003E5__2;

		[Token(Token = "0x40044DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _003CshouldRequest_003E5__3;

		[Token(Token = "0x40044DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6003BB1")]
		[Address(RVA = "0x17AC678", Offset = "0x17AC678", VA = "0x17AC678", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003BB2")]
		[Address(RVA = "0x17ACC7C", Offset = "0x17ACC7C", VA = "0x17ACC7C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000C9E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44298", Offset = "0x44298")]
	private struct _003CResetAchievements_003Ed__8 : IAsyncStateMachine
	{
		[Token(Token = "0x40044DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40044DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40044DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<GKAuthenticateResponse> _003C_003Eu__1;

		[Token(Token = "0x40044E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__2;

		[Token(Token = "0x6003BB3")]
		[Address(RVA = "0x17ACC88", Offset = "0x17ACC88", VA = "0x17ACC88", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003BB4")]
		[Address(RVA = "0x17ACFEC", Offset = "0x17ACFEC", VA = "0x17ACFEC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40044D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static RequestQueue<AchievementCompleteRequest> _achivementCompleteRequestQueue;

	[Token(Token = "0x6003BA7")]
	[Address(RVA = "0x147C510", Offset = "0x147C510", VA = "0x147C510")]
	public static bool IsValidUserID(string userid)
	{
		return default;
	}

	[Token(Token = "0x6003BA8")]
	[Address(RVA = "0x147C5CC", Offset = "0x147C5CC", VA = "0x147C5CC")]
	private static void ProcessAchievementCompleteRequestQueue(bool firstFinished)
	{
	}

	[Token(Token = "0x6003BA9")]
	[Address(RVA = "0x147C668", Offset = "0x147C668", VA = "0x147C668")]
	private static void ReportAchievement_Failed(string error)
	{
	}

	[Token(Token = "0x6003BAA")]
	[Address(RVA = "0x147C844", Offset = "0x147C844", VA = "0x147C844")]
	private static void ReportAchievement_Finished(string s)
	{
	}

	[Token(Token = "0x6003BAB")]
	[Address(RVA = "0x147CA5C", Offset = "0x147CA5C", VA = "0x147CA5C")]
	public static void ResetAchievements()
	{
	}

	[Token(Token = "0x6003BAC")]
	[Address(RVA = "0x147CAE8", Offset = "0x147CAE8", VA = "0x147CAE8")]
	public static bool IsPlayerAuthenticated()
	{
		return default;
	}

	[Token(Token = "0x6003BAD")]
	[Address(RVA = "0x147CB10", Offset = "0x147CB10", VA = "0x147CB10")]
	public static void UnlockAchievement(string id)
	{
	}

	[Token(Token = "0x6003BAE")]
	[Address(RVA = "0x147CB94", Offset = "0x147CB94", VA = "0x147CB94")]
	public static void UpdateAchievement(string id, [Optional][DefaultParameterValue(100f)] float progress, [Optional] Action<bool, float> OnCompleted)
	{
	}
}
