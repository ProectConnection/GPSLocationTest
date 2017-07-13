public class LongitudeMeterTxt : MeterUITxt{

    public override void GetLocationCoordinationValue()
    {
        base.Metrics = ((long_lati_calculator.GetInstance.CalculateLongitudeMetricsPerDegree()) * Ref_LocationCoordination.GetLongitude);   
    }
}
