using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPart : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Part")
        {
            if (other.GetComponent<RepairPart>().GetRepaired() == false)
                transform.parent.parent.GetComponent<IteratorController>()
                .DetectedPart(other.gameObject);
        }
        else if (other.tag == "Receptacle")
        {
            if (other.GetComponent<RepairReceptacle>().GetRepaired() == false)
                transform.parent.parent.GetComponent<IteratorController>()
                .DetectReceptacle(other.gameObject);
        }
    }

}
