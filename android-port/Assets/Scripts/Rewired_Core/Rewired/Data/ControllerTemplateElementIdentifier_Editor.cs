using System;
using Il2CppDummyDll;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[Token(Token = "0x20001CF")]
	internal sealed class ControllerTemplateElementIdentifier_Editor : ControllerTemplateElementIdentifier, IControllerElementIdentifierCommon_Internal, IControllerTemplateElementIdentifier, IControllerTemplateElementIdentifier_Editor
	{
		[Token(Token = "0x4000A88")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _scriptingName;

		[Token(Token = "0x4000A89")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _alternateScriptingName;

		[Token(Token = "0x4000A8A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _excludeFromExport;

		[Token(Token = "0x4000A8B")]
		[FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool _useEditorElementTypeOverride;

		[Token(Token = "0x4000A8C")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ControllerElementType _editorElementTypeOverride;

		[Token(Token = "0x170003C1")]
		internal string scriptingName
		{
			[Token(Token = "0x6000DE6")]
			[Address(RVA = "0x236D820", Offset = "0x236D820", VA = "0x236D820")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003C2")]
		internal string alternateScriptingName
		{
			[Token(Token = "0x6000DE7")]
			[Address(RVA = "0x236D828", Offset = "0x236D828", VA = "0x236D828")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003C3")]
		internal ControllerTemplateElementType effectiveElementType
		{
			[Token(Token = "0x6000DE8")]
			[Address(RVA = "0x236D830", Offset = "0x236D830", VA = "0x236D830")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003C4")]
		private string Rewired_002EInterfaces_002EIControllerTemplateElementIdentifier_Editor_002EscriptingName
		{
			[Token(Token = "0x6000DEA")]
			[Address(RVA = "0x236D858", Offset = "0x236D858", VA = "0x236D858", Slot = "9")]
			get
			{
				return Rewired_002EInterfaces_002EIControllerTemplateElementIdentifier_Editor_002Eget_scriptingName();
			}
		}

		[Token(Token = "0x170003C5")]
		private string Rewired_002EInterfaces_002EIControllerTemplateElementIdentifier_Editor_002EalternateScriptingName
		{
			[Token(Token = "0x6000DEB")]
			[Address(RVA = "0x236D860", Offset = "0x236D860", VA = "0x236D860", Slot = "10")]
			get
			{
				return Rewired_002EInterfaces_002EIControllerTemplateElementIdentifier_Editor_002Eget_alternateScriptingName();
			}
		}

		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0x236D850", Offset = "0x236D850", VA = "0x236D850")]
		public ControllerTemplateElementIdentifier_Editor()
		{
		}

		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0x236D858", Offset = "0x236D858", VA = "0x236D858", Slot = "9")]
		private string Rewired_002EInterfaces_002EIControllerTemplateElementIdentifier_Editor_002Eget_scriptingName()
		{
			return null;
		}

		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0x236D860", Offset = "0x236D860", VA = "0x236D860", Slot = "10")]
		private string Rewired_002EInterfaces_002EIControllerTemplateElementIdentifier_Editor_002Eget_alternateScriptingName()
		{
			return null;
		}
	}
}
