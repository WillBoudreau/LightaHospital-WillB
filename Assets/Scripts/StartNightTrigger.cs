using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartNightTrigger : MonoBehaviour
{
    public GameObject StartNight;
    public Scene TimeStart;
    // Start is called before the first frame update
    void Start()
    {
       StartNight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
       SceneManager.LoadScene(0);
    }
}
