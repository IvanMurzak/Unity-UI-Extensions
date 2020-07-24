using DG.Tweening;

public class TransitionResizeBottom : TransitionAnimation
{
	public	bool		relative;
	public	float		to;
	
			float		start;
	
			float		To			=> relative ? start + to : to;

	private void Awake()
	{
		start = target.LocalBottomY();
	}

	protected override Tween CreateAnimation		=> target.DOTweenLocalResizeBottom(To, duration).SetEase(ease);
	protected override Tween CreateAnimationBack	=> target.DOTweenLocalResizeBottom(start, duration).SetEase(easeBack);
}
