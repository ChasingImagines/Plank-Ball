using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIHealth : MonoBehaviour
{



    [SerializeField] GameObject health1;
    [SerializeField] GameObject health2;
    [SerializeField] GameObject health3;
    [SerializeField] TextMeshProUGUI plusText;

    private void Start()
    {
        GameManager.Instance.uýHealth = this;
    }

    public  void UIUpdate(int health)
    {
        if(health <= 0)
        {
            plusText.gameObject.SetActive(false);
            health1.SetActive(false);
            health2.SetActive(false);
            health3.SetActive(false);
        }
        if(health == 1)
        {
            plusText.gameObject.SetActive(false);
            health1.SetActive(true);
            health2.SetActive(false);
            health3.SetActive(false);
        } 

        if(health == 2)
        {
            plusText.gameObject.SetActive(false);
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(false);
        }

        if (health == 3)
        {
            plusText.gameObject.SetActive(false);
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(true);
            
        }

        if (health > 3)
        {
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(true);
            plusText.gameObject.SetActive(true);
            plusText.text = "+" +(health - 3).ToString();
        }
    }
}
