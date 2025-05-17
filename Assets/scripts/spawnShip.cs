using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnShip : MonoBehaviour
{
    public static bool oyuncu1demi=true;
    public static bool ara;
    public GameObject ARASAA;


    GameObject[] oyuncu1 = new GameObject[10];
    GameObject[] oyuncu2 = new GameObject[10];
    public GameObject dörtlü, üçlü, ikili, tekli;
    private void Start()
    {
        
        oyuncu1[0]=
        Instantiate(dörtlü, randompositionffortwin(), Quaternion.identity);
        oyuncu1[1]=
        Instantiate(üçlü, randomposition(), Quaternion.identity);
        oyuncu1[2]=
        Instantiate(üçlü, randomposition(), Quaternion.identity);
        oyuncu1[3]=
        Instantiate(ikili, randompositionffortwin(), Quaternion.identity);
        oyuncu1[4]=
        Instantiate(ikili, randompositionffortwin(), Quaternion.identity);
        oyuncu1[5]=
        Instantiate(ikili, randompositionffortwin(), Quaternion.identity);
        oyuncu1[6]=
        Instantiate(tekli, randomposition(), Quaternion.identity);
        oyuncu1[7] =
        Instantiate(tekli, randomposition(), Quaternion.identity);
        oyuncu1[8]=
        Instantiate(tekli, randomposition(), Quaternion.identity);
        oyuncu1[9]=
        Instantiate(tekli, randomposition(), Quaternion.identity);

        foreach (GameObject item in oyuncu1)
        {
            item.name = "OUNCUBİR";
        }



        
        oyuncu2[0] =
        Instantiate(dörtlü, randompositionffortwin(), Quaternion.identity);
        oyuncu2[1] =
        Instantiate(üçlü, randomposition(), Quaternion.identity);
        oyuncu2[2] =
        Instantiate(üçlü, randomposition(), Quaternion.identity);
        oyuncu2[3] =
        Instantiate(ikili, randompositionffortwin(), Quaternion.identity);
        oyuncu2[4] =
        Instantiate(ikili, randompositionffortwin(), Quaternion.identity);
        oyuncu2[5] =
        Instantiate(ikili, randompositionffortwin(), Quaternion.identity);
        oyuncu2[6] =
        Instantiate(tekli, randomposition(), Quaternion.identity);
        oyuncu2[7] =
        Instantiate(tekli, randomposition(), Quaternion.identity);
        oyuncu2[8] =
        Instantiate(tekli, randomposition(), Quaternion.identity);
        oyuncu2[9] =
        Instantiate(tekli, randomposition(), Quaternion.identity);


        foreach (GameObject item in oyuncu2)
        {
            item.name = "OUNCUİKİ";
        }



        closemesh(oyuncu2, false);
        closecollider(oyuncu1, false);
    }
    private Vector3 randompositionffortwin()
    {

        float x = Random.Range(-4, 4);
        float z = Random.Range(-5, 5) + 0.5f;
        Vector3 konum = new Vector3(x, 0, z);
        
        return konum;
    
     }
    private Vector3 randomposition()
    {
        float x = Random.Range(-4, 4) + 0.5f;
        float z = Random.Range(-5, 5) + 0.5f;
        Vector3 konum = new Vector3(x, 0, z);
        return konum;
    }

    public void closemesh(GameObject[] x, bool enab)
    {
        foreach (GameObject a in x)
        {
            foreach(Transform y in a.transform)
            {
            y.GetComponent<MeshRenderer>().enabled = enab;
            }
        }

    }
        public void closecollider(GameObject[] x, bool enab)
    {
        foreach (GameObject a in x)
        {
            foreach (Transform y in a.transform)
            {

            y.GetComponent<Collider>().enabled = enab;
            }


        }
    }
    private void Update()
    {

        if (Input.GetMouseButtonDown(0)&&ara)
        {
            clicker.tık = true;
            if (oyuncu1demi)
            {
                closemesh(oyuncu1, false);
                closecollider(oyuncu2, false);
                closemesh(oyuncu2, true);
                closecollider(oyuncu1, true);
                oyuncu1demi = false;
            }
            else
            {
                closemesh(oyuncu2, false);
                closecollider(oyuncu1, false);
                closemesh(oyuncu1, true);
                closecollider(oyuncu2, true);

                oyuncu1demi = true;
            }
            ARASAA.SetActive(false);

        }
    }
}

    

