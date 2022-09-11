// Arbol Binario - Arbol que puede tener como maximo grado 2 (solo dos hijos).

// Utilizo la clase cola
using Cola;
public class ArbolBinario<T> 
{
    
    // Atributos
    private T dato;
    private ArbolBinario<T> hijoIzq;
    private ArbolBinario<T> hijoDer;
    
    // Constructor - Se pide el elemento que se va a guardar en el arbol
    public ArbolBinario (T dato)
    {
        this.dato = dato;
    }

    // getDato - Devuelve el dato del arbol
    public T getDato()
    {
        return this.dato;
    }

    // getHijoIzquierdo - Devuelve el hijo izquierdo del arbol, de no poseer devuelve 'None'
    public ArbolBinario<T> getHijoIzquierdo()
    {
        return this.hijoIzq;
    }

    // getHijoDerecho - Devuelve el hijo derecho del arbol, de no poseer devuelve 'None'
    public ArbolBinario<T> getHijoDerecho()
    {
        return this.hijoDer;
    }

    // agregarHijoIzq - Permite agregar un hijo izquierdo al arbol
    public void agregarHijoIzq(ArbolBinario<T> hijo)
    {
        this.hijoIzq = hijo;
    }

    // agregarHijoDer - Permite agregar un hijo derecho al arbol
    public void agregarHijoDer(ArbolBinario<T> hijo)
    {
        this.hijoDer = hijo;
    }

    // eliminarHijoIzq - Elimina el hijo izquierdo del arbol
    public void eliminarHijoIzq()
    {
        this.hijoIzq = null;
    }

    // eliminarHijoDer - Elimina el hijo derecho del arbol
    public void eliminarHijoDer()
    {
        this.hijoDer = null;
    }

    // esHoja - Determina si el arbol es o no hoja
    public bool esHoja()
    {
        return this.hijoIzq != null && this.hijoDer != null;
    }

    // inorden - Procesa primero hijo izquierdo, luego el dato y por ultimo el hijo derecho
    public void inorden()
    {
        // Proceso hijo izquierdo
        if (this.hijoIzq != null)
        {
            this.hijoIzq.inorden();
        }
        // Proceso el dato
        Console.WriteLine(this.dato);
        // Proceso hijo derecho
        if (this.hijoDer != null)
        {
            this.hijoDer.inorden();
        }
    }

    // preorden - Procesa primero el dato, luego el hijo izquierdo y por ultimo el hijo derecho
    public void preorden()
    {
        // Proceso el dato
        Console.WriteLine(this.dato);
        // Proceso hijo izquierdo
        if (this.hijoIzq != null)
        {
            this.hijoIzq.preorden();
        }
        // Proceso hijo derecho
        if (this.hijoDer != null)
        {
            this.hijoDer.preorden();
        }
    }

    // postorden - Procesa primero el hijo izquierdo, luego el hijo derecho y por el ultimo el dato
    public void postorden()
    {
        // Proceso hijo izquierdo
        if (this.hijoIzq != null)
        {
            this.hijoIzq.postorden();
        }
        // Proceso hijo derecho
        if (this.hijoDer != null)
        {
            this.hijoDer.postorden();
        }
        // Proceso el dato
        Console.WriteLine(this.dato);
    }

    // porNiveles - Recorre el arbol por niveles de izquierda a derecha, utiliza la estructura de datos de cola
    public void porNiveles()
    {
        // Declaro e instancio la cola
        Cola<ArbolBinario<T>> cola = new Cola<ArbolBinario<T>>();
        // Declaro el arbol auxiliar
        ArbolBinario<T> arbolAux;
        // Encolo la raiz del arbol
        cola.encolar(this);
        // Mientras que la cola no este vacia, se va a repetir el proceso de encolar
        while (!cola.esVacia())
        {
            // Desencolo y guardo el arbol en el arbol auxiliar
            arbolAux = cola.desencolar();
            // Proceso el dato
            Console.WriteLine(arbolAux.getDato());
            // Verifico si tiene hijo izquierdo, si lo tiene lo encolo
            if  (arbolAux.getHijoIzquierdo() != null)
            {
                cola.encolar(arbolAux.getHijoIzquierdo());
            }
            // Verifico si tiene hijo derecho, si lo tiene lo encolo
            if  (arbolAux.getHijoDerecho() != null)
            {
                cola.encolar(arbolAux.getHijoDerecho());
            }
        }
    }
}