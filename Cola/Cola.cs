// Cola - Primero que entra, primero que sale

public class Cola<T> 
{
    // Declaro la lista
    private List<T> c;

    // Constructor - Se genera una lista vacia
    public Cola(List<T> cola)
    {
        this.c = cola;
    }

    // encolar - Se agrega un elemento en la cola
    public void encolar(T elemento)
    {
        this.c.Add(elemento);
    }

    // desencolar - Se elimina el primer elemento de la cola
    public T desencolar()
    {
        T elementoTemp = this.c[0];
        this.c.RemoveAt(0);
        return elementoTemp;
    }

    // esVacia - Se verifica si la cola es vacia o no
    public bool esVacia()
    {
        return this.c.Count() == 0;
    }

    // getPrimerDato - Se devuelve el valor del primer dato
    public T getPrimerDato()
    {
        return this.c[0];
    }
}