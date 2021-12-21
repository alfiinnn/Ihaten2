using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetaPuzzleManager : MonoBehaviour
{
    public static string petaPass = "";
    public string Password = "NAANSAAFEU";
    public GameObject peta;
    private bool isFixed = false;
    private bool allIsPresed;
    public GameObject[] tombolPeta;
    public Item item1;
    public Item item2;

    private void Awake()
    {
        petaPass = "";
        tombolPeta = GameObject.FindGameObjectsWithTag("tombolPeta");
    }
    private void Update()
    {
        allIsPresed = true;
        for (int i = 0; i < tombolPeta.Length; i++)
        {
            if (!tombolPeta[i].GetComponent<ButtonPeta>().isPressed)
            {
                allIsPresed = false;
                break;
            }
        }
        if(allIsPresed && petaPass == Password)
        {
            if(!isFixed)
            {
                Debug.Log("a");
                Inventory.instance.Add(item1);
                Inventory.instance.Add(item2);
            }
            isFixed = true;
        }
    }
}
