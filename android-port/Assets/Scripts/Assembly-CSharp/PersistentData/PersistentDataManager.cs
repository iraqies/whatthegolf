using Ghost;
using Il2CppDummyDll;
using UnityEngine;

namespace PersistentData
{
	[Token(Token = "0x200102F")]
	public class PersistentDataManager : MonoBehaviour
	{
		[Token(Token = "0x4005555")]
		[FieldOffset(Offset = "0x18")]
		private PersistentStoryData _currentData;

		[Token(Token = "0x4005556")]
		[FieldOffset(Offset = "0x20")]
		private GhostManager ghostManager;

		[Token(Token = "0x170007AA")]
		public PersistentStoryData CurrentData
		{
			[Token(Token = "0x600487B")]
			[Address(RVA = "0x15DF5BC", Offset = "0x15DF5BC", VA = "0x15DF5BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600487C")]
			[Address(RVA = "0x15DF5C4", Offset = "0x15DF5C4", VA = "0x15DF5C4")]
			private set
			{
			}
		}

		[Token(Token = "0x600487D")]
		[Address(RVA = "0x15DF5CC", Offset = "0x15DF5CC", VA = "0x15DF5CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600487E")]
		[Address(RVA = "0x15DF6B8", Offset = "0x15DF6B8", VA = "0x15DF6B8")]
		private void OnStoryStart()
		{
		}

		[Token(Token = "0x600487F")]
		[Address(RVA = "0x15DFBF0", Offset = "0x15DFBF0", VA = "0x15DFBF0")]
		private void OnStoryOver(int strokes)
		{
		}

		[Token(Token = "0x6004880")]
		[Address(RVA = "0x15DFDA8", Offset = "0x15DFDA8", VA = "0x15DFDA8")]
		private void SaveDone()
		{
		}

		[Token(Token = "0x6004881")]
		[Address(RVA = "0x15DFE1C", Offset = "0x15DFE1C", VA = "0x15DFE1C")]
		public PersistentDataManager()
		{
		}
	}
}
