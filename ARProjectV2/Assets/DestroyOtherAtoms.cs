using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOtherAtoms : MonoBehaviour
{
    public GameObject ThisGOBJ;
    public string AtomCombo1;
    public string AtomCombo2;
    private GameObject[] ToDestroyAtomGOBJ1;
    private GameObject[] ToDestroyAtomGOBJ2;
    // Start is called before the first frame update
    void Start()
    {
        ThisGOBJ= GetComponent<GameObject>();
        ThisGOBJ.SetActive(false);

        ToDestroyAtomGOBJ1 = GameObject.FindGameObjectsWithTag(AtomCombo1);
        ToDestroyAtomGOBJ2 = GameObject.FindGameObjectsWithTag(AtomCombo2);
    }

    private void Update()
    {
        foreach (GameObject AtomOBJ in ToDestroyAtomGOBJ1)
        {
            AtomOBJ.SetActive(false);
        }
        foreach (GameObject AtomOBJ in ToDestroyAtomGOBJ2)
        {
            AtomOBJ.SetActive(false);
        }
    }
}
