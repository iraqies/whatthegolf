using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Token(Token = "0x2000056")]
	public class InstanceProvider : IInstanceProvider
	{
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<GameObject, AsyncOperationHandle<GameObject>> m_InstanceObjectToPrefabHandle;

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2A682D0", Offset = "0x2A682D0", VA = "0x2A682D0", Slot = "4")]
		public GameObject ProvideInstance(ResourceManager resourceManager, AsyncOperationHandle<GameObject> prefabHandle, InstantiationParameters instantiateParameters)
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2A683A4", Offset = "0x2A683A4", VA = "0x2A683A4", Slot = "5")]
		public void ReleaseInstance(ResourceManager resourceManager, GameObject instance)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2A685EC", Offset = "0x2A685EC", VA = "0x2A685EC")]
		public InstanceProvider()
		{
		}
	}
}
