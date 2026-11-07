using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Utility
{
	[Token(Token = "0x2001024")]
	public class ObjectPool<T> : IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x400551F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<GameObject> avalable;

		[Token(Token = "0x4005520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55460", Offset = "0x55460")]
		private List<GameObject> inUse__BackingField;

		[Token(Token = "0x4005521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<GameObject> prefabs;

		[Token(Token = "0x4005522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform poolTransform;

		[Token(Token = "0x17000794")]
		public List<GameObject> inUse
		{
			[Token(Token = "0x6004825")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EEA4", Offset = "0x6EEA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004826")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EEB4", Offset = "0x6EEB4")]
			private set
			{
			}
		}

		[Token(Token = "0x6004827")]
		public ObjectPool(GameObject prefab, [Optional][DefaultParameterValue(0)] int size, [Optional] Action<GameObject> doOnObject)
		{
		}

		[Token(Token = "0x6004828")]
		public void SetPoolTransformParent(Transform parent)
		{
		}

		[Token(Token = "0x6004829")]
		public ObjectPool(List<GameObject> prefabs, [Optional][DefaultParameterValue(0)] int size, [Optional] Action<GameObject> doOnObject)
		{
		}

		[Token(Token = "0x600482A")]
		public GameObject Retrieve([Optional] Vector3 position, [Optional] Quaternion rotation, [Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600482B")]
		public void Release(GameObject obj, bool setParentToPool = true)
		{
		}

		[Token(Token = "0x600482C")]
		public void ReleaseAll()
		{
		}

		[Token(Token = "0x600482D")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600482E")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}
}
