namespace Kalitim
{
    public interface IMaasAlabilir
    {
        decimal SaatlikUcret { set; }
        decimal Tutar { get; }
        decimal AvansVer();
        decimal OdemeYap();
    }
}
