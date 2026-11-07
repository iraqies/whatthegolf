using System;
using Il2CppDummyDll;

namespace WwiseInteractiveMusicHierarchyData
{
	[Serializable]
	[Token(Token = "0x2000F58")]
	[AttributeAttribute(Name = "DesignerCategoryAttribute", RVA = "0x45DFC", Offset = "0x45DFC")]
	[AttributeAttribute(Name = "XmlTypeAttribute", RVA = "0x45DFC", Offset = "0x45DFC")]
	public class WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegmentMusicTrack
	{
		[Token(Token = "0x40052C1")]
		[FieldOffset(Offset = "0x10")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegmentMusicTrackPropertyList propertyListField;

		[Token(Token = "0x40052C2")]
		[FieldOffset(Offset = "0x18")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegmentMusicTrackReference[] referenceListField;

		[Token(Token = "0x40052C3")]
		[FieldOffset(Offset = "0x20")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegmentMusicTrackChildrenList childrenListField;

		[Token(Token = "0x40052C4")]
		[FieldOffset(Offset = "0x28")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegmentMusicTrackTransitionList transitionListField;

		[Token(Token = "0x40052C5")]
		[FieldOffset(Offset = "0x30")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegmentMusicTrackObjectList[] objectListsField;

		[Token(Token = "0x40052C6")]
		[FieldOffset(Offset = "0x38")]
		private string nameField;

		[Token(Token = "0x40052C7")]
		[FieldOffset(Offset = "0x40")]
		private string idField;

		[Token(Token = "0x40052C8")]
		[FieldOffset(Offset = "0x48")]
		private uint shortIDField;

		[Token(Token = "0x6004786")]
		[Address(RVA = "0x175FB58", Offset = "0x175FB58", VA = "0x175FB58")]
		public WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegmentMusicTrack()
		{
		}
	}
}
