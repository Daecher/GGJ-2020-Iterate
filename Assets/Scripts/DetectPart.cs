using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPart : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Part")
        {
            transform.parent.parent.GetComponent<IteratorController>()
                .DetectedPart(other.gameObject);
        }
    }
}
