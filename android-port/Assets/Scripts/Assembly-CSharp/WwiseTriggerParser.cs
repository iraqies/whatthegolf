using System.Collections.Generic;
using UnityEngine;

public class WwiseTriggerParser : MonoBehaviour
{
	public class WwwiseTrigger : MonoBehaviour
	{
		public string dataName;

		public uint shortID;

		public string longID;

		public void Init(string id, string name)
		{
		}
	}

	public TextAsset file;

	public TextAsset bigFile;

	public List<WwwiseTrigger> triggers;
}
