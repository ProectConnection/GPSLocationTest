using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class long_lati_calculator {

    const int Equator = 6378150;        //赤道半径
    const int EarthRadius = 6356752;    //地球の半径
    float LongitudeMetricsPerDegree = (2.0f * Mathf.PI * EarthRadius) / 360;
    public float longitudeMetricsPerDegree
    {
        get
        {
            return LongitudeMetricsPerDegree;
        }
    }

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

    public float CalculateLatitudeMetricParDegree(float Letitude)
    {
        return  (2.0f * Mathf.PI * (Equator * Mathf.Cos(Letitude * Mathf.PI / 180.0f ))) / 360;
    }

    
}
