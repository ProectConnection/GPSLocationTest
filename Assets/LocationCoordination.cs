public class LocationCoordination : UnityEngine.ScriptableObject{
    
    private float longitude;
    private float latitude;
    
    public void SetCoordination(float tlongitude,float tlatitude)
    {
        longitude = tlongitude;
        latitude = tlatitude;
    }

    public float GetLongitude
    {
        get{ return longitude; }
    }

    public float GetLatitude
    {
        get { return latitude; }
    }
}