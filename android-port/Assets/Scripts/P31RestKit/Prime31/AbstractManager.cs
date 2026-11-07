using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Prime31
{
	[Token(Token = "0x2000007")]
	public abstract class AbstractManager : MonoBehaviour
	{
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x0")]
		private static LifecycleHelper _prime31LifecycleHelperRef;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x8")]
		private static ThreadingCallbackHelper _threadingCallbackHelper;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x10")]
		private static GameObject _prime31GameObject;

		[Token(Token = "0x17000007")]
		public static LifecycleHelper coroutineSurrogate
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x233A470", Offset = "0x233A470", VA = "0x233A470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		public static LifecycleHelper lifecycleHelper
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x233A6B4", Offset = "0x233A6B4", VA = "0x233A6B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x233A6B8", Offset = "0x233A6B8", VA = "0x233A6B8")]
		public static ThreadingCallbackHelper getThreadingCallbackHelper()
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x233A704", Offset = "0x233A704", VA = "0x233A704")]
		public static void createThreadingCallbackHelper()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x233A54C", Offset = "0x233A54C", VA = "0x233A54C")]
		public static GameObject getPrime31ManagerGameObject()
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x233A8C0", Offset = "0x233A8C0", VA = "0x233A8C0")]
		public static void initialize(Type type)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x233ACB0", Offset = "0x233ACB0", VA = "0x233ACB0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x233AD84", Offset = "0x233AD84", VA = "0x233AD84")]
		protected AbstractManager()
		{
		}
	}
}
