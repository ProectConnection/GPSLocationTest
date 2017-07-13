using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MeterUITxt : MonoBehaviour {
    protected LocationCoordination Ref_LocationCoordination;
    protected UnityEngine.UI.Text TextUI;
    [SerializeField]
    protected float UpdateSecond = 1.0f;
    protected float Metrics;
    protected IEnumerator Coroutine;

    // Use this for initialization
    void Start()
    {
        Ref_LocationCoordination = GameObject.FindGameObjectWithTag("Locator").GetComponent<Locator>().locationCoordination;
        TextUI = gameObject.GetComponent<UnityEngine.UI.Text>();
        Coroutine = GetLocationCoordinationValueCorutine();
        StartCoroutine(Coroutine);
    }

    void Update()
    {
        TextUI.text = Metrics.ToString();
    }

    IEnumerator GetLocationCoordinationValueCorutine()
    {
        while (true)
        {
            GetLocationCoordinationValue();
            yield return new WaitForSeconds(UpdateSecond);
        }
    }

    public abstract void GetLocationCoordinationValue();
}
