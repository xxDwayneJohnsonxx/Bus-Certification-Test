using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelScript : MonoBehaviour
{
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
        if (other.CompareTag("Ground"))
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;

        }
        if (other.CompareTag("Road"))
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;

        }
        if (other.CompareTag("Buildings"))
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
