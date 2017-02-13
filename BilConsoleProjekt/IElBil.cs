namespace BilConsoleProjekt
{
    public interface IElBil
    {
        int BatteriKapacitet { get; }
        int KmPrKW { get; }
        int HalvÅrligEjerAfgift();
        int RegistreringsAfgift();
        int RækkeVidde();
    }
}