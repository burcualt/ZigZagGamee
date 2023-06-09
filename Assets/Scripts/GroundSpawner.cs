using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] GameObject sonZemin;
    private void Start()
    {
        
        for(int i= 1; i<20; i++)
        {
            ZeminOlustur();
        }
    }

    public void ZeminOlustur()
    {
        Vector3 yon;
        if(Random.Range(0,2)  ==0) //0 gelirse x ekseninde zemin koy
        {
            yon = Vector3.left;
        }
        else //1 gelirse z ekseninde zemin kouy
        {
            yon = Vector3.back;
        }
    sonZemin= Instantiate(sonZemin, sonZemin.transform.position + yon, sonZemin.transform.rotation);
    }
}
