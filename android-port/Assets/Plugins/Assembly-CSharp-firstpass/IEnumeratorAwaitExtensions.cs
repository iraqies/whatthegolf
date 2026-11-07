using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class IEnumeratorAwaitExtensions
{
	public class SimpleCoroutineAwaiter<T> : INotifyCompletion
	{
		private bool _isDone;

		private Exception _exception;

		private Action _continuation;

		private T _result;

		public bool IsCompleted => false;

		public T GetResult()
		{
			return default;
		}

		public void Complete(T result, Exception e)
		{
		}

		void INotifyCompletion.OnCompleted(Action continuation)
		{
		}
	}

	public class SimpleCoroutineAwaiter : INotifyCompletion
	{
		private bool _isDone;

		private Exception _exception;

		private Action _continuation;

		public bool IsCompleted => false;

		public void GetResult()
		{
		}

		public void Complete(Exception e)
		{
		}

		void INotifyCompletion.OnCompleted(Action continuation)
		{
		}
	}

	private class CoroutineWrapper<T>
	{
		private readonly SimpleCoroutineAwaiter<T> _awaiter;

		private readonly Stack<IEnumerator> _processStack;

		public CoroutineWrapper(IEnumerator coroutine, SimpleCoroutineAwaiter<T> awaiter)
		{
		}

		public IEnumerator Run()
		{
			return null;
		}

		private string GenerateObjectTraceMessage(List<Type> objTrace)
		{
			return null;
		}

		private static List<Type> GenerateObjectTrace(IEnumerable<IEnumerator> enumerators)
		{
			return null;
		}
	}

	private static class InstructionWrappers
	{
		public static IEnumerator ReturnVoid(SimpleCoroutineAwaiter awaiter, object instruction)
		{
			return null;
		}

		public static IEnumerator AssetBundleCreateRequest(SimpleCoroutineAwaiter<AssetBundle> awaiter, AssetBundleCreateRequest instruction)
		{
			return null;
		}

		public static IEnumerator ReturnSelf<T>(SimpleCoroutineAwaiter<T> awaiter, T instruction)
		{
			return null;
		}

		public static IEnumerator AssetBundleRequest(SimpleCoroutineAwaiter<UnityEngine.Object> awaiter, AssetBundleRequest instruction)
		{
			return null;
		}
	}

	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForSeconds instruction)
	{
		return null;
	}

	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForUpdate instruction)
	{
		return null;
	}

	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForEndOfFrame instruction)
	{
		return null;
	}

	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForSecondsRealtime instruction)
	{
		return null;
	}

	public static SimpleCoroutineAwaiter<AsyncOperation> GetAwaiter(this AsyncOperation instruction)
	{
		return null;
	}

	public static SimpleCoroutineAwaiter<WWW> GetAwaiter(this WWW instruction)
	{
		return null;
	}

	public static SimpleCoroutineAwaiter<AssetBundle> GetAwaiter(this AssetBundleCreateRequest instruction)
	{
		return null;
	}

	public static SimpleCoroutineAwaiter<UnityEngine.Object> GetAwaiter(this AssetBundleRequest instruction)
	{
		return null;
	}

	public static SimpleCoroutineAwaiter<T> GetAwaiter<T>(this IEnumerator<T> coroutine)
	{
		return null;
	}

	public static SimpleCoroutineAwaiter<object> GetAwaiter(this IEnumerator coroutine)
	{
		return null;
	}

	private static SimpleCoroutineAwaiter GetAwaiterReturnVoid(object instruction)
	{
		return null;
	}

	private static SimpleCoroutineAwaiter<T> GetAwaiterReturnSelf<T>(T instruction)
	{
		return null;
	}

	private static void RunOnUnityScheduler(Action action)
	{
	}

	private static void Assert(bool condition)
	{
	}
}
