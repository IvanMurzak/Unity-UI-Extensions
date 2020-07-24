using Sirenix.OdinInspector;

public class UITransitionManager : BaseMonoBehaviour
{
	TransitionAnimation[] transitions;

	private void Awake()
	{
		transitions = GetComponents<TransitionAnimation>();
	}

	[HorizontalGroup("Buttons"), Button(ButtonSizes.Medium)]
	public void Animate()
	{
		foreach (var transition in transitions)
			transition.Animate();
	}
	[HorizontalGroup("Buttons"), Button(ButtonSizes.Medium)]
	public void AnimateBack()
	{
		foreach (var transition in transitions)
			transition.AnimateBack();
	}
}
