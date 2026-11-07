using System;
using System.Collections.Generic;

[Serializable]
public class PackStarterDef
{
	public List<string> contentPackIds;

	public BasePackStarter starter;

	public bool isLevelNotificationStarter;
}
