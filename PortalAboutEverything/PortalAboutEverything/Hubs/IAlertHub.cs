﻿namespace PortalAboutEverything.Hubs
{
    public interface IAlertHub
    {
        Task AlertWasCreatedAsync(int alertId, string text);
    }
}
