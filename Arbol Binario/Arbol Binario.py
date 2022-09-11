# Arbol Binario - Arbol que puede tener como maximo grado 2 (solo dos hijos).

# Importamos la clase Cola
import Cola
class ArbolBinario:
    
    # Constructor - Se pide el elemento que se va a guardar en el arbol
    def __init__(self, elem):
        self.__dato = elem
        self.__hijo_izq = None
        self.__hijo_der = None
        
    # Metodos
    
    # get_dato - Devuelve el dato del arbol
    def get_dato(self):
        return self.__dato
    
    # get_hijo_izq - Devuelve el hijo izquierdo del arbol, de no poseer devuelve 'None'
    def get_hijo_izq(self):
        return self.__hijo_izq
    
    # get_hijo_der - Devuelve el hijo derecho del arbol, de no poseer devuelve 'None'
    def get_hijo_der(self):
        return self.__hijo_der
    
    # agregar_hijo_izq - Permite agregar un hijo izquierdo al arbol
    def agregar_hijo_izq(self, elem):
        self.__hijo_izq = elem
    
    # agregar_hijo_der - Permite agregar un hijo derecho al arbol
    def agregar_hijo_der(self, elem):
        self.__hijo_der = elem
        
    # eliminar_hijo_izq - Elimina el hijo izquierdo del arbol
    def eliminar_hijo_izq(self):
        self.__hijo_izq = None
    
    # eliminar_hijo_der - Elimina el hijo derecho del arbol    
    def eliminar_hijo_der(self):
        self.__hijo_der = None
        
    # es_hoja - Determina si el arbol es o no hoja
    def es_hoja(self):
        return self.__hijo_izq == None and self.__hijo_der == None
    
    # inorden - Procesa primero hijo izquierdo, luego el dato y por ultimo el hijo derecho
    def inorden(self):
        # Procesa hijo izquierdo
        if self.__hijo_izq != None:
            self.__hijo_izq.inorden()
        # Procesa el dato
        print(self.__dato)
        # Procesa hijo derecho
        if self.__hijo_der != None:
            self.__hijo_der.inorden()
    
    # preorden - Procesa primero el dato, luego el hijo izquierdo y por ultimo el hijo derecho
    def preorden(self):
        # Procesa el dato
        print(self.__dato)
        # Procesa hijo izquierdo
        if self.__hijo_izq != None:
            self.__hijo_izq.preorden()
        # Procesa hijo Derecho
        if self.__hijo_der != None:
            self.__hijo_der.preorden()
    
    # postorden - Procesa primero el hijo izquierdo, luego el hijo derecho y por el ultimo el dato
    def postorden(self):
        # Procesa hijo izquierdo
        if self.__hijo_izq != None:
            self.__hijo_izq.postorden()
        # Procesa hijo derecho
        if self.__hijo_der != None:
            self.__hijo_der.postorden()
        # Procesa el dato
        print(self.__dato)
        
    # por_niveles - Recorre el arbol por niveles de izquierda a derecha, utiliza la estructura de datos de cola
    def por_niveles(self):
        # Creamos una cola donde se van a almacenar los arboles
        cola = Cola()
        # Encolamos a la raiz del arbol
        cola.encolar(self)
        # Mientras que la cola no este vacia, se va a repetir el proceso de encolar
        while not cola.esVacia():
            # Desencolo el arbol y proceso el dato
            arbol_temporal = cola.desencolar()
            print(arbol_temporal.get_dato())
            # Si el arbol procesado tiene hijo izquierdo, se encola
            if arbol_temporal.get_hijo_izq() != None:
                cola.encolar(arbol_temporal.get_hijo_izq())
            # Si el arbol procesado tiene hijo derecho, se encola
            if arbol_temporal.get_hijo_der() != None:
                cola.encolar(arbol_temporal.get_hijo_der())