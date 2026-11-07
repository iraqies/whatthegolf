using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

public static class TaskExtensions
{
	public static IEnumerator AsIEnumerator(this Task task)
	{
		return null;
	}

	public static IEnumerator<T> AsIEnumerator<T>(this Task<T> task)
	{
		return null;
	}
}
