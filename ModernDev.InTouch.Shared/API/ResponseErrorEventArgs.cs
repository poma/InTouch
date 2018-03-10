/**
 * This file\code is part of InTouch project.
 *
 * InTouch - is a .NET wrapper for the vk.com API.
 * https://github.com/virtyaluk/InTouch
 *
 * Copyright (c) 2016 Bohdan Shtepan
 * http://modern-dev.com/
 *
 * Licensed under the GPLv3 license.
 */

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ModernDev.InTouch.Tests")]
namespace ModernDev.InTouch
{
    public class ResponseErrorEventArgs
    {
        public bool Handled { get; set; }
        public int RetryCount { get; private set; }
        public ResponseError Error { get; set; }

        public ResponseErrorEventArgs()
        {
        }

        public ResponseErrorEventArgs(ResponseError error, int retryCount)
        {
            RetryCount = retryCount;
            Error = error;
        }
    }
}
