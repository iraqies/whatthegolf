using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace WwiseInteractiveMusicHierarchyData
{
	[Serializable]
	[XmlType]
	[DesignerCategory]
	public class WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerTransitionListMusicTransitionMusicTransitionProperty
	{
		private string nameField;

		private string typeField;

		private string valueField;

		[XmlAttribute]
		public string Name => null;

		[XmlAttribute]
		public string Value => null;
	}
}
