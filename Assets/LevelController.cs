using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public List<GameObject> recipes = new List<GameObject>();
    

    // Start is called before the first frame update
    void Start()
    {
        recipes[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckRecipeComplete()
    {
        
    }
}
