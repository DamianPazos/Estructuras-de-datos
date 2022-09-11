# Clase Cola - Primero que entra, primero que sale

class Cola:
    
    # Consutructor - Se genera una lista vacia
    def __init__(self):
        self.__c = []
    
    # Metodos
    
    # Encolar - Se agrega un elemento en la cola
    def encolar(self, dato):
        self.__c.append(dato)
    
    # Desencolar - Se elimina el primer elemento de la cola    
    def desencolar(self):
        return self.__c.pop(0)
    
    # EsVacia - Se verifica si la cola es vacia o no
    def esVacia(self):
        if len(self.__c) == 0:
            return True
        else: 
            return False
        
    # getPrimerDato - Se devuelve el valor del primer dato
    def getPrimerDato(self):
        return self.__c[0]