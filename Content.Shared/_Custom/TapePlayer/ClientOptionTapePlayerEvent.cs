using Robust.Shared.Serialization;

namespace Content.Shared._Custom.TapePlayer;

[Serializable, NetSerializable]
public sealed class ClientOptionTapePlayerEvent : EntityEventArgs
{
    public bool Enabled { get; }
    public ClientOptionTapePlayerEvent(bool enabled)
    {
        Enabled = enabled;
    }
}
