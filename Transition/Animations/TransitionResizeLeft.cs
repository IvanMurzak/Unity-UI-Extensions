using DG.Tweening;

public class TransitionResizeLeft : TransitionAnimation
{
	public	bool		relative;
	public	float		to;
	
			float		start;
	
			float		To			=> relative ? start + to : to;

	private void Awake()
	{
		start = target.LocalLeftX();
	}

	protected override Tween CreateAnimation		=> target.DOTweenLocalResizeLeft(To, duration).SetEase(ease);
	protected override Tween CreateAnimationBack	=> target.DOTweenLocalResizeLeft(start, duration).SetEase(easeBack);
}
