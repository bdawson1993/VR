using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutterController : MonoBehaviour
{
    public GameObject chips;
    public GameObject spawnLocation;

    public float speed;
    public GameObject knifeObj; 
    Vector3 startLoc;
    bool doCut = false;


    // Start is called before the first frame update
    void Start()
    {
        startLoc = knifeObj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Cut();

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Food")
        {
            Destroy(other);
            Instantiate(chips, spawnLocation.transform.position, spawnLocation.transform.rotation);
            doCut = true;
            knifeObj.transform.Translate(Vector3.down);
        }

        
    }
   
    public void Cut()
    {
        float dist = Vector3.Distance(knifeObj.transform.position, startLoc);
        Debug.Log(Mathf.Round(dist));

        float roundedDist = Mathf.Round(dist);

        if(doCut == true)
        {
            float time = Mathf.PingPong(Time.time * speed, 0.26f);
            knifeObj.transform.position = Vector3.Lerp(startLoc, new Vector3(startLoc.x, -0.72f, startLoc.z), time);
        }

        if (roundedDist == 0)
            doCut = false;

    }
}
