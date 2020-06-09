public interface IPlayerState {
    IPlayerState PushA(PlayerCompornent player);
    IPlayerState PushLeft(PlayerCompornent player);
    IPlayerState PushRight(PlayerCompornent player);
    IPlayerState PushUnder(PlayerCompornent player);
    IPlayerState Neutral(PlayerCompornent player);

}

