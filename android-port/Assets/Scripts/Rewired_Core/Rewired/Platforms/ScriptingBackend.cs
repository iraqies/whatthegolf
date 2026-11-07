using System.ComponentModel;

namespace Rewired.Platforms
{
	[EditorBrowsable]
	public enum ScriptingBackend
	{
		Mono = 0,
		DotNet = 1,
		IL2CPP = 2
	}
}
