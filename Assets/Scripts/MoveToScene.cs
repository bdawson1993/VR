using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToScene : MonoBehaviour
{
    public int sceneIndex;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.root.CompareTag("Player"))
            SceneManager.LoadScene(sceneIndex);
    }
}
