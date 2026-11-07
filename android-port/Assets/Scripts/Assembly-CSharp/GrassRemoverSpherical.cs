public class GrassRemoverSpherical : GrassRemover
{
	protected override bool CheckCoords(int[,] detailLayer, int x, int y, int fromX, int fromY)
	{
		return false;
	}
}
