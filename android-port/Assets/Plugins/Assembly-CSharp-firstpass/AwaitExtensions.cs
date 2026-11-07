using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

public static class AwaitExtensions
{
	public static TaskAwaiter<int> GetAwaiter(this Process process)
	{
		return default;
	}

	public static void WrapErrors(this Task task)
	{
	}
}
