﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taskbar11.Models;

namespace Taskbar11.Interfaces
{
    /// <summary>
    /// Interface to notify for a menu change.
    /// </summary>
    public interface IMenuUpdateNotifier
    {
        void UpdateMenu(MenuWindows menuWindow);
    }
}
