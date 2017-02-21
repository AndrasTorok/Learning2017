namespace AdaptiveCSharp.Refactoring
{
    public interface IAccount
    {
        decimal Balance { get; }
        int RewardPoints { get; }

        void AddTransaction(decimal amount);
        int CalculateRewardPoints(decimal amount);
    }
}