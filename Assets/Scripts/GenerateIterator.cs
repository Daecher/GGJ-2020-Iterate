using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateIterator : MonoBehaviour
{
    public List<GameObject> templateHeads;
    public List<GameObject> templateBodies;
    public string stringSeed = "";
    public Transform headLocation;
    public Transform bodyLocation;

    GameObject generatedHead;
    GameObject generatedBody;
    Material generatedMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Generate();
        }
    }

    void Generate()
    {
        /*
         * Iterators have two generated parts- their head and body. Each
         *  are generated with random shapes and colors.
         * The player camera should always be able to see the body
         *  (but not the head) as well as their hands/grabbers/whatever.
         * */

        Debug.Log(stringSeed);
        stringSeed.GetHashCode();
        Random.InitState(stringSeed.GetHashCode());
        Debug.Log(Random.Range(
            0,
            Mathf.FloorToInt(Mathf.Pow(2, 16))
        ));

        // Generate head
        // Pick head shape
        // Pick x/y/z scale

        int headChoice = Random.Range(0, templateHeads.Count);
        Vector3 headScale = new Vector3(
            Random.Range(0.5f, 1.5f),
            Random.Range(0.5f, 1.5f),
            Random.Range(0.5f, 1.5f)
            );
        Color colorChoice = Random.ColorHSV();

        var head = Instantiate(templateHeads[headChoice], headLocation.transform.position, Quaternion.identity);
        head.GetComponent<Renderer>().material.color = colorChoice;
        head.transform.localScale = headScale;

        // Generate body
        // Pick body color
        // Pick x/y/z scale

        int bodyChoice = Random.Range(0, templateBodies.Count);
        Vector3 bodyScale = new Vector3(
            Random.Range(0.5f, 1.5f),
            Random.Range(0.5f, 1.5f),
            Random.Range(0.5f, 1.5f)
            );
        var body = Instantiate(templateBodies[bodyChoice], bodyLocation.position, Quaternion.identity);
        body.GetComponent<Renderer>().material.color = colorChoice;
        body.transform.localScale = bodyScale;
    }
}
