public class LetitudeMetertxt : MeterUITxt{

    public override void GetLocationCoordinationValue()
    {
        base.Metrics = long_lati_calculator.GetInstance.CalculateLatitudeMetricParDegree(base.Ref_LocationCoordination.GetLatitude) * Ref_LocationCoordination.GetLatitude;
    }
}
