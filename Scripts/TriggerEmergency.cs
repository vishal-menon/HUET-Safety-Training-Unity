using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEmergency : MonoBehaviour
{
    public GameObject enableObject1;
    public GameObject enableObject2;
    public GameObject disableObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        enableObject1.SetActive(true);
        enableObject2.SetActive(true);
        disableObject.SetActive(false);
    }

}
