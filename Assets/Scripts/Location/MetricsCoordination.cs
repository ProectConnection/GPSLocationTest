using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetricsCoordination : ScriptableObject{

    protected LocationCoordination Ref_LocationCoordination;
    public LocationCoordination locationCoordination
    {
        get
        {
            return Ref_LocationCoordination;
        }
        set
        {
            Ref_LocationCoordination = value;
        }
        
    }
    //protected float LongitudeInMetrics;
    //public float longitudeMetrics
    //{
    //    get
    //    {
    //        return LongitudeInMetrics;
    //    }
    //}
    //protected float LetitudeInMetrics;
    //public float LetitudeMetrics
    //{
    //    get
    //    {
    //        return LetitudeInMetrics;
    //    }
    //}

    //public void ConvertLongAndLetiToMetrics()
    //{
    //    if (Ref_LocationCoordination)
    //    {
    //        LongitudeInMetrics = ((long_lati_calculator.GetInstance.longitudeMetricsPerDegree) * Ref_LocationCoordination.GetLongitude);
    //        LetitudeInMetrics = (long_lati_calculator.GetInstance.CalculateLatitudeMetricParDegree(Ref_LocationCoordination.GetLatitude)) * Ref_LocationCoordination.GetLatitude;
    //    }
    //}

    //public void SetLongAndLetiAndConvertMetrics(float Longitude,float Letitude)
    //{
    //    LongitudeInMetrics = ((long_lati_calculator.GetInstance.CalculateLongitudeMetricsPerDegree()) * Longitude);
    //    LetitudeInMetrics = (long_lati_calculator.GetInstance.CalculateLatitudeMetricParDegree(Letitude)) * Letitude;
    //}

    //public Vector2 ReturnLongAndLetiInMetrics()
    //{
    //    ConvertLongAndLetiToMetrics();
    //    return new Vector2(LongitudeInMetrics, LetitudeInMetrics);
    //}

    
}
