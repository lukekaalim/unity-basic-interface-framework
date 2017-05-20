using UnityEngine;

namespace UserInterface.Displays
{
	[RequireComponent(typeof(RectTransform))]
	public class BarDisplay : FloatDisplay
	{
		[SerializeField]
		RectTransform containerRect, fillRect;

		float lastValue;

		private void Start()
		{
			SetupRectTransforms();
		}

		private void SetupRectTransforms()
		{
			fillRect.pivot = new Vector2(0, 0.5f);
		}

		protected override void OnUpdate(float newValue)
		{
			float parentWidth = containerRect.sizeDelta.x;

			fillRect.sizeDelta = new Vector2(-1-newValue * parentWidth, 0);
			lastValue = newValue;
		}

		protected override bool ShouldUpdate(ref float prospectiveNewValue)
		{
			prospectiveNewValue = Mathf.Clamp01(prospectiveNewValue);
			return prospectiveNewValue != lastValue;
		}
	}
}
