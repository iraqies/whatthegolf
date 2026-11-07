using System;
using UnityEngine;

public class GuidScriptableObject : ScriptableObject
{
	[SerializeField]
	private string _guid;

	public string guid => _guid ?? string.Empty;

	public override bool Equals(object other)
	{
		if (other is GuidScriptableObject g)
			return EqualsTyped(this, g);
		return false;
	}

	private static bool EqualsTyped(GuidScriptableObject x, GuidScriptableObject y)
	{
		if (ReferenceEquals(x, y)) return true;
		if (ReferenceEquals(x, null) || ReferenceEquals(y, null)) return false;
		if (!string.IsNullOrEmpty(x._guid) && !string.IsNullOrEmpty(y._guid))
			return string.Equals(x._guid, y._guid, StringComparison.Ordinal);
		return (UnityEngine.Object)x == (UnityEngine.Object)y;
	}

	public static bool operator ==(GuidScriptableObject x, GuidScriptableObject y) => EqualsTyped(x, y);

	public static bool operator !=(GuidScriptableObject x, GuidScriptableObject y) => !EqualsTyped(x, y);

	public override int GetHashCode() => !string.IsNullOrEmpty(_guid) ? _guid.GetHashCode() : base.GetHashCode();
}
