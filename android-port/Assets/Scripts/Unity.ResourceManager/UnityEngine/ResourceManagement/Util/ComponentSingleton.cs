using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.Util
{
	[Token(Token = "0x2000028")]
	[ExecuteInEditMode]
	public abstract class ComponentSingleton<T> : MonoBehaviour where T : ComponentSingleton<T>
	{
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x0")]
		private static T s_Instance;

		[Token(Token = "0x17000026")]
		public static bool Exists
		{
			[Token(Token = "0x6000108")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000027")]
		public static T Instance
		{
			[Token(Token = "0x6000109")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010A")]
		private static T FindInstance()
		{
			return null;
		}

		[Token(Token = "0x600010B")]
		protected virtual string GetGameObjectName()
		{
			return null;
		}

		[Token(Token = "0x600010C")]
		private static T CreateNewSingleton()
		{
			return null;
		}

		[Token(Token = "0x600010D")]
		private void Awake()
		{
		}

		[Token(Token = "0x600010E")]
		public static void DestroySingleton()
		{
		}

		[Token(Token = "0x600010F")]
		protected ComponentSingleton()
		{
		}
	}
}
