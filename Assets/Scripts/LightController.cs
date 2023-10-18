using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject Light;
    public GameObject SpotLight;
    // Start is called before the first frame update
    void Start()
    {
        Light.SetActive(false);
        SpotLight.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
