using System;
namespace OopCatExercise
{
	public interface ICat
	{
        public string Eat();
        public void GoToSleep();
        public void WakeUp();
        public bool IsAsleep { get; }
        public int AverageHeight { get; }
        public string Setting { get; }
    }
}
