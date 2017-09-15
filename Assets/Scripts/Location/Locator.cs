using System.Collections;
using UnityEngine;

public class Locator : MonoBehaviour
{
    LocationService locationService;
    [System.NonSerialized]
    public LocationCoordination locationCoordination;

    float locationAnalyzeCounter;
    [SerializeField]
    float locationAnalyzeTime;
    bool isMobilePlatform;
    bool isLocationUpdating;
    GoogleMapDrawer googleMapDrawer;
    [SerializeField]
    float initlat = 35.513f;
    [SerializeField]
    float initlong = 139.619f;
    // Use this for initialization
    void Start()
    {
        locationService = Input.location;
        locationCoordination = ScriptableObject.CreateInstance<LocationCoordination>();
        googleMapDrawer = GameObject.FindGameObjectWithTag("MapDrawer").GetComponent<GoogleMapDrawer>();
        googleMapDrawer.Calculator = locationCoordination;
        //ロケーションサービスが無効、かつユーザーが許可しているなら
        //ロケーションサービスを有効化
        switch (Application.platform)
        {
            case RuntimePlatform.Android:
            case RuntimePlatform.IPhonePlayer:
                isMobilePlatform = true;
                break;
        }
        if (isMobilePlatform)
        {
            switch (locationService.status)
            {
                case LocationServiceStatus.Stopped:
                    LocationUpdate();
                    break;
                default:
                    break;
            }
        }
        else
        {
            locationCoordination.SetCoordination(initlong, initlat);
        }

    }
    
    // Update is called once per frame
    void Update()
    {
        if (isMobilePlatform)
        {
            StartCoroutine("LocationUpdate");
            googleMapDrawer.BuildMap();
            locationAnalyzeCounter += Time.deltaTime;
            if (!(isLocationUpdating) && locationAnalyzeCounter >= locationAnalyzeTime)
            {
                locationAnalyzeCounter = 0.0f;
                
                
            }
        }
    }

    IEnumerator LocationUpdate()
    {

        int retryCounter = 20;
        if (locationService.isEnabledByUser)
        {
            isLocationUpdating = true;
            locationService.Start();
            while (locationService.status == LocationServiceStatus.Initializing && retryCounter > 0)
            {
                retryCounter--;
                yield return new WaitForSeconds(1.0f);
            }
            
            if (locationService.status == LocationServiceStatus.Running)
            {
                locationCoordination.SetCoordination(locationService.lastData.longitude, locationService.lastData.latitude);
            }
            else
            {
                Debug.Log("failed Location Service initiation");
            }
            //locationService.Stop();
            isLocationUpdating = false;
        }
        
        yield return null;
    }
}
