using IRCore;

class ScoreInteractor : ValueInteractor<int, ScoreRepository>
{
    public bool CanPay(int price) => Value >= price;
}