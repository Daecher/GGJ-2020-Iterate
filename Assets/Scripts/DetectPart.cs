using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPart : MonoBehaviour
{
    public Transform receptaclePos;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Part")
        {
            transform.parent.parent.GetComponent<IteratorController>()
                .DetectedPart(other.gameObject);
        }
        else if (other.tag == "Receptacle")
        {
            transform.parent.parent.GetComponent<IteratorController>()
                .DetectReceptacle(other.gameObject);
        }
    }

}
