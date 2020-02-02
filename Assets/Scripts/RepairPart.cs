using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairPart : MonoBehaviour
{
    [SerializeField]
    string partType;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string GetPartType()
    {
        return partType;
    }
}
