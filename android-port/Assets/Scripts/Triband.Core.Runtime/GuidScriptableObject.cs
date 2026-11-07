using UnityEngine;

public class GuidScriptableObject : ScriptableObject
{
	[SerializeField]
	private string _guid;

	public string guid => null;

	public override bool Equals(object other)
	{
		return false;
	}

	private static bool EqualsTyped(GuidScriptableObject x, GuidScriptableObject y)
	{
		return false;
	}

	public static bool operator ==(GuidScriptableObject x, GuidScriptableObject y)
	{
		return false;
	}

	public static bool operator !=(GuidScriptableObject x, GuidScriptableObject y)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
