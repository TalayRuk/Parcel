namespace Parcel.Objects
{
  public class Parcel
  {
    public int Width;
    public int Length;
    public int Depth;
    public int Weight;
    public int Cost;
    public int Volume;

    public Parcel(int packageWidth, int packageLength, int packageDepth, int packageWeight)
    {
      Width = packageWidth;
      Length = packageLength;
      Depth = packageDepth;
      Weight = packageWeight;
    }


    public void SetVolume()
    {
      Volume = Width * Depth * Length;
    }

    public int GetVolume()
    {
      return Volume;
    }


  }
}
