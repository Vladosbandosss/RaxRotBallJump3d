using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
