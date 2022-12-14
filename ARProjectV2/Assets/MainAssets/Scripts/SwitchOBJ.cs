using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOBJ : MonoBehaviour
{
    public GameObject[] ThisGOBJ;
    public GameObject[] OtherGOBJ;

    // Use this for initialization
    void Start()
    {
        //AtomGOBJ = this.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                foreach (GameObject obj in ThisGOBJ)
                {
                    obj.SetActive(false);
                }
                foreach (GameObject obj in OtherGOBJ)
                {
                    obj.SetActive(true);
                }
            }
        }

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("a"))
        {
            foreach (GameObject obj in ThisGOBJ)
            {
                obj.SetActive(false);
            }
            foreach (GameObject obj in OtherGOBJ)
            {
                obj.SetActive(true);
            }
        }
    }
}
