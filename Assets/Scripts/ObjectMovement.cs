using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float moveSpeed = 250f;
    public Camera mainCamera; // Riferimento alla telecamera principale

    // Update is called once per frame
    void Update()
    {
        // Ottieni l'input dagli assi
        float moveX = Input.GetAxis("Horizontal"); // A/D per movimento sull'asse X
        float moveY = Input.GetAxis("Vertical");   // W/S per movimento sull'asse Y

        // Crea un vettore di input
        Vector3 inputDirection = new Vector3(moveX, 0f, moveY);

        // Ottieni la direzione della telecamera sul piano orizzontale (XY)
        Vector3 cameraForward = mainCamera.transform.forward;
        Vector3 cameraRight = mainCamera.transform.right;

        // Proietta i vettori della telecamera sul piano XY
        cameraForward.y = 0;
        cameraRight.y = 0;

        cameraForward.Normalize();
        cameraRight.Normalize();

        // Calcola il movimento rispetto alla direzione della telecamera
        Vector3 moveDirection = inputDirection.x * cameraRight + inputDirection.z * cameraForward;

        // Sposta l'oggetto nella direzione calcolata
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
