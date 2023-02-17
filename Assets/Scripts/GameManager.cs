using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private CameraMovement cm;
    private Movement pm;

    [SerializeField] GameObject[] collectingObj;
    [SerializeField] GameObject[] slots;

    private void Awake()
    {
        cm = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraMovement>();
        pm = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>();
    }
   
    public void rightButton()
    {
        if (cm.index < 5)
        {
            cm.index++;
            cm.index1++;
            cm.index2++;
            cm.index3++;
        }
        else
        {
            cm.index = 0;
            cm.index1 = 0;
            cm.index2 = 0;
            cm.index3 = 0;
        }
        
    }

    public void leftButton()
    {
        if (cm.index > 0)
        {
            cm.index--;
            cm.index1--;
            cm.index2--;
            cm.index3--;
        }
        else
        {
            cm.index = 5;
            cm.index1 = 5;
            cm.index2 = 5;
            cm.index3 = 5;
        }
    }

    public void slotFill(int index) {
        slots[index].SetActive(false);
        collectingObj[index].SetActive(true);
    }
}
