using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public List<GameObject> recipes = new List<GameObject>();
    List<string> currentRecipe = new List<string>();
    public Points points;

    int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        recipes[index].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    public void IngredientCooked(string name)
    {
        //remove ingredient if in list
        if (currentRecipe.Contains(name.ToUpper()))
        {
            currentRecipe.Remove(name);
        }

        //if last in list change to next recipe
        if(currentRecipe.Count == 0)
        {
            recipes[index].SetActive(false);
            recipes[index + 1].SetActive(true);
            points.score += 10;
            index++;

        }


    }
}
