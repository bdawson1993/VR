using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.root.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
        }
    }
}
