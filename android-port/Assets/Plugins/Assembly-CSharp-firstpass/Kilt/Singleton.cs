using Il2CppDummyDll;

namespace Kilt
{
	[Token(Token = "0x2000084")]
	public abstract class Singleton<T> : BaseSingleton where T : BaseSingleton
	{
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x0")]
		protected static T s_instance;

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x0")]
		protected bool _keepNewInstanceIfDuplicated;

		[Token(Token = "0x17000043")]
		public static T Instance
		{
			[Token(Token = "0x600024A")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024B")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		protected virtual bool KeepNewInstanceIfDuplicated
		{
			[Token(Token = "0x600024E")]
			get
			{
				return default;
			}
			[Token(Token = "0x600024F")]
			set
			{
			}
		}

		[Token(Token = "0x600024C")]
		public static bool InstanceExists()
		{
			return default;
		}

		[Token(Token = "0x600024D")]
		public static T GetInstance(bool p_canCreateANewOne = false)
		{
			return null;
		}

		[Token(Token = "0x6000250")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000251")]
		protected virtual void CheckInstance()
		{
		}

		[Token(Token = "0x6000252")]
		protected Singleton()
		{
		}
	}
}
