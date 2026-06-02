using TMPro;
using UnityEngine;

namespace MobilePerformance
{
	public class OptimizedTimerText : MonoBehaviour
	{
		[SerializeField] private TMP_Text timerText;

		private float elapsedTime;

		private float updateInterval = 0.1f;
		private float nextUpdate;


		private void Awake()
		{
			if (timerText == null)
			{
				timerText = GetComponent<TMP_Text>();
			}
		}

		private void Update()
		{
			elapsedTime += Time.deltaTime;
			if (Time.time >= nextUpdate)
			{
                timerText.text = $"Time: {elapsedTime:0.000}";
                nextUpdate = Time.time + updateInterval;
			}
		}
	}
}