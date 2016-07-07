using Xunit;
namespace NumberToWord.Objects
{
  public class NumberConverterTest
  {
    [Fact]
    public void ConvertToWord_OneDigitNumber_Word()
    {
      NumberConverter newNumberConverter = new NumberConverter();
      Assert.Equal("seven", newNumberConverter.ConvertToWord(7));
    }
    [Fact]
    public void ConvertToWord_between10and20Number_Word()
    {
      NumberConverter newNumberConverter = new NumberConverter();
      Assert.Equal("seventeen", newNumberConverter.ConvertToWord(17));
    }
    [Fact]
    public void ConvertToWord_between11and99Number_Word()
    {
      NumberConverter newNumberConverter = new NumberConverter();
      Assert.Equal("thirty eight", newNumberConverter.ConvertToWord(38));
    }
    [Fact]
    public void ConvertToWord_MultipleOfTen_Number_Word()
    {
      NumberConverter newNumberConverter = new NumberConverter();
      Assert.Equal("fifty", newNumberConverter.ConvertToWord(50));
    }
    [Fact]
    public void ConvertToWord_between101and999_Number_Word()
    {
      NumberConverter newNumberConverter = new NumberConverter();
      Assert.Equal("dos hundred and thirty four", newNumberConverter.ConvertToWord(234));
    }
    [Fact]
    public void ConvertToWord_MultiplesOfOneHundred_Word()
    {
      NumberConverter newNumberConverter = new NumberConverter();
      Assert.Equal("three hundred", newNumberConverter.ConvertToWord(300));
    }
    [Fact]
    public void ConvertToWord_Millions_Word()
    {
      NumberConverter newNumberConverter = new NumberConverter();
      Assert.Equal("one hundred and twenty three million four hundred and fifty six thousand seven hundred and eighty nine", newNumberConverter.ConvertToWord(123456789));
    }
    public void ConvertToWord_Billions_Word()
    {
      NumberConverter newNumberConverter = new NumberConverter();
      Assert.Equal("two billion one hundred and twenty three million four hundred and fifty six thousand seven hundred and eighty nine", newNumberConverter.ConvertToWord(2123456789));
    }
    [Fact]
    public void ConvertToWord_ZeroesInTheMiddle_Word()
    {
      NumberConverter newNumberConverter = new NumberConverter();
      Assert.Equal("one hundred and twenty three million seven hundred and eighty nine", newNumberConverter.ConvertToWord(123000789));
    }
    [Fact]
    public void ConvertToWord_Zero_Word()
    {
      NumberConverter newNumberConverter = new NumberConverter();
      Assert.Equal("zero", newNumberConverter.ConvertToWord(0));
    }
  }
}
