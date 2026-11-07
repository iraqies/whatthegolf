using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013A2")]
	public class SetRTPCByProximity_ObjectPool : MonoBehaviour
	{
		[Token(Token = "0x4006989")]
		[FieldOffset(Offset = "0x18")]
		public float startRTPC;

		[Token(Token = "0x400698A")]
		[FieldOffset(Offset = "0x20")]
		public Transform EndTarget;

		[Token(Token = "0x400698B")]
		[FieldOffset(Offset = "0x28")]
		public float MinDistance;

		[Token(Token = "0x400698C")]
		[FieldOffset(Offset = "0x2C")]
		public float MaxDistance;

		[Token(Token = "0x400698D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject[] PoolContainer;

		[Token(Token = "0x400698E")]
		[FieldOffset(Offset = "0x38")]
		private List<IObjectPooler> poolers;

		[Token(Token = "0x400698F")]
		[FieldOffset(Offset = "0x40")]
		private float lastCheckTime;

		[Token(Token = "0x6005BAD")]
		[Address(RVA = "0x168EB24", Offset = "0x168EB24", VA = "0x168EB24")]
		private void Start()
		{
		}

		[Token(Token = "0x6005BAE")]
		[Address(RVA = "0x168EC30", Offset = "0x168EC30", VA = "0x168EC30")]
		private void Update()
		{
		}

		[Token(Token = "0x6005BAF")]
		[Address(RVA = "0x168EF40", Offset = "0x168EF40", VA = "0x168EF40")]
		public SetRTPCByProximity_ObjectPool()
		{
		}
	}
}
