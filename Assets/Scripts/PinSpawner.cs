using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pin;
    [SerializeField] private GameObject pinSpawnPoint;
    private AudioSource pew;

    private void Start()
    {
        pew = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(pin, pinSpawnPoint.transform.position, pinSpawnPoint.transform.rotation);
            pew.PlayOneShot(pew.clip);
        }
    }
}
