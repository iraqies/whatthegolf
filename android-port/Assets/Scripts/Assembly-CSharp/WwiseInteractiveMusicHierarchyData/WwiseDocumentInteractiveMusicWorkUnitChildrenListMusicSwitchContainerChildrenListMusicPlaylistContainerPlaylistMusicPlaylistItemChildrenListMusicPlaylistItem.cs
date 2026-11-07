using System;
using Il2CppDummyDll;

namespace WwiseInteractiveMusicHierarchyData
{
	[Serializable]
	[Token(Token = "0x2000F8C")]
	[AttributeAttribute(Name = "DesignerCategoryAttribute", RVA = "0x47054", Offset = "0x47054")]
	[AttributeAttribute(Name = "XmlTypeAttribute", RVA = "0x47054", Offset = "0x47054")]
	public class WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerPlaylistMusicPlaylistItemChildrenListMusicPlaylistItem
	{
		[Token(Token = "0x4005339")]
		[FieldOffset(Offset = "0x10")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerPlaylistMusicPlaylistItemChildrenListMusicPlaylistItemPropertyList propertyListField;

		[Token(Token = "0x400533A")]
		[FieldOffset(Offset = "0x18")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerPlaylistMusicPlaylistItemChildrenListMusicPlaylistItemSegmentRef segmentRefField;

		[Token(Token = "0x400533B")]
		[FieldOffset(Offset = "0x20")]
		private string nameField;

		[Token(Token = "0x400533C")]
		[FieldOffset(Offset = "0x28")]
		private string idField;

		[Token(Token = "0x400533D")]
		[FieldOffset(Offset = "0x30")]
		private uint shortIDField;

		[Token(Token = "0x60047BA")]
		[Address(RVA = "0x175FCD8", Offset = "0x175FCD8", VA = "0x175FCD8")]
		public WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerPlaylistMusicPlaylistItemChildrenListMusicPlaylistItem()
		{
		}
	}
}
