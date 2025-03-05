namespace Programozas_Tetelek.EgyszeruProgramozasTetelek
{
    public class SorozatszamitasProgramozasTetel
    {
        public int SorozatszamitasOsszeadas(int[] tomb)
        {
            int visszaErtek = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                visszaErtek += tomb[i];
            }
            return visszaErtek;
        }

        public int SorozatszamitasSzorzas(int[] tomb)
        {
            int visszaErtek = 1;
            for (int i = 0; i < tomb.Length; i++)
            {
                visszaErtek *= tomb[i];
            }
            return visszaErtek;
        }
    }
}
