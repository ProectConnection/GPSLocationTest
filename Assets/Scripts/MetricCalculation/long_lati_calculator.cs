using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class long_lati_calculator {

    const int EarthRadius = 6378150;
    const float longitudeMetricsParDegree= 111263.283f;

    private static long_lati_calculator thisinstance = new long_lati_calculator();

    private long_lati_calculator()
    {

    }

    static public long_lati_calculator GetInstance
    {
        get
        {
            return thisinstance;
        }
    }

    public float CalculateLatitudeMetricParDegree(float latitude)
    {
        return  ((EarthRadius) * (Mathf.Cos(latitude / 180.0f * Mathf.PI) * 2.0f * Mathf.PI));
    }

    public float CalculateLongitudeMetricsPerDegree()
    {
        return ((2.0f * Mathf.PI * EarthRadius) / 360.0f);
    }
}
