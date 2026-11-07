using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200136A")]
	public class OnCollisionAudioRemoteMany : OnCollisionAudioBase
	{
		[Token(Token = "0x4006812")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private GameObject[] roots;

		[Token(Token = "0x4006813")]
		[FieldOffset(Offset = "0x128")]
		private RigidbodyCollisionInfo[] collisionInfos;

		[Token(Token = "0x17000A3F")]
		public GameObject[] GetRoots
		{
			[Token(Token = "0x6005AAC")]
			[Address(RVA = "0x1598C40", Offset = "0x1598C40", VA = "0x1598C40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005AAD")]
		[Address(RVA = "0x1598C48", Offset = "0x1598C48", VA = "0x1598C48")]
		private void Start()
		{
		}

		[Token(Token = "0x6005AAE")]
		[Address(RVA = "0x1598C4C", Offset = "0x1598C4C", VA = "0x1598C4C")]
		public void AddCollisionInfo()
		{
		}

		[Token(Token = "0x6005AAF")]
		[Address(RVA = "0x1599024", Offset = "0x1599024", VA = "0x1599024")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6005AB0")]
		[Address(RVA = "0x1599314", Offset = "0x1599314", VA = "0x1599314")]
		private void CollisionInfo_OnCollision(HitInfo obj)
		{
		}

		[Token(Token = "0x6005AB1")]
		[Address(RVA = "0x159934C", Offset = "0x159934C", VA = "0x159934C")]
		private void CollisionInfo_OnTrigger(TriggerInfo obj)
		{
		}

		[Token(Token = "0x6005AB2")]
		[Address(RVA = "0x1599394", Offset = "0x1599394", VA = "0x1599394")]
		public OnCollisionAudioRemoteMany()
		{
		}
	}
}
