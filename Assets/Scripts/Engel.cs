using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engel : MonoBehaviour
{
    public Color color;


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Engel")
        {
            Debug.Log("deneme");
            for (int i = 0; i < 2; i++)
            {
                gameObject.GetComponent<MeshRenderer>().materials[i].color = Color.green;
            }
           
        }
    }
}
