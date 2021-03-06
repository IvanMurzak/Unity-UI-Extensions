﻿using DG.Tweening;

public class TransitionResizeRight : TransitionAnimation
{
	public	bool		relative;
	public	float		to;
	
			float		start;
	
			float		To			=> relative ? start + to : to;

	private void Awake()
	{
		start = target.LocalRightX();
	}

	protected override Tween CreateAnimation		=> target.DOTweenLocalResizeRight(To, duration).SetEase(ease);
	protected override Tween CreateAnimationBack	=> target.DOTweenLocalResizeRight(start, duration).SetEase(easeBack);
}
