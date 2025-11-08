namespace PrjTDDRedGreenPurple
{
    public static class NumeroHelper2
    {
        public static bool EhPar(int numero) => numero % 2 == 0;

        public static bool EhImpar(int numero) => !EhPar(numero);
    }

}
