using System;
using Il2CppDummyDll;

namespace WwiseInteractiveMusicHierarchyData
{
	[Serializable]
	[Token(Token = "0x2000F4E")]
	[AttributeAttribute(Name = "DesignerCategoryAttribute", RVA = "0x45A78", Offset = "0x45A78")]
	[AttributeAttribute(Name = "XmlTypeAttribute", RVA = "0x45A78", Offset = "0x45A78")]
	public class WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainer
	{
		[Token(Token = "0x40052A0")]
		[FieldOffset(Offset = "0x10")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerProperty[] propertyListField;

		[Token(Token = "0x40052A1")]
		[FieldOffset(Offset = "0x18")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerReference[] referenceListField;

		[Token(Token = "0x40052A2")]
		[FieldOffset(Offset = "0x20")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenList childrenListField;

		[Token(Token = "0x40052A3")]
		[FieldOffset(Offset = "0x28")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerTransitionList transitionListField;

		[Token(Token = "0x40052A4")]
		[FieldOffset(Offset = "0x30")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerPlaylist playlistField;

		[Token(Token = "0x40052A5")]
		[FieldOffset(Offset = "0x38")]
		private string nameField;

		[Token(Token = "0x40052A6")]
		[FieldOffset(Offset = "0x40")]
		private string idField;

		[Token(Token = "0x40052A7")]
		[FieldOffset(Offset = "0x48")]
		private uint shortIDField;

		[Token(Token = "0x600477C")]
		[Address(RVA = "0x175FB40", Offset = "0x175FB40", VA = "0x175FB40")]
		public WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainer()
		{
		}
	}
}
