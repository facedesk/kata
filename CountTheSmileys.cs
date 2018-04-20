public static class Kata
{
  public static bool isValidSmiley(string face)
  {
      bool eyes = face[0]==':' || face[0]==';';
      int end = face.Length-1;
      bool mouth = face[end]==')' || face[end] == 'D';
      bool nose = true;
      if(end > 1)
      {
         nose = face[1]=='-' || face[1] =='~';
      }
      
      return eyes && nose && mouth;
      
      
  }
  public static int CountSmileys(string[] smileys) 
  {
    int scount = 0;
    foreach(string candidate in smileys)
    {
      if(isValidSmiley(candidate))
      {
        scount++;
      }
    }
    
    return scount;
  }
}
