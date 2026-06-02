using UnityEngine;

public class TankLife : MonoBehaviour, IVida
{
    public int vida
    {
        get 
        {
            return _Vida;
        }

        set 
        {
            _Vida = value;
        }
    }

    [SerializeField] private int _Vida;

    public void QuitarVida(int vidaPerdida = 1)
    {
        vida -= vidaPerdida;
        if (vida <= 0)
            Destroy(gameObject);
    }
}
