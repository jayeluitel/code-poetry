public List<Obsession> ConsumeMedia (Brain myBrain, Content mediaContent)
  {
      List<Obsession> myHobbies = new();
      
      foreach(var thought in myBrain)
      {
          var currThought = myBrain.Overanalyze(thought, mediaContent);
          myHobbies.Add(currThought);
      }
      
      return myHobbies;  
  }
