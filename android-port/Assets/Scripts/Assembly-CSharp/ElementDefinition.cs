using UnityEngine;

public class ElementDefinition : ScriptableObject
{
	[SerializeField]
	private int m_Id;

	[SerializeField]
	private Sprite m_Icon;

	public int id
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Sprite icon
	{
		get
		{
			return null;
		}
		set
		{
		}
	}
}
