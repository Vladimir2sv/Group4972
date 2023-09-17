char[] temp=number.ToString().ToCharArray();
      
      if(number.ToString().Length !=5)
      {
        Console.WriteLine("Число не пятизначное");
        return false;
      }
      else if(temp[0]==temp[4]&&temp[1]==temp[3])
      {
        return true;
      }
      else
      {
        return false;
      }

//------------------------------------------------------------

string num = Convert.ToString(number);

if (num.Length != 5)
{
    Console.WriteLine("Число не пятизначное");
    return false;
}
else if (num[0] == num[4] && num[1] == num[3]) return true;
else return false;