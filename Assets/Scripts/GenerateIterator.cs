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
            
            Debug.Log(Random.state);
            int convertedString = 0;
            string newStringSeed = "";
            foreach(char c in stringSeed)
            {
                Debug.Log(c);
                convertedString = c-96;
                Debug.Log(convertedString);
                newStringSeed += convertedString.ToString();
            }
            Debug.Log(int.Parse(newStringSeed));
            Random.InitState(int.Parse(newStringSeed));
            Debug.Log(Random.Range(1, 10000));
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
