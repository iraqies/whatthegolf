using System;
using Il2CppDummyDll;

namespace WwiseInteractiveMusicHierarchyData
{
	[Serializable]
	[Token(Token = "0x2000F50")]
	[AttributeAttribute(Name = "XmlTypeAttribute", RVA = "0x45B2C", Offset = "0x45B2C")]
	[AttributeAttribute(Name = "DesignerCategoryAttribute", RVA = "0x45B2C", Offset = "0x45B2C")]
	public class WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerReference
	{
		[Token(Token = "0x40052AB")]
		[FieldOffset(Offset = "0x10")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerReferenceObjectRef objectRefField;

		[Token(Token = "0x40052AC")]
		[FieldOffset(Offset = "0x18")]
		private string nameField;

		[Token(Token = "0x600477E")]
		[Address(RVA = "0x175FD10", Offset = "0x175FD10", VA = "0x175FD10")]
		public WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerReference()
		{
		}
	}
}
