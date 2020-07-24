using UnityEngine.UI;

public static class ExtensionImage
{
	public static float Alpha(this Image c)
	{
		return c.color.a;
	}
	public static Image SetAlpha(this Image c, float alpha)
	{
		c.color = c.color.SetA(alpha);
		return c;
	}
}
