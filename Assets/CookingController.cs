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


    private void Start()
    {
        audio = GetComponent<AudioSource>();
        renderer = GetComponent<Renderer>();
        startingMaterial = renderer.material;
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

    private void OnCollisionLeave(Collision collision)
    {
        if(audio.isPlaying)
        {
            audio.Stop();
        }

    }

    private void Update()
    {
        if(isCooking)
        {
            Debug.Log("Cooking");

            float lerp = Mathf.PingPong(Time.time, cookingTime) / cookingTime;
            renderer.material.Lerp(startingMaterial, cookedMateial, lerp);
        }
    }
}
