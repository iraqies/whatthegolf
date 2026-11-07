using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
	[Token(Token = "0x200132F")]
	public class ResourceManager : MonoBehaviour
	{
		[Token(Token = "0x40066A6")]
		[FieldOffset(Offset = "0x0")]
		private static ResourceManager mInstance;

		[Token(Token = "0x40066A7")]
		[FieldOffset(Offset = "0x18")]
		public List<IResourceManager_Bundles> mBundleManagers;

		[Token(Token = "0x40066A8")]
		[FieldOffset(Offset = "0x20")]
		public Object[] Assets;

		[Token(Token = "0x40066A9")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<string, Object> mResourcesCache;

		[Token(Token = "0x17000A1A")]
		public static ResourceManager pInstance
		{
			[Token(Token = "0x6005979")]
			[Address(RVA = "0x164C42C", Offset = "0x164C42C", VA = "0x164C42C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600597A")]
		[Address(RVA = "0x164C820", Offset = "0x164C820", VA = "0x164C820")]
		public static void MyOnLevelWasLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x600597B")]
		public T GetAsset<T>(string Name) where T : Object
		{
			return null;
		}

		[Token(Token = "0x600597C")]
		[Address(RVA = "0x164C930", Offset = "0x164C930", VA = "0x164C930")]
		private Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x600597D")]
		[Address(RVA = "0x164CA7C", Offset = "0x164CA7C", VA = "0x164CA7C")]
		public bool HasAsset(Object Obj)
		{
			return default;
		}

		[Token(Token = "0x600597E")]
		public T LoadFromResources<T>(string Path) where T : Object
		{
			return null;
		}

		[Token(Token = "0x600597F")]
		public T LoadFromBundle<T>(string path) where T : Object
		{
			return null;
		}

		[Token(Token = "0x6005980")]
		[Address(RVA = "0x164C8D0", Offset = "0x164C8D0", VA = "0x164C8D0")]
		public void CleanResourceCache()
		{
		}

		[Token(Token = "0x6005981")]
		[Address(RVA = "0x164CAE8", Offset = "0x164CAE8", VA = "0x164CAE8")]
		public ResourceManager()
		{
		}
	}
}
