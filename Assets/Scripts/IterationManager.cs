using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IterationManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IteratorController currentIterator = 
            GameObject.FindGameObjectWithTag("Player")
            .GetComponent<IteratorController>();
        currentIterator.StartCycle();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
