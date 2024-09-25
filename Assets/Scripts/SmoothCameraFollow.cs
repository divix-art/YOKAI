using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    // Oggetto da seguire, serializzabile
    [SerializeField]
    private Transform target;

    // Distanza della camera rispetto all'oggetto
    public Vector3 offset = new Vector3(0, 5, -10);

    // Velocità di inseguimento della camera
    public float followSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        // Se non è stato assegnato un target manualmente, prova a trovare un oggetto chiamato "Player"
        if (target == null)
        {
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                target = player.transform;
            }
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (target != null)
        {
            // Posizione desiderata della camera
            Vector3 targetPosition = target.position + offset;

            // Movimento fluido della camera verso la posizione desiderata
            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
        }
    }
}
