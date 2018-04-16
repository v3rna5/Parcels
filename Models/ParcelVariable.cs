namespace Parcels.Models
{
  public class ParcelVariable
  {
    private string _length;
    private string _width;
    private string _height;
    private string _weight;
    private float _volume;
    private float lengthNumber;
    private float widthNumber;
    private float heightNumber;
    private float weightNumber;
    private float shippingCost;

    public string GetLength()
    {
      return _length;
    }
    public void SetLength(string newLength)
    {
      _length=newLength;
    }
    public string GetWidth()
    {
      return _width;
    }
    public void SetWidth(string newWidth)
    {
      _width=newWidth;
    }
    public string GetHeight()
    {
      return _height;
    }
    public void SetHeight(string newHeight)
    {
      _height=newHeight;
    }
    public string GetWeight()
    {
      return _weight;
    }
    public void SetWeight(string newWeight)
    {
      _weight=newWeight;
    }
    public float GetVolume()
    {
      lengthNumber=float.Parse(_length);
      widthNumber=float.Parse(_width);
      heightNumber=float.Parse(_height);

      _volume=lengthNumber*widthNumber*heightNumber;

      return _volume;
    }

    public float CostToShip()
    {
      weightNumber=float.Parse(_weight);
      shippingCost=_volume*weightNumber/10;
      return shippingCost;
    }

  }
}


// public class LetterVariable
// {
//   private string _recipient;
//   private string _sender;
//
//   public string GetRecipient()
//   {
//     return _recipient;
//   }
//
//   public void SetRecipient(string newRecipient)
//   {
//     _recipient = newRecipient;
//   }
//
//   public string GetSender()
//   {
//     return _sender;
//   }
//
//   public void SetSender(string newSender)
//   {
//     _sender = newSender;
//   }
// }
