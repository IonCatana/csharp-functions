// --- FUNZIONI --- //


// --- Funzione StampaArray --- //
void StampaArray(int[] array)
{
    int ultimoindiceArray = array.Length - 1;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == ultimoindiceArray)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}

// --- Funzione Quadrato --- //
int Quadrato(int numero)
{
    int quadrato = numero * numero;
    return quadrato;
}

// --- Funzione eleva al quadrato l'array --- //
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = Quadrato(copiaArray[i]);
    }
    return copiaArray;
}

// --- Funzione somma elementi del'array --- //
int SommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma = somma + array[i];
    }
    return somma;
}

// --- PROGRAMMA --- //

int[] arrayDiNumeri = { 2, 6, 7, 5, 3, 9 };
StampaArray(arrayDiNumeri);

int numeroTest = 3;
int numeroAlQuadrato = Quadrato(numeroTest);
Console.WriteLine($"Prova, il numero scelto al quadrato é : {numeroAlQuadrato}");

int[] arrayElevatoAlQuadrato = ElevaArrayAlQuadrato(arrayDiNumeri);
StampaArray(arrayElevatoAlQuadrato);
StampaArray(arrayDiNumeri);

int sommaElementiDelArray = SommaElementiArray(arrayDiNumeri);
Console.WriteLine($"La somma degli elementi del'array é : {sommaElementiDelArray}");

int sommaElementiDelArrayAlQuadrato = SommaElementiArray(arrayElevatoAlQuadrato);
Console.WriteLine($"La somma degli elementi del'array al quadrato é : {sommaElementiDelArrayAlQuadrato}");
