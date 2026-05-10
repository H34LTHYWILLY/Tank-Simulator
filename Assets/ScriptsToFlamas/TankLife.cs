using UnityEngine;

public class TankLife : MonoBehaviour, IVida
{
    public int vida { get; private set; } = 25;

    public void QuitarVida(int vidaPerdida = 1)
    {
        vida -= vidaPerdida;
        if (vida <= 0)
            Destroy(gameObject);
    }
}
