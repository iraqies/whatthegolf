using System;
using Il2CppDummyDll;

namespace WwiseInteractiveMusicHierarchyData
{
	[Serializable]
	[Token(Token = "0x2000F5A")]
	[AttributeAttribute(Name = "XmlTypeAttribute", RVA = "0x45EB0", Offset = "0x45EB0")]
	[AttributeAttribute(Name = "DesignerCategoryAttribute", RVA = "0x45EB0", Offset = "0x45EB0")]
	public class WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegmentMusicTrackPropertyListProperty
	{
		[Token(Token = "0x40052CA")]
		[FieldOffset(Offset = "0x10")]
		private WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegmentMusicTrackPropertyListPropertyValueList valueListField;

		[Token(Token = "0x40052CB")]
		[FieldOffset(Offset = "0x18")]
		private string nameField;

		[Token(Token = "0x40052CC")]
		[FieldOffset(Offset = "0x20")]
		private string typeField;

		[Token(Token = "0x6004788")]
		[Address(RVA = "0x175FC30", Offset = "0x175FC30", VA = "0x175FC30")]
		public WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainerChildrenListMusicSegmentMusicTrackPropertyListProperty()
		{
		}
	}
}
