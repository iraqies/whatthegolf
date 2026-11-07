using System;
using Il2CppDummyDll;

namespace WwiseInteractiveMusicHierarchyData
{
	[Serializable]
	[Token(Token = "0x2000F88")]
	[AttributeAttribute(Name = "DesignerCategoryAttribute", RVA = "0x46EEC", Offset = "0x46EEC")]
	[AttributeAttribute(Name = "XmlTypeAttribute", RVA = "0x46EEC", Offset = "0x46EEC")]
	public class WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerPlaylistMusicPlaylistItem
	{
		[Token(Token = "0x400532F")]
		[FieldOffset(Offset = "0x10")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerPlaylistMusicPlaylistItemPropertyList propertyListField;

		[Token(Token = "0x4005330")]
		[FieldOffset(Offset = "0x18")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerPlaylistMusicPlaylistItemChildrenList childrenListField;

		[Token(Token = "0x4005331")]
		[FieldOffset(Offset = "0x20")]
		private string nameField;

		[Token(Token = "0x4005332")]
		[FieldOffset(Offset = "0x28")]
		private string idField;

		[Token(Token = "0x4005333")]
		[FieldOffset(Offset = "0x30")]
		private uint shortIDField;

		[Token(Token = "0x60047B6")]
		[Address(RVA = "0x175FCC8", Offset = "0x175FCC8", VA = "0x175FCC8")]
		public WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerPlaylistMusicPlaylistItem()
		{
		}
	}
}
