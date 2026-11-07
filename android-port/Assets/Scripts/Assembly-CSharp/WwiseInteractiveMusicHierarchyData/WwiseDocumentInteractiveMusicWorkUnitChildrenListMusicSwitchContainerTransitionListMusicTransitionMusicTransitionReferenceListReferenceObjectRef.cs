using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace WwiseInteractiveMusicHierarchyData
{
	[Serializable]
	[XmlType]
	[DesignerCategory]
	public class WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerTransitionListMusicTransitionMusicTransitionReferenceListReferenceObjectRef
	{
		private string nameField;

		private string idField;

		private string workUnitIDField;

		[XmlAttribute]
		public string Name => null;

		[XmlAttribute]
		public string ID => null;
	}
}
