using System;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	internal sealed class ControllerTemplateElementIdentifier_Editor : ControllerTemplateElementIdentifier, IControllerElementIdentifierCommon_Internal, IControllerTemplateElementIdentifier, IControllerTemplateElementIdentifier_Editor
	{
		[SerializeField]
		private string _scriptingName;

		[SerializeField]
		private string _alternateScriptingName;

		[SerializeField]
		private bool _excludeFromExport;

		[SerializeField]
		private bool _useEditorElementTypeOverride;

		[SerializeField]
		private ControllerElementType _editorElementTypeOverride;

		internal string scriptingName => null;

		internal string alternateScriptingName => null;

		internal ControllerTemplateElementType effectiveElementType => ControllerTemplateElementType.Axis;

		string IControllerTemplateElementIdentifier_Editor.scriptingName => null;

		string IControllerTemplateElementIdentifier_Editor.alternateScriptingName => null;
	}
}
