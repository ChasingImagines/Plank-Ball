using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInGame : MonoBehaviour
{
    [SerializeField] GameObject maenu;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            maenu.SetActive(!maenu.activeSelf);
        }
    }
}
