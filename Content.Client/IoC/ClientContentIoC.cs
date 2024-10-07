using Content.Client.Administration.Managers;
using Content.Client.Changelog;
using Content.Client.Chat.Managers;
using Content.Client.Clickable;
using Content.Client.JoinQueue;
using Content.Client.Options;
using Content.Client.Eui;
using Content.Client.GhostKick;
using Content.Client.Info;
using Content.Client.Launcher;
using Content.Client.Parallax.Managers;
using Content.Client.Players.PlayTimeTracking;
using Content.Client.Preferences;
using Content.Client.Screenshot;
using Content.Client.Fullscreen;
using Content.Client.Stylesheets;
using Content.Client.Viewport;
using Content.Client.Voting;
using Content.Shared.Administration;
using Content.Shared.Administration.Logs;
using Content.Shared.Module;
using Content.Client.Guidebook;
using Content.Client.Replay;
using Content.Shared.Administration.Managers;
using Content.Shared.Players.PlayTimeTracking;
#if LPP_Sponsors  // _LostParadise-Sponsors
using Content.Client._LostParadise.Sponsors;
#endif
#if DiscordAuth
using Content.Client._NC.DiscordAuth;
#endif


namespace Content.Client.IoC
{
    internal static class ClientContentIoC
    {
        public static void Register()
        {
            var collection = IoCManager.Instance!;

            IoCManager.Register<IParallaxManager, ParallaxManager>();
            IoCManager.Register<IChatManager, ChatManager>();
            IoCManager.Register<IClientPreferencesManager, ClientPreferencesManager>();
            IoCManager.Register<IStylesheetManager, StylesheetManager>();
            IoCManager.Register<IScreenshotHook, ScreenshotHook>();
            IoCManager.Register<FullscreenHook, FullscreenHook>();
            IoCManager.Register<IClickMapManager, ClickMapManager>();
            IoCManager.Register<IClientAdminManager, ClientAdminManager>();
            IoCManager.Register<ISharedAdminManager, ClientAdminManager>();
            IoCManager.Register<EuiManager, EuiManager>();
            IoCManager.Register<IVoteManager, VoteManager>();
            IoCManager.Register<ChangelogManager, ChangelogManager>();
            IoCManager.Register<RulesManager, RulesManager>();
            IoCManager.Register<ViewportManager, ViewportManager>();
            IoCManager.Register<ISharedAdminLogManager, SharedAdminLogManager>();
            IoCManager.Register<GhostKickManager>();
            IoCManager.Register<ExtendedDisconnectInformationManager>();
            IoCManager.Register<JobRequirementsManager>();
            IoCManager.Register<DocumentParsingManager>();
            IoCManager.Register<ContentReplayPlaybackManager, ContentReplayPlaybackManager>();
            collection.Register<ISharedPlaytimeManager, JobRequirementsManager>();
            IoCManager.Register<JoinQueueManager>();
#if LPP_Sponsors  // _LostParadise-Sponsors
            collection.Register<SponsorsManager>();
#endif
#if DiscordAuth
            IoCManager.Register<DiscordAuthManager>();
#endif
        }
    }
}
