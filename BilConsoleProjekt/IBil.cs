namespace BilConsoleProjekt
{
    public interface IBil
    {
        int BilPrisExAfgift { get; set; }
        int KøbsÅr { get; set; }
        string Mærke { get; set; }

        int HalvÅrligEjerAfgift();
        int RegistreringsAfgift();
        int RækkeVidde();
        string ToString();
        int TotalPris();
    }
}