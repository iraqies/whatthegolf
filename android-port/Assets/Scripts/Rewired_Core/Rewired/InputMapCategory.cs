using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[Token(Token = "0x2000102")]
	public sealed class InputMapCategory : InputCategory
	{
		[Token(Token = "0x40005FC")]
		[FieldOffset(Offset = "0x2D")]
		[SerializeField]
		private bool _checkConflictsWithAllCategories;

		[Token(Token = "0x40005FD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<int> _checkConflictsCategoryIds;

		[Token(Token = "0x40005FE")]
		[FieldOffset(Offset = "0x38")]
		private ReadOnlyCollection<int> _checkConflictsCategoryIds_readOnly;

		[Token(Token = "0x1700025F")]
		public bool checkConflictsWithAllCategories
		{
			[Token(Token = "0x6000787")]
			[Address(RVA = "0x23D6BC4", Offset = "0x23D6BC4", VA = "0x23D6BC4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000788")]
			[Address(RVA = "0x23D6BCC", Offset = "0x23D6BCC", VA = "0x23D6BCC")]
			internal set
			{
				wCSxwiqotcZMrRMttyyFfwKZNIVi(flag);
			}
		}

		[Token(Token = "0x17000260")]
		public IList<int> checkConflictsCategoryIds
		{
			[Token(Token = "0x6000789")]
			[Address(RVA = "0x23D6BD4", Offset = "0x23D6BD4", VA = "0x23D6BD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x23D6BCC", Offset = "0x23D6BCC", VA = "0x23D6BCC")]
		internal void wCSxwiqotcZMrRMttyyFfwKZNIVi(bool P_0)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x23D6BDC", Offset = "0x23D6BDC", VA = "0x23D6BDC")]
		public InputMapCategory()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x23D6C60", Offset = "0x23D6C60", VA = "0x23D6C60")]
		internal void zQQfvDZMmpVqPPLYlLuSJXXpwJcI()
		{
		}
	}
}
