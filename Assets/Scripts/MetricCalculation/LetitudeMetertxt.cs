public class LetitudeMetertxt : MeterUITxt{

    public override void GetLocationCoordinationValue()
    {
        Metrics = (long_lati_calculator.GetInstance.CalculateLatitudeMetricParDegree(base.Ref_LocationCoordination.GetLatitude)) * Ref_LocationCoordination.GetLatitude;
    }

    
}
