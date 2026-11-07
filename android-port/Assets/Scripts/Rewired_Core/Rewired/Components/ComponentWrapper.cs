using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Components
{
	[Serializable]
	[Token(Token = "0x20002C0")]
	public abstract class ComponentWrapper<T> : MonoBehaviour where T : class
	{
		[NonSerialized]
		[Token(Token = "0x4000E91")]
		[FieldOffset(Offset = "0x0")]
		private T eyyVWBZaxsCJCQMmwhCWcagfYfzWA;

		[NonSerialized]
		[Token(Token = "0x4000E92")]
		[FieldOffset(Offset = "0x0")]
		private bool obpzIVquVRQseulcTcTZaHvizTjRA;

		[Token(Token = "0x17000565")]
		protected T rmMLNGpqXVBSkkjZadentyrvdrgtA
		{
			[Token(Token = "0x60013DD")]
			get
			{
				return get_source();
			}
		}

		[Token(Token = "0x17000566")]
		protected bool jYTNgflwwEgvgbZuuTHYnPAnuRao
		{
			[Token(Token = "0x60013DE")]
			get
			{
				return get_initialized();
			}
		}

		[Token(Token = "0x60013DD")]
		protected T get_source()
		{
			return null;
		}

		[Token(Token = "0x60013DE")]
		protected bool get_initialized()
		{
			return default;
		}

		[Token(Token = "0x60013DF")]
		private void Awake()
		{
		}

		[Token(Token = "0x60013E0")]
		private void Start()
		{
		}

		[Token(Token = "0x60013E1")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60013E2")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60013E3")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60013E4")]
		private void Reset()
		{
		}

		[Token(Token = "0x60013E5")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60013E6")]
		protected virtual void OnAwake()
		{
		}

		[Token(Token = "0x60013E7")]
		protected virtual void OnAwakeFinished()
		{
		}

		[Token(Token = "0x60013E8")]
		protected virtual void OnStart()
		{
		}

		[Token(Token = "0x60013E9")]
		protected virtual void OnEnabled()
		{
		}

		[Token(Token = "0x60013EA")]
		protected virtual void OnDisabled()
		{
		}

		[Token(Token = "0x60013EB")]
		protected virtual void OnDestroyed()
		{
		}

		[Token(Token = "0x60013EC")]
		protected virtual void OnReset()
		{
		}

		[Token(Token = "0x60013ED")]
		protected virtual void OnValidated()
		{
		}

		[Token(Token = "0x60013EE")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x60013EF")]
		protected virtual bool TryInitialize()
		{
			return default;
		}

		[Token(Token = "0x60013F0")]
		protected abstract T CreateSource(object args);

		[Token(Token = "0x60013F1")]
		protected abstract object GetCreateSourceArgs();

		[Token(Token = "0x60013F2")]
		protected virtual void PostInitialize()
		{
		}

		[Token(Token = "0x60013F3")]
		protected virtual void Deinitialize()
		{
		}

		[Token(Token = "0x60013F4")]
		protected virtual void Subscribe()
		{
		}

		[Token(Token = "0x60013F5")]
		protected virtual void Unsubscribe()
		{
		}

		[Token(Token = "0x60013F6")]
		private void iFJDpJvSySehuvNroLXFdrVZGkIs()
		{
		}

		[Token(Token = "0x60013F7")]
		private void qHfIfclSXqkBQKmYDsKypGlEnSlG()
		{
		}

		[Token(Token = "0x60013F8")]
		protected ComponentWrapper()
		{
		}
	}
}
