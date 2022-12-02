using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOBJ : MonoBehaviour
{
    public GameObject AtomGOBJ;
    public GameObject OtherAtomGOBJ;

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
                AtomGOBJ.SetActive(false);
                OtherAtomGOBJ.SetActive(true);
            }
        }

        if (Input.GetKeyDown("a"))
        {
            AtomGOBJ.SetActive(false);
            OtherAtomGOBJ.SetActive(true);
        }
    }
}
