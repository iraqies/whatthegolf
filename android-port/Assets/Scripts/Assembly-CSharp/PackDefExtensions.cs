internal static class PackDefExtensions
{
	public static ContentPack GetPack(this ContentPackDef packDef)
	{
		return packDef != null ? packDef.pack : null;
	}
}
