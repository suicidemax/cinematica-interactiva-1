using UnityEngine;
using UnityEngine.Events;

public class QTE : MonoBehaviour
{
    public UnityEvent apretoBotonATiempo, apretoBotonFueraDeTiempo;
    public GameObject boton;
    public GameObject feedbackBad, feedbackGood;

    bool puedeApretar;
    bool apretoBoton;
    bool apretoATiempo;

    public void ActivarEvento()
    {
        if (apretoBoton) return;

        if (puedeApretar)
        {
            apretoATiempo = true;
            feedbackGood.SetActive(true);
        }
        else
        {
            apretoATiempo = false;
            feedbackBad.SetActive(true);
        }

        boton.SetActive(false);
        apretoBoton = true;
    }

    public void PuedeApretar(bool _state)
    {
        puedeApretar = _state;
    }

    public void CheckSiNoApretoNada()
    {
        if (apretoATiempo)
            apretoBotonATiempo.Invoke();
        else
            apretoBotonFueraDeTiempo.Invoke();

        feedbackBad.SetActive(false);
        feedbackGood.SetActive(false);
    }


}
