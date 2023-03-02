public class PlayerDoesRoll
{
    public void ResolveRoll(int roll, Match match)
    {
        match.CurrentFrame().AddRoll(roll);

        if (IsFrameComplete(match.CurrentFrame())) match.MoveToNextFrame();

    }


    public bool IsFrameComplete(Frame frame)
    {
        return !frame.AreThereAnyPinsToHitDown() || !frame.HaveRollsToDo();
    }

}

