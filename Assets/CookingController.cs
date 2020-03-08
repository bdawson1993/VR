using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingController : MonoBehaviour
{
    public LevelController controller;
    public Material cookedMateial;
    public float cookingTime;


    AudioSource audio;
    bool isCooking = false;
    bool isCooked = false;
    Renderer renderer;
    Material startingMaterial;
    Timer timer = new Timer();

    private void Start()
    {
        audio = GetComponent<AudioSource>();
        renderer = GetComponent<Renderer>();
        startingMaterial = renderer.material;


        //config timer
        timer.SetGoal(0, 2, 0);
        timer.GoalReached.AddListener(Cooked);
    }

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CookingEquipment"))
        {
            isCooking = true;
            audio.Play();
        }
    }



    private void OnCollisionExit(Collision collision)
    {
        if (audio.isPlaying)
        {
            audio.Stop();
        }
    }
    
    private void Update()
    {
        if( (isCooking == true) && (isCooked == false))
        {
            timer.Update();
        }
    }

    void Cooked()
    {
        isCooked = true;
        renderer.material = cookedMateial;
    }
}
