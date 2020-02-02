using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairReceptacle : MonoBehaviour
{
    public string receptacleType;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string GetReceptacleType()
    {
        return receptacleType;
    }

    public void PlacePart(GameObject part)
    {
        part.transform.parent = transform;
        part.GetComponent<DetectPart>().enabled = false;
        this.GetComponent<DetectPart>().enabled = false;
        this.enabled = false;
    }
}
