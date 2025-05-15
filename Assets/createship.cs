using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createship : MonoBehaviour
{
    public GameObject[] ships;
    private List<Vector2> usedPosition = new List<Vector2>();
    void Start()
    {
        foreach (GameObject ships in ships)
        {
            Vector2 newPos2D;

            int attemps = 0;
            do
            {
                newPos2D = new Vector2(Random.Range(-23, 23), Random.Range(-13, 13));
                attemps++;
            }


            while (usedPosition.Contains(newPos2D) && attemps < 100);
            usedPosition.Add(newPos2D);
            Vector3 randomspawnPOSITION = new Vector3(Random.Range(-23, 23), Random.Range(-13, 13), Random.Range(13, 13));
            Instantiate(ships, randomspawnPOSITION, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
     
         
        
        
    }
}
