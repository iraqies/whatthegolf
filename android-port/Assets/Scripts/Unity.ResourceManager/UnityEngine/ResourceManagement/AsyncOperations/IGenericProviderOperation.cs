using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	[Token(Token = "0x2000076")]
	internal interface IGenericProviderOperation
	{
		[Token(Token = "0x170000C4")]
		int ProvideHandleVersion
		{
			[Token(Token = "0x6000344")]
			get;
		}

		[Token(Token = "0x170000C5")]
		IResourceLocation Location
		{
			[Token(Token = "0x6000345")]
			get;
		}

		[Token(Token = "0x170000C6")]
		int DependencyCount
		{
			[Token(Token = "0x6000346")]
			get;
		}

		[Token(Token = "0x170000C7")]
		Type RequestedType
		{
			[Token(Token = "0x600034B")]
			get;
		}

		[Token(Token = "0x6000342")]
		void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp);

		[Token(Token = "0x6000343")]
		void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure);

		[Token(Token = "0x6000347")]
		void GetDependencies(IList<object> dstList);

		[Token(Token = "0x6000348")]
		TDepObject GetDependency<TDepObject>(int index);

		[Token(Token = "0x6000349")]
		void SetProgressCallback(Func<float> callback);

		[Token(Token = "0x600034A")]
		void ProviderCompleted<T>(T result, bool status, Exception e);

		[Token(Token = "0x600034C")]
		void SetDownloadProgressCallback(Func<DownloadStatus> callback);

		[Token(Token = "0x600034D")]
		void SetWaitForCompletionCallback(Func<bool> callback);
	}
}
