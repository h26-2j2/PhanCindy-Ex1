using UnityEngine;

public class ReductionEchelle : MonoBehaviour
{
    //Déclaration des variables publiques

    public float tauxReduction = 1.5f; // Taux de réduction de l'échelle du GameObject

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Logique de la variation de l'échelle du GameObject
        float nouvelleTaille = transform.localScale.x - tauxReduction* Time.deltaTime;

        //SI la nouvelleTaille est inférieure à 2 OU supérieure à 5
        if (nouvelleTaille < 2 || nouvelleTaille > 5)
        {
            //Multiplier le tauxReduction par -1
            tauxReduction *= -1;

        }
        //Appliquer la variation de l'échelle sur l'axe des x et y du GameObject
        transform.localScale = new Vector2(nouvelleTaille, nouvelleTaille);

    }

}
