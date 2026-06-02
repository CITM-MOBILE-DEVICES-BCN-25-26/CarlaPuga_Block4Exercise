using UnityEngine;

namespace MobilePerformance
{
	public class OptimizedDistanceCube : MonoBehaviour
	{
        public void CalculateDistances(OptimizedDistanceCube[] allCubes)
        {
            string distanceText = "";

            for (int i = 0; i < allCubes.Length; i++)
            {
                OptimizedDistanceCube otherCube = allCubes[i];

                if (otherCube == this)
                {
                    continue;
                }

                float distance = Vector3.Distance(transform.position, otherCube.transform.position);
                distanceText += $"{distance:0.00} |";
            }

            Debug.LogWarning($"Distance cube {this.gameObject.name}: {distanceText}");
        }
	}
}