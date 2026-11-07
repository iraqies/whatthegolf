using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace UnityEngine.AddressableAssets
{
	[Serializable]
	[Token(Token = "0x2000039")]
	public class AssetReference : IKeyEvaluator
	{
		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B1318", Offset = "0x1B1318")]
		[SerializeField]
		protected internal string m_AssetGUID;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_SubObjectName;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_SubObjectType;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperationHandle m_Operation;

		[Token(Token = "0x1700002D")]
		public AsyncOperationHandle OperationHandle
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x2A27DB4", Offset = "0x2A27DB4", VA = "0x2A27DB4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x2A27DC8", Offset = "0x2A27DC8", VA = "0x2A27DC8")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public virtual object RuntimeKey
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x2A27DDC", Offset = "0x2A27DDC", VA = "0x2A27DDC", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public virtual string AssetGUID
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x2A27E7C", Offset = "0x2A27E7C", VA = "0x2A27E7C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public virtual string SubObjectName
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x2A27E84", Offset = "0x2A27E84", VA = "0x2A27E84", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x2A27E8C", Offset = "0x2A27E8C", VA = "0x2A27E8C", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		internal virtual Type SubOjbectType
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x2A27E94", Offset = "0x2A27E94", VA = "0x2A27E94", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public bool IsDone
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x2A27F5C", Offset = "0x2A27F5C", VA = "0x2A27F5C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000033")]
		public virtual Object Asset
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x2A28030", Offset = "0x2A28030", VA = "0x2A28030", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2A27F50", Offset = "0x2A27F50", VA = "0x2A27F50")]
		public bool IsValid()
		{
			return default;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2A27F68", Offset = "0x2A27F68", VA = "0x2A27F68")]
		public AssetReference()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2A27FC8", Offset = "0x2A27FC8", VA = "0x2A27FC8")]
		public AssetReference(string guid)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2A280C8", Offset = "0x2A280C8", VA = "0x2A280C8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		private static AsyncOperationHandle<T> CreateFailedOperation<T>()
		{
			return default;
		}

		[Token(Token = "0x60001AB")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1E24", Offset = "0x1B1E24")]
		public AsyncOperationHandle<TObject> LoadAsset<TObject>()
		{
			return default;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2A28138", Offset = "0x2A28138", VA = "0x2A28138")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1E34", Offset = "0x1B1E34")]
		public AsyncOperationHandle<SceneInstance> LoadScene()
		{
			return default;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2A28154", Offset = "0x2A28154", VA = "0x2A28154")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1E44", Offset = "0x1B1E44")]
		public AsyncOperationHandle<GameObject> Instantiate(Vector3 position, Quaternion rotation, [Optional] Transform parent)
		{
			return default;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2A28164", Offset = "0x2A28164", VA = "0x2A28164")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1E54", Offset = "0x1B1E54")]
		public AsyncOperationHandle<GameObject> Instantiate([Optional] Transform parent, bool instantiateInWorldSpace = false)
		{
			return default;
		}

		[Token(Token = "0x60001AF")]
		public virtual AsyncOperationHandle<TObject> LoadAssetAsync<TObject>()
		{
			return default;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2A28174", Offset = "0x2A28174", VA = "0x2A28174", Slot = "13")]
		public virtual AsyncOperationHandle<SceneInstance> LoadSceneAsync(LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			return default;
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2A282DC", Offset = "0x2A282DC", VA = "0x2A282DC", Slot = "14")]
		public virtual AsyncOperationHandle<SceneInstance> UnLoadScene()
		{
			return default;
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2A28374", Offset = "0x2A28374", VA = "0x2A28374", Slot = "15")]
		public virtual AsyncOperationHandle<GameObject> InstantiateAsync(Vector3 position, Quaternion rotation, [Optional] Transform parent)
		{
			return default;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2A2846C", Offset = "0x2A2846C", VA = "0x2A2846C", Slot = "16")]
		public virtual AsyncOperationHandle<GameObject> InstantiateAsync([Optional] Transform parent, bool instantiateInWorldSpace = false)
		{
			return default;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2A28514", Offset = "0x2A28514", VA = "0x2A28514", Slot = "17")]
		public virtual bool RuntimeKeyIsValid()
		{
			return default;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2A285F4", Offset = "0x2A285F4", VA = "0x2A285F4", Slot = "18")]
		public virtual void ReleaseAsset()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2A286E0", Offset = "0x2A286E0", VA = "0x2A286E0", Slot = "19")]
		public virtual void ReleaseInstance(GameObject obj)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2A28748", Offset = "0x2A28748", VA = "0x2A28748", Slot = "20")]
		public virtual bool ValidateAsset(Object obj)
		{
			return default;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2A28750", Offset = "0x2A28750", VA = "0x2A28750", Slot = "21")]
		public virtual bool ValidateAsset(string path)
		{
			return default;
		}
	}
}
