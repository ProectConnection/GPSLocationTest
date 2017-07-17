using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCalculator : MonoBehaviour {

    Vector2 PrevPositionInMetrics;
    float totalMoveDistance;
    bool isFirstTime = true;
    public float TotalMoveDistance
    {
        get
        {
            return totalMoveDistance;
        }
    }
    MetricsCoordination ref_metricsCoordination;

    LocationCoordination ref_locationCoordination;

    private void Start()
    {
        ref_metricsCoordination = GameObject.FindGameObjectWithTag("Locator").GetComponent<Locator>().metricsCoordination;
        ref_locationCoordination = GameObject.FindGameObjectWithTag("Locator").GetComponent<Locator>().locationCoordination;
        //StartCoroutine(ProcessDistanceCalculation());
    }

    public void DistanceCalculation()
    {
        if (isFirstTime)
        {
            PrevPositionInMetrics = new Vector2(ref_locationCoordination.GetLongitude, ref_locationCoordination.GetLatitude);
            isFirstTime = false;
        }
        else
        {
            float longitudeDistance = (long_lati_calculator.GetInstance.longitudeMetricsPerDegree * (ref_locationCoordination.GetLongitude - PrevPositionInMetrics.x));
            totalMoveDistance += Mathf.Sqrt(
                (long_lati_calculator.GetInstance.longitudeMetricsPerDegree * (ref_locationCoordination.GetLongitude - PrevPositionInMetrics.x)) *
                (long_lati_calculator.GetInstance.longitudeMetricsPerDegree * (ref_locationCoordination.GetLongitude - PrevPositionInMetrics.x)) +
                (long_lati_calculator.GetInstance.CalculateLatitudeMetricParDegree(PrevPositionInMetrics.y) * (ref_locationCoordination.GetLatitude - PrevPositionInMetrics.y)) *
                (long_lati_calculator.GetInstance.CalculateLatitudeMetricParDegree(PrevPositionInMetrics.y) * (ref_locationCoordination.GetLatitude - PrevPositionInMetrics.y))
                );
            PrevPositionInMetrics = new Vector2(ref_locationCoordination.GetLongitude, ref_locationCoordination.GetLatitude);
        }
    }

    IEnumerator ProcessDistanceCalculation()
    {
        while (true)
        {
            DistanceCalculation();
            yield return new WaitForSeconds(6.0f);
        }
    }
}
