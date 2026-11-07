using System;
using Il2CppDummyDll;

namespace WwiseInteractiveMusicHierarchyData
{
	[Serializable]
	[Token(Token = "0x2000F53")]
	[AttributeAttribute(Name = "DesignerCategoryAttribute", RVA = "0x45C3C", Offset = "0x45C3C")]
	[AttributeAttribute(Name = "XmlTypeAttribute", RVA = "0x45C3C", Offset = "0x45C3C")]
	public class WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegment
	{
		[Token(Token = "0x40052B1")]
		[FieldOffset(Offset = "0x10")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegmentPropertyList propertyListField;

		[Token(Token = "0x40052B2")]
		[FieldOffset(Offset = "0x18")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegmentReference[] referenceListField;

		[Token(Token = "0x40052B3")]
		[FieldOffset(Offset = "0x20")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegmentMusicTrack[] childrenListField;

		[Token(Token = "0x40052B4")]
		[FieldOffset(Offset = "0x28")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegmentObjectLists objectListsField;

		[Token(Token = "0x40052B5")]
		[FieldOffset(Offset = "0x30")]
		private string nameField;

		[Token(Token = "0x40052B6")]
		[FieldOffset(Offset = "0x38")]
		private string idField;

		[Token(Token = "0x40052B7")]
		[FieldOffset(Offset = "0x40")]
		private uint shortIDField;

		[Token(Token = "0x6004781")]
		[Address(RVA = "0x175FB50", Offset = "0x175FB50", VA = "0x175FB50")]
		public WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegment()
		{
		}
	}
}
