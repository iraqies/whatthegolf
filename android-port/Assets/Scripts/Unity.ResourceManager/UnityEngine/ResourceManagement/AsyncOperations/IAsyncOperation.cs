using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	[Token(Token = "0x200006C")]
	internal interface IAsyncOperation
	{
		[Token(Token = "0x17000081")]
		Type ResultType
		{
			[Token(Token = "0x6000285")]
			get;
		}

		[Token(Token = "0x17000082")]
		int Version
		{
			[Token(Token = "0x6000286")]
			get;
		}

		[Token(Token = "0x17000083")]
		string DebugName
		{
			[Token(Token = "0x6000287")]
			get;
		}

		[Token(Token = "0x17000084")]
		int ReferenceCount
		{
			[Token(Token = "0x600028A")]
			get;
		}

		[Token(Token = "0x17000085")]
		float PercentComplete
		{
			[Token(Token = "0x600028B")]
			get;
		}

		[Token(Token = "0x17000086")]
		AsyncOperationStatus Status
		{
			[Token(Token = "0x600028D")]
			get;
		}

		[Token(Token = "0x17000087")]
		Exception OperationException
		{
			[Token(Token = "0x600028E")]
			get;
		}

		[Token(Token = "0x17000088")]
		bool IsDone
		{
			[Token(Token = "0x600028F")]
			get;
		}

		[Token(Token = "0x17000089")]
		Action<IAsyncOperation> OnDestroy
		{
			[Token(Token = "0x6000290")]
			set;
		}

		[Token(Token = "0x1700008A")]
		bool IsRunning
		{
			[Token(Token = "0x6000292")]
			get;
		}

		[Token(Token = "0x1700008B")]
		Task<object> Task
		{
			[Token(Token = "0x6000298")]
			get;
		}

		[Token(Token = "0x1700008C")]
		AsyncOperationHandle Handle
		{
			[Token(Token = "0x600029A")]
			get;
		}

		[Token(Token = "0x14000005")]
		event Action<AsyncOperationHandle> CompletedTypeless;

		[Token(Token = "0x14000006")]
		event Action<AsyncOperationHandle> Destroyed;

		[Token(Token = "0x6000284")]
		object GetResultAsObject();

		[Token(Token = "0x6000288")]
		void DecrementReferenceCount();

		[Token(Token = "0x6000289")]
		void IncrementReferenceCount();

		[Token(Token = "0x600028C")]
		DownloadStatus GetDownloadStatus(HashSet<object> visited);

		[Token(Token = "0x6000291")]
		void GetDependencies(List<AsyncOperationHandle> deps);

		[Token(Token = "0x6000297")]
		void InvokeCompletionEvent();

		[Token(Token = "0x6000299")]
		void Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks);

		[Token(Token = "0x600029B")]
		void WaitForCompletion();
	}
}
