using Robust.Shared.Configuration;

namespace Content.Shared._Custom.CustomCCVars;

[CVarDefs]
public sealed class CustomCCVars
{
    /**
     * Tape Player
     */

    /// <summary>
    /// Параметр отключения школьников с колонками у клиента.
    /// </summary>
    public static readonly CVarDef<bool> TapePlayerClientEnabled =
        CVarDef.Create("tape_player.client_enabled", true, CVar.CLIENTONLY | CVar.ARCHIVE);

}