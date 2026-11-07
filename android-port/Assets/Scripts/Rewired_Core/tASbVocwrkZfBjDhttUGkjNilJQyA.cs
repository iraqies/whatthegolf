using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000326")]
internal static class tASbVocwrkZfBjDhttUGkjNilJQyA
{
	[Token(Token = "0x2000327")]
	public delegate void EventFunction<T, TArgs>(T handler, TArgs value) where T : class;

	[Token(Token = "0x2000328")]
	public class HierarchyEventHelper<THandler, TValue> where THandler : class
	{
		[Token(Token = "0x2000329")]
		[Flags]
		public enum tUVxnnoWaOoWRrIfaQfqqnUXZiZg
		{
			[Token(Token = "0x4001076")]
			None = 0,
			[Token(Token = "0x4001077")]
			Self = 1,
			[Token(Token = "0x4001078")]
			Children = 4,
			[Token(Token = "0x4001079")]
			Parents = 8,
			[Token(Token = "0x400107A")]
			All = -1
		}

		[Token(Token = "0x4001072")]
		[FieldOffset(Offset = "0x0")]
		private readonly EventFunction<THandler, TValue> wpDPnRBsMlRCLZUTKduKGqYTSbrK;

		[Token(Token = "0x4001073")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<THandler> WoCLbEzLWrgMuhGIpMCrRygSjAUIA;

		[Token(Token = "0x4001074")]
		[FieldOffset(Offset = "0x0")]
		private readonly tUVxnnoWaOoWRrIfaQfqqnUXZiZg AjyrMtyiDIVZNpVsmEyeHDtmhWAE;

		[Token(Token = "0x6001860")]
		public HierarchyEventHelper(EventFunction<THandler, TValue> P_0)
		{
		}

		[Token(Token = "0x6001861")]
		public HierarchyEventHelper(EventFunction<THandler, TValue> P_0, tUVxnnoWaOoWRrIfaQfqqnUXZiZg P_1)
		{
		}

		[Token(Token = "0x6001862")]
		public void ExecuteOnAll(TValue value)
		{
		}

		[Token(Token = "0x6001863")]
		public void GetHandlers(Transform transform)
		{
		}
	}

	[Token(Token = "0x600185B")]
	public static void FZEUasFaGBqNtwBgjbrVhxYtMpJEA<_0001, _0002>(IList<_0001> P_0, _0002 P_1, EventFunction<_0001, _0002> P_2, bool P_3) where _0001 : class
	{
	}
}
