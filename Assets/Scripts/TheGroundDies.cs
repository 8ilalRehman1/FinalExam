using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheGroundDies : MonoBehaviour
{
    private bool groundDies;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (groundDies == true)
        {
            Destroy(gameObject,2);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        groundDies = true;
    }

}
