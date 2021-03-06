﻿using System;
using System.IO;
using NLog;
using NUnit.Framework;

namespace AppGet.Tests.Infrastructure.Logging
{
    [TestFixture]
    [Explicit]
    public class SentryTargetFixture
    {
        [Test]
        public void send_sample_error()
        {
            var logger = LogManager.GetLogger("SentryTargetFixture");

            try
            {
                logger.Info("Starting unit test");
                File.OpenRead("c:\\invalid_file.text");
            }
            catch (Exception e)
            {
                logger.Fatal(e, "Sample test error");
            }
        }
    }
}