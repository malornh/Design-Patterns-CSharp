using Design_Patterns.Singleton;

// Singletion 

var globalMood = MoodManager.GetInstance("Happy!");
Console.WriteLine(globalMood.Mood);

var localMood = MoodManager.GetInstance("Neutral");
Console.WriteLine(localMood.Mood); // Still Happy!

//

