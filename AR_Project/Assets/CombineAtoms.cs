using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineAtoms : MonoBehaviour
{
    public GameObject ThisGOBJ;
    public string AtomCombo1;

    public GameObject NewMoleculeGOBJ;
    private GameObject[] ToDestroyAtomGOBJ;
    // Start is called before the first frame update
    void Start()
    {
        ToDestroyAtomGOBJ = GameObject.FindGameObjectsWithTag(AtomCombo1);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Atoms Colliding");

        if (other.gameObject.tag == AtomCombo1)
        {
            ThisGOBJ.SetActive(false);
            NewMoleculeGOBJ.SetActive(true);

            foreach(GameObject AtomOBJ in ToDestroyAtomGOBJ)
            {
                AtomOBJ.SetActive(false);
            }            
        }
    }
}
