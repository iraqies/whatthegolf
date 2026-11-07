using System;
using UnityEngine;

namespace Rewired.Components
{
	[Serializable]
	public abstract class ComponentWrapper<T> : MonoBehaviour where T : class
	{
		[NonSerialized]
		private T eyyVWBZaxsCJCQMmwhCWcagfYfzWA;

		[NonSerialized]
		private bool obpzIVquVRQseulcTcTZaHvizTjRA;

		protected T rmMLNGpqXVBSkkjZadentyrvdrgtA => get_source();

		protected bool jYTNgflwwEgvgbZuuTHYnPAnuRao => get_initialized();

		protected T get_source()
		{
			return null;
		}

		protected bool get_initialized()
		{
			return false;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Reset()
		{
		}

		private void OnValidate()
		{
		}

		protected virtual void OnAwake()
		{
		}

		protected virtual void OnAwakeFinished()
		{
		}

		protected virtual void OnStart()
		{
		}

		protected virtual void OnEnabled()
		{
		}

		protected virtual void OnDisabled()
		{
		}

		protected virtual void OnDestroyed()
		{
		}

		protected virtual void OnReset()
		{
		}

		protected virtual void OnValidated()
		{
		}

		protected virtual void Initialize()
		{
		}

		protected virtual bool TryInitialize()
		{
			return false;
		}

		protected abstract T CreateSource(object args);

		protected abstract object GetCreateSourceArgs();

		protected virtual void PostInitialize()
		{
		}

		protected virtual void Deinitialize()
		{
		}

		protected virtual void Subscribe()
		{
		}

		protected virtual void Unsubscribe()
		{
		}

		private void iFJDpJvSySehuvNroLXFdrVZGkIs()
		{
		}

		private void qHfIfclSXqkBQKmYDsKypGlEnSlG()
		{
		}
	}
}
