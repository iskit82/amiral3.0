using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class clicker : MonoBehaviour
{
    public Material mat;
    public GameObject arasahne;
    public static bool tık = true;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && tık == true)
            {

                Destructible d = hit.collider.gameObject.GetComponent<Destructible>();

                if (d != null && d.canBeDestroyed)

                changematerial(hit.collider.gameObject);
                tık = false;
                StartCoroutine(geçiş());
            }
        }
        IEnumerator geçiş()
        {
            yield return new WaitForSeconds(0);
            spawnShip.ara = true;
            arasahne.SetActive(true);

        }

    }
    void changematerial(GameObject a)
    {

        Renderer rend = a.GetComponent<Renderer>();
        if (rend != null)
        {
            rend.material = mat;
        }
        Destroy(a.GetComponent<Destructible>());
        a.transform.parent = null;
        a.SetActive(true);
    }
}
