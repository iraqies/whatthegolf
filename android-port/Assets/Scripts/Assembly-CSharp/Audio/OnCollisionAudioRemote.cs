using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001369")]
	public class OnCollisionAudioRemote : OnCollisionAudioBase, ISetRigidbodyRoot
	{
		[Token(Token = "0x400680E")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private GameObject root;

		[Token(Token = "0x400680F")]
		[FieldOffset(Offset = "0x128")]
		public bool AddRemoveCollInfoOnEnableDisable;

		[Token(Token = "0x4006810")]
		[FieldOffset(Offset = "0x130")]
		private RigidbodyCollisionInfo collisionInfo;

		[Token(Token = "0x4006811")]
		[FieldOffset(Offset = "0x138")]
		private bool m_initialized;

		[Token(Token = "0x17000A3E")]
		public GameObject GetRoot
		{
			[Token(Token = "0x6005AA3")]
			[Address(RVA = "0x1598518", Offset = "0x1598518", VA = "0x1598518", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005AA4")]
		[Address(RVA = "0x1598520", Offset = "0x1598520", VA = "0x1598520", Slot = "10")]
		public void SetRoot(GameObject _root)
		{
		}

		[Token(Token = "0x6005AA5")]
		[Address(RVA = "0x1598528", Offset = "0x1598528", VA = "0x1598528")]
		private void Start()
		{
		}

		[Token(Token = "0x6005AA6")]
		[Address(RVA = "0x159852C", Offset = "0x159852C", VA = "0x159852C")]
		public void AddCollisionInfo()
		{
		}

		[Token(Token = "0x6005AA7")]
		[Address(RVA = "0x15987A8", Offset = "0x15987A8", VA = "0x15987A8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005AA8")]
		[Address(RVA = "0x1598974", Offset = "0x1598974", VA = "0x1598974")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6005AA9")]
		[Address(RVA = "0x1598B40", Offset = "0x1598B40", VA = "0x1598B40")]
		private void CollisionInfo_OnCollision(HitInfo obj)
		{
		}

		[Token(Token = "0x6005AAA")]
		[Address(RVA = "0x1598B78", Offset = "0x1598B78", VA = "0x1598B78")]
		private void CollisionInfo_OnTrigger(TriggerInfo obj)
		{
		}

		[Token(Token = "0x6005AAB")]
		[Address(RVA = "0x1598BC0", Offset = "0x1598BC0", VA = "0x1598BC0")]
		public OnCollisionAudioRemote()
		{
		}
	}
}
