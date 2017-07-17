public class LongitudeMeterTxt : MeterUITxt{

    public override void GetLocationCoordinationValue()
    {
        Metrics = Ref_Locator.metricsCoordination.longitudeMetrics; 
    }
}
