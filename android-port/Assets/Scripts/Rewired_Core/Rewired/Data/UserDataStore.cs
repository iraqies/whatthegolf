using Il2CppDummyDll;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired.Data
{
	[Token(Token = "0x20001CD")]
	[Attribute(Name = "RequireComponent", RVA = "0x1915B4", Offset = "0x1915B4")]
	public abstract class UserDataStore : MonoBehaviour, IUserDataStore, IControllerMapStore
	{
		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0x243EB50", Offset = "0x243EB50", VA = "0x243EB50")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x243ECE4", Offset = "0x243ECE4", VA = "0x243ECE4")]
		internal void Initialize()
		{
		}

		[Token(Token = "0x6000DD4")]
		public abstract void Load();

		[Token(Token = "0x6000DD5")]
		public abstract void LoadControllerData(int playerId, ControllerType controllerType, int controllerId);

		[Token(Token = "0x6000DD6")]
		public abstract void LoadControllerData(ControllerType controllerType, int controllerId);

		[Token(Token = "0x6000DD7")]
		public abstract void LoadPlayerData(int playerId);

		[Token(Token = "0x6000DD8")]
		public abstract void LoadInputBehavior(int playerId, int behaviorId);

		[Token(Token = "0x6000DD9")]
		public abstract void Save();

		[Token(Token = "0x6000DDA")]
		public abstract void SaveControllerData(int playerId, ControllerType controllerType, int controllerId);

		[Token(Token = "0x6000DDB")]
		public abstract void SaveControllerData(ControllerType controllerType, int controllerId);

		[Token(Token = "0x6000DDC")]
		public abstract void SavePlayerData(int playerId);

		[Token(Token = "0x6000DDD")]
		public abstract void SaveInputBehavior(int playerId, int behaviorId);

		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0x243EE14", Offset = "0x243EE14", VA = "0x243EE14", Slot = "21")]
		public virtual void SaveControllerMap(int playerId, ControllerMap controllerMap)
		{
		}

		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0x243EE18", Offset = "0x243EE18", VA = "0x243EE18", Slot = "22")]
		public virtual ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		[Token(Token = "0x6000DE0")]
		protected abstract void OnInitialize();

		[Token(Token = "0x6000DE1")]
		protected abstract void OnControllerConnected(ControllerStatusChangedEventArgs args);

		[Token(Token = "0x6000DE2")]
		protected abstract void OnControllerDisconnected(ControllerStatusChangedEventArgs args);

		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0x243EE20", Offset = "0x243EE20", VA = "0x243EE20", Slot = "26")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x195F34", Offset = "0x195F34")]
		protected virtual void OnControllerPreDiscconnect(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x243EE24", Offset = "0x243EE24", VA = "0x243EE24", Slot = "27")]
		protected virtual void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0x243EE34", Offset = "0x243EE34", VA = "0x243EE34")]
		protected UserDataStore()
		{
		}
	}
}
