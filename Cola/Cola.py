# Clase Cola - Primero que entra, primero que sale

class Cola:
    
    # Consutructor - Se genera una lista vacia
    def __init__(self):
        self.__c = []
    
    # Metodos
    
    # encolar - Se agrega un elemento en la cola
    def encolar(self, dato):
        self.__c.append(dato)
    
    # desencolar - Se elimina el primer elemento de la cola    
    def desencolar(self):
        return self.__c.pop(0)
    
    # esVacia - Se verifica si la cola es vacia o no
    def esVacia(self):
        return len(self.__c) == 0
        
    # getPrimerDato - Se devuelve el valor del primer dato
    def getPrimerDato(self):
        return self.__c[0]