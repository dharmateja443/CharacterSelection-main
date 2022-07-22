using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawnner : MonoBehaviour
{
    [SerializeField] GameObject tanker;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(tanker, transform.position, Quaternion.identity); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
