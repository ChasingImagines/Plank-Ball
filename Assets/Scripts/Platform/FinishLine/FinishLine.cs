using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] string sceneName= "MainMenu";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IFinishLineTriger finishLineTriger = collision.GetComponent<IFinishLineTriger>();
        if (finishLineTriger != null)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
