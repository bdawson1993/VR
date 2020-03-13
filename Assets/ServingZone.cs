using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServingZone : MonoBehaviour
{
    // Start is called before the first frame update
    public LevelController controller;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Food"))
        {
            CookingController ccontroller = other.GetComponent<CookingController>();
            if(ccontroller.isCooked)
            {
                controller.IngredientReady(ccontroller.name); ;
            }
        }
    }
}
