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
                float xPos = Mathf.Clamp(Random.Range(-25, 25), -25, 25);
                float yPos = Mathf.Clamp(Random.Range(-15, 15), -15, 15);

                newPos2D = new Vector2(xPos,yPos );
                attemps++;
                
            }


            while (usedPosition.Contains(newPos2D) && attemps < 100);
            usedPosition.Add(newPos2D);
            Vector3 randomspawnPOSITION = new Vector3(newPos2D.x, newPos2D.y, 13f);
            int[] possibleAngles = { 0, 90, 180, 270 };
            int randomIndex = Random.Range(0, possibleAngles.Length);
            Quaternion randomRotation = Quaternion.Euler(0, 0, possibleAngles[randomIndex]);
            Instantiate(ships, randomspawnPOSITION, randomRotation);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
     
         
        
        
    }
}
