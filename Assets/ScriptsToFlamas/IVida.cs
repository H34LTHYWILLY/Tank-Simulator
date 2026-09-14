

using System.Collections.Generic;

public interface IVida
{
    int vida { get; }
    void QuitarVida(int vidaPerdida = 1);
}
