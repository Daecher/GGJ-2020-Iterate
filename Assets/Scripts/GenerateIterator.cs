using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateIterator : MonoBehaviour
{
    public Material templateMaterial;
    public List<GameObject> templateHeads;
    public List<GameObject> templateBodies;

    public int seed = 0;
    public string stringSeed = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Debug.Log(stringSeed);
            stringSeed.GetHashCode();
            Random.InitState(stringSeed.GetHashCode());
            Debug.Log(Random.Range(
                0, 
                Mathf.FloorToInt(Mathf.Pow(2, 16))
            ));
        }
    }

    void Generate()
    {
        /*
         * Iterators have two generated parts- their head and body. Each
         *  are generated with random shapes and colors.
         * The player camera should always be able to see the body
         *  (but not the head) as well as their hands/grabbers/whatever.
         * 
         * 
         * */
    }
}
