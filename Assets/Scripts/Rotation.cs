using UnityEngine;

public class Rotation : MonoBehaviour
{
    //Déclaration des variables publiques

    public float vitesse; //angle de rotation 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Logique de la rotation du GameObject
        transform.Rotate(0, 0, vitesse * Time.deltaTime);
    }
}
