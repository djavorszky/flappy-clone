public readonly struct GameEvent<T>
{

    public GameEvent(T value) {
        Payload = value;
    }

    public T Payload { get; }
}
