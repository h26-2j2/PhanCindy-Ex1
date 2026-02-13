using UnityEngine;

public class DeplacementWarpBasVersHaut : MonoBehaviour
{
    //Déclaration des variables publiques

    public float vitesseY;  // Vitesse sur l'axe des Y modifiable dans l'inspecteur
    public float limiteHaut = 14.75f; // Limite du haut de l'écran de jeu (Quand les météores sortent complètement du haut de l'écran)
    public float limiteBas = -14.93f; // Limite du bas de l'écran du jeu (Quand les météores sortent complètement du bas de l'écran)

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Varier la position x des météores entre -11.66f et 11.28f
        float positionX = Random.Range(-11.66f, 11.28f);

        // Logique de déplacement du bas vers le haut
        transform.position += new Vector3(0, vitesseY, 0) * Time.deltaTime;

        //SI la position y du météore est supérieure à la limite du haut de l'écran de jeu
        if (transform.position.y > limiteHaut)
        {
            //Positionner le météore à cette position (Warp en bas de l'écran)
            transform.position = new Vector3(positionX, limiteBas);
        }
    }
}
